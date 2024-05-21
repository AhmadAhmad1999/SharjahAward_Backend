using SharijhaAward.Application.Contract.Infrastructure;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Infrastructure.ExcelHelper
{
    public class ExcelHelper<T> : IExcelHelper<T> where T : class
    {
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

            var stream = new MemoryStream();
            workbook.Write(stream);
            var content = stream.ToArray();

            return content;
        }
    }
}
