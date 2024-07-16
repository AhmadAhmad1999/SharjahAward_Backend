using SharijhaAward.Application.Contract.Infrastructure;
using NPOI.XSSF.UserModel;
using NPOI.SS.Util;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using Microsoft.Extensions.DependencyInjection;

namespace SharijhaAward.Application.Helpers.ExcelHelper
{
    public class ExcelHelper<T> : IExcelHelper<T> where T : class
    {
        private IServiceProvider _ServiceProvider;
        

        public ExcelHelper(IServiceProvider serviceProvider)
        {
            _ServiceProvider = serviceProvider;
        }


        public byte[] ExportToExcel (List<T> data)
        {
            var workbook = new XSSFWorkbook();
            var sheet = workbook.CreateSheet("Sheet1");
            var rowHeader = sheet.CreateRow(0);

            var properties = typeof(T).GetProperties();

            //header
            var font = workbook.CreateFont();
            font.IsBold = true;
            var style = workbook.CreateCellStyle();
            style.SetFont(font);

            var colIndex = 0;
            foreach (var property in properties)
            {
                var cell = rowHeader.CreateCell(colIndex);
                cell.SetCellValue(property.Name);
                cell.CellStyle = style;
                colIndex++;
            }
            //end header


            //content
            var rowNum = 1;
            foreach (var item in data)
            {
                var rowContent = sheet.CreateRow(rowNum);

                var colContentIndex = 0;
                foreach (var property in properties)
                {
                    var cellContent = rowContent.CreateCell(colContentIndex);
                    var value = property.GetValue(item, null);

                    if (value == null)
                    {
                        cellContent.SetCellValue("");
                    }
                    else if (property.PropertyType == typeof(string))
                    {
                        cellContent.SetCellValue(value.ToString());
                    }
                    else if (property.PropertyType == typeof(int) || property.PropertyType == typeof(int?))
                    {
                        cellContent.SetCellValue(Convert.ToInt32(value));
                    }
                    else if (property.PropertyType == typeof(decimal) || property.PropertyType == typeof(decimal?))
                    {
                        cellContent.SetCellValue(Convert.ToDouble(value));
                    }
                    else if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?))
                    {
                        var dateValue = (DateTime)value;
                        cellContent.SetCellValue(dateValue.ToString("yyyy-MM-dd"));
                    }
                    else if (property.PropertyType == typeof(List<string>))
                    {
                        var stringList = (List<string>)value;
                        var combinedString = string.Join(", ", stringList);
                        cellContent.SetCellValue(combinedString);
                    }
                    else cellContent.SetCellValue(value.ToString());
                    colContentIndex++;
                }

                rowNum++;
            }

            //end content


            var stream = new MemoryStream();
            workbook.Write(stream);
            var content = stream.ToArray();

            return content;
        }

        public List<T> ImportFromExcel(byte[] fileContent)
        {
            var workbook = new XSSFWorkbook(new MemoryStream(fileContent));
            var sheet = workbook.GetSheetAt(0);
            var properties = typeof(T).GetProperties();
            var dataList = new List<T>();

            var headerRow = sheet.GetRow(0);

            for (int rowIndex = 1; rowIndex <= sheet.LastRowNum; rowIndex++)
            {
                var dataRow = sheet.GetRow(rowIndex);
                var item = Activator.CreateInstance<T>();

                for (int colIndex = 0; colIndex < properties.Length; colIndex++)
                {
                    var property = properties[colIndex];
                    var cell = dataRow.GetCell(colIndex);

                    if (cell != null)
                    {
                        var cellValue = cell.ToString();

                        if (property.PropertyType == typeof(string))
                        {
                            property.SetValue(item, cellValue);
                        }
                        else if (property.PropertyType == typeof(int) || property.PropertyType == typeof(int?))
                        {
                            int intValue;
                            if (int.TryParse(cellValue, out intValue))
                            {
                                property.SetValue(item, intValue);
                            }
                        }
                        else if (property.PropertyType == typeof(decimal) || property.PropertyType == typeof(decimal?))
                        {
                            decimal decimalValue;
                            if (decimal.TryParse(cellValue, out decimalValue))
                            {
                                property.SetValue(item, decimalValue);
                            }
                        }
                        else if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?))
                        {
                            DateTime dateValue;
                            if (DateTime.TryParse(cellValue, out dateValue))
                            {
                                property.SetValue(item, dateValue);
                            }
                        }
                        else if (property.PropertyType == typeof(List<string>))
                        {
                            var stringListValue = cellValue.Split(',').Select(s => s.Trim()).ToList();
                            property.SetValue(item, stringListValue);
                        }
                        else if(property.Name.EndsWith("Id") && property.PropertyType == typeof(int))
                        {
                            IAsyncRepository<EducationalEntity> _educationalEntityRepository = _ServiceProvider.GetService<IAsyncRepository<EducationalEntity>>();
                            int EducationalEntityId = _educationalEntityRepository.FirstOrDefault(e => e.ArabicName == "").Id;
                        }
                    }
                }

                dataList.Add(item);
            }

            return dataList;
        }


        public byte[] GeneratePrototype()
        {
            var workbook = new XSSFWorkbook();
            var sheet = workbook.CreateSheet("Sheet1");
            var rowHeader = sheet.CreateRow(0);

            var properties = typeof(T).GetProperties();

            // Header font and style
            var font = workbook.CreateFont();
            font.IsBold = true;
            var style = workbook.CreateCellStyle();
            style.SetFont(font);

            var colIndex = 0;
            foreach (var property in properties)
            {
                var cell = rowHeader.CreateCell(colIndex);
                cell.SetCellValue(property.Name);
                cell.CellStyle = style;
                colIndex++;
            }

            // Create rows for foreign key dropdowns
            colIndex = 0;
            foreach (var property in properties)
            {
                
                if (property.Name.EndsWith("Id") && property.PropertyType == typeof(int))
                {
                    var fkValues = GetForeignKeyValues(property.Name);
                    if (fkValues != null && fkValues.Any())
                    {
                        // Create a sheet to hold the list of foreign key values
                        var listSheet = workbook.CreateSheet(property.Name + "_List");
                        for (int i = 0; i < fkValues.Count; i++)
                        {
                            var listRow = listSheet.CreateRow(i);
                            listRow.CreateCell(0).SetCellValue(fkValues[i]);
                        }

                        // Create a named range for the list
                        var rangeName = property.Name + "_List";
                        var name = workbook.CreateName();
                        name.NameName = rangeName;
                        name.RefersToFormula = $"{property.Name}_List!$A$1:$A${fkValues.Count}";

                        // Create a dropdown list for the foreign key column
                        var constraint = sheet.GetDataValidationHelper().CreateExplicitListConstraint(fkValues.ToArray());
                        var addressList = new CellRangeAddressList(1, 65535, colIndex, colIndex);
                        var validation = sheet.GetDataValidationHelper().CreateValidation(constraint, addressList);
                        sheet.AddValidationData(validation);
                    }
                }
                colIndex++;
            }

            var stream = new MemoryStream();
            workbook.Write(stream);
            var content = stream.ToArray();

            return content;
        }

        private List<string> GetForeignKeyValues(string foreignKeyName)
        {
            //string TableName = foreignKeyName.Split("Id")[0];

           // using (var context = new )
                switch (foreignKeyName)
                {
                    case "EducationalEntityId":
                        {
                            IAsyncRepository<EducationalEntity> _educationalEntityRepository = _ServiceProvider.GetService<IAsyncRepository<EducationalEntity>>();
                            var Edu = _educationalEntityRepository.Select(e => e.ArabicName).ToList();
                            return Edu;
                        }
                    default:
                        return null;
                }
        }
    }
}
