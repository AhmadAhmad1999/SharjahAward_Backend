using MediatR;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using System.Dynamic;

namespace SharijhaAward.Application.Helpers.ExportReportForAdvancedFormBuilder
{
    public class ExportReportForAdvancedFormBuilderHandler : IRequestHandler<ExportReportForAdvancedFormBuilderCommand, BaseResponse<List<object>>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository;
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;

        public ExportReportForAdvancedFormBuilderHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderValue> AdvancedFormBuilderValueRepository,
            IAsyncRepository<VirtualTableForSection> VirtualTableForSectionRepository)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderValueRepository = AdvancedFormBuilderValueRepository;
            _VirtualTableForSectionRepository = VirtualTableForSectionRepository;
        }

        public async Task<BaseResponse<List<object>>> Handle(ExportReportForAdvancedFormBuilderCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            VirtualTableForSection? VirtualTableForSectionEntity = await _VirtualTableForSectionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.VirtualTableForSectionId);

            if (VirtualTableForSectionEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Virtual table for section is not Found"
                    : "الجدول الافتراضي للقسم غير موجود";

                return new BaseResponse<List<object>>(ResponseMessage, false, 404);
            }

            List<object> OutPutList = new List<object>();

            List<AdvancedFormBuilder> AdvancedFormBuilderEntities = await _AdvancedFormBuilderRepository
                .Include(x => x.AdvancedFormBuilderSection!)
                .Where(x => x.AdvancedFormBuilderSection!.VirtualTableForSectionId == Request.VirtualTableForSectionId)
                .ToListAsync();

            if (Request.page != 0 && Request.pageSize != -1)
            {
                var AdvancedFormBuilderValueEntities = _AdvancedFormBuilderValueRepository
                    .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Any(y => y == x.AdvancedFormBuilderId))
                    .Include(x => x.AdvancedFormBuilder!)
                    .Include(x => x.AdvancedFormBuilder!.AttributeDataType!)
                    .Select(x => new
                    {
                        x.AdvancedFormBuilderId,
                        x.VirtualTableId,
                        x.Value,
                        AttributeDataTypeName = x.AdvancedFormBuilder!.AttributeDataType!.Name
                    })
                    .GroupBy(x => x.VirtualTableId)
                    .AsEnumerable()
                    .Skip((Request.page - 1) * Request.pageSize)
                    .Take(Request.pageSize)
                    .ToList();

                if (Request.lang == "en")
                {
                    foreach (var AdvancedFormBuilderValueGroupEntities in AdvancedFormBuilderValueEntities)
                    {
                        dynamic OutPut = new ExpandoObject();

                        foreach (AdvancedFormBuilder AdvancedFormBuilderEntity in AdvancedFormBuilderEntities)
                        {
                            var AdvancedFormBuilderValueEntity = AdvancedFormBuilderValueGroupEntities
                                .FirstOrDefault(x => x.AdvancedFormBuilderId == AdvancedFormBuilderEntity.Id);

                            if (AdvancedFormBuilderValueEntity is not null)
                            {
                                if (AdvancedFormBuilderValueEntity.AttributeDataTypeName == "Number")
                                {
                                    int ActualValue = int.Parse(AdvancedFormBuilderValueEntity.Value);

                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.EnglishLabel, ActualValue));
                                }
                                else if (AdvancedFormBuilderValueEntity.AttributeDataTypeName == "Date")
                                {
                                    DateTime ActualValue = DateTime.Parse(AdvancedFormBuilderValueEntity.Value);

                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.EnglishLabel, ActualValue));
                                }
                                else
                                {
                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.EnglishLabel,
                                        AdvancedFormBuilderValueEntity.Value));
                                }
                            }
                            else
                            {
                                ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.EnglishLabel, null));
                            }
                        }

                        OutPutList.Add(OutPut);
                    }
                }
                else
                {
                    foreach (var AdvancedFormBuilderValueGroupEntities in AdvancedFormBuilderValueEntities)
                    {
                        dynamic OutPut = new ExpandoObject();

                        foreach (AdvancedFormBuilder AdvancedFormBuilderEntity in AdvancedFormBuilderEntities)
                        {
                            var AdvancedFormBuilderValueEntity = AdvancedFormBuilderValueGroupEntities
                                .FirstOrDefault(x => x.AdvancedFormBuilderId == AdvancedFormBuilderEntity.Id);

                            if (AdvancedFormBuilderValueEntity is not null)
                            {
                                if (AdvancedFormBuilderValueEntity.AttributeDataTypeName == "Number")
                                {
                                    int ActualValue = int.Parse(AdvancedFormBuilderValueEntity.Value);

                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.ArabicLabel, ActualValue));
                                }
                                else if (AdvancedFormBuilderValueEntity.AttributeDataTypeName == "Date")
                                {
                                    DateTime ActualValue = DateTime.Parse(AdvancedFormBuilderValueEntity.Value);

                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.ArabicLabel, ActualValue));
                                }
                                else
                                {
                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.ArabicLabel,
                                        AdvancedFormBuilderValueEntity.Value));
                                }
                            }
                            else
                            {
                                ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.ArabicLabel, null));
                            }
                        }

                        OutPutList.Add(OutPut);
                    }
                }
            }
            else
            {
                var AdvancedFormBuilderValueEntities = await _AdvancedFormBuilderValueRepository
                    .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Any(y => y == x.AdvancedFormBuilderId))
                    .Include(x => x.AdvancedFormBuilder!)
                    .Include(x => x.AdvancedFormBuilder!.AttributeDataType!)
                    .Select(x => new
                    {
                        x.AdvancedFormBuilderId,
                        x.VirtualTableId,
                        x.Value,
                        AttributeDataTypeName = x.AdvancedFormBuilder!.AttributeDataType!.Name
                    })
                    .GroupBy(x => x.VirtualTableId)
                    .ToListAsync();

                if (Request.lang == "en")
                {
                    foreach (var AdvancedFormBuilderValueGroupEntities in AdvancedFormBuilderValueEntities)
                    {
                        dynamic OutPut = new ExpandoObject();

                        foreach (AdvancedFormBuilder AdvancedFormBuilderEntity in AdvancedFormBuilderEntities)
                        {
                            var AdvancedFormBuilderValueEntity = AdvancedFormBuilderValueGroupEntities
                                .FirstOrDefault(x => x.AdvancedFormBuilderId == AdvancedFormBuilderEntity.Id);

                            if (AdvancedFormBuilderValueEntity is not null)
                            {
                                if (AdvancedFormBuilderValueEntity.AttributeDataTypeName == "Number")
                                {
                                    int ActualValue = int.Parse(AdvancedFormBuilderValueEntity.Value);

                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.EnglishLabel, ActualValue));
                                }
                                else if (AdvancedFormBuilderValueEntity.AttributeDataTypeName == "Date")
                                {
                                    DateTime ActualValue = DateTime.Parse(AdvancedFormBuilderValueEntity.Value);

                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.EnglishLabel, ActualValue));
                                }
                                else
                                {
                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.EnglishLabel,
                                        AdvancedFormBuilderValueEntity.Value));
                                }
                            }
                            else
                            {
                                ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.EnglishLabel, null));
                            }
                        }

                        OutPutList.Add(OutPut);
                    }
                }
                else
                {
                    foreach (var AdvancedFormBuilderValueGroupEntities in AdvancedFormBuilderValueEntities)
                    {
                        dynamic OutPut = new ExpandoObject();

                        foreach (AdvancedFormBuilder AdvancedFormBuilderEntity in AdvancedFormBuilderEntities)
                        {
                            var AdvancedFormBuilderValueEntity = AdvancedFormBuilderValueGroupEntities
                                .FirstOrDefault(x => x.AdvancedFormBuilderId == AdvancedFormBuilderEntity.Id);

                            if (AdvancedFormBuilderValueEntity is not null)
                            {
                                if (AdvancedFormBuilderValueEntity.AttributeDataTypeName == "Number")
                                {
                                    int ActualValue = int.Parse(AdvancedFormBuilderValueEntity.Value);

                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.ArabicLabel, ActualValue));
                                }
                                else if (AdvancedFormBuilderValueEntity.AttributeDataTypeName == "Date")
                                {
                                    DateTime ActualValue = DateTime.Parse(AdvancedFormBuilderValueEntity.Value);

                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.ArabicLabel, ActualValue));
                                }
                                else
                                {
                                    ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.ArabicLabel,
                                        AdvancedFormBuilderValueEntity.Value));
                                }
                            }
                            else
                            {
                                ((IDictionary<String, Object?>)OutPut).Add(new KeyValuePair<string, object?>(AdvancedFormBuilderEntity.ArabicLabel, null));
                            }
                        }

                        OutPutList.Add(OutPut);
                    }
                }
            }

            if (!Request.ExportDataToExcel)
            {
                return new BaseResponse<List<object>>(ResponseMessage, true, 200, OutPutList);
            }
            else
            {
                XSSFWorkbook Workbook = new XSSFWorkbook();

                ISheet Sheet = Workbook.CreateSheet(Request.lang == "en"
                    ? VirtualTableForSectionEntity.EnglishTitle + "Sheet"
                    : VirtualTableForSectionEntity.ArabicTitle + "Sheet");

                IRow RowHeader = Sheet.CreateRow(0);

                var Headers = AdvancedFormBuilderEntities
                    .Select(entity => Request.lang == "en"
                        ? (new
                        {
                            Label = entity.EnglishLabel,
                            AttributeDataTypeName = entity.AttributeDataType!.Name
                        }) : (new
                        {
                            Label = entity.ArabicLabel,
                            AttributeDataTypeName = entity.AttributeDataType!.Name
                        })).ToList();

                IFont Font = Workbook.CreateFont();
                Font.IsBold = true;

                ICellStyle Style = Workbook.CreateCellStyle();
                Style.SetFont(Font);

                int ColIndex = 0;
                foreach (var Header in Headers)
                {
                    ICell Cell = RowHeader.CreateCell(ColIndex);
                    Cell.SetCellValue(Header.Label);
                    Cell.CellStyle = Style;
                    ColIndex++;
                }

                int RowNumber = 1;
                foreach (object OutPut in OutPutList)
                {
                    IRow RowContent = Sheet.CreateRow(RowNumber);

                    int ColContentIndex = 0;
                    foreach (var Header in Headers)
                    {
                        ICell CellContent = RowContent.CreateCell(ColContentIndex);
                        object? Value = OutPutList.GetType().GetProperty(Header.Label)!.GetValue(OutPut, null);

                        if (Value is null)
                            CellContent.SetCellValue("");

                        else if (Header.AttributeDataTypeName == "Text" ||
                            Header.AttributeDataTypeName == "Email" ||
                            Header.AttributeDataTypeName == "Image" ||
                            Header.AttributeDataTypeName == "File" ||
                            Header.AttributeDataTypeName == "Phone Number" ||
                            Header.AttributeDataTypeName == "Location" ||
                            Header.AttributeDataTypeName == "List" ||
                            Header.AttributeDataTypeName == "Emirates ID number")
                        {
                            CellContent.SetCellValue(Value.ToString());
                        }
                        else if (Header.AttributeDataTypeName == "Number")
                            CellContent.SetCellValue(Convert.ToInt32(Value));

                        else if (Header.AttributeDataTypeName == "Date")
                            CellContent.SetCellValue(Convert.ToDateTime(Value));

                        else
                            CellContent.SetCellValue(Value.ToString());

                        ColContentIndex++;
                    }

                    RowNumber++;
                }

                MemoryStream Stream = new MemoryStream();

                Workbook.Write(Stream);

                object Content = Stream.ToArray();

                return new BaseResponse<List<object>>(Request.lang == "en"
                    ? VirtualTableForSectionEntity.EnglishTitle
                    : VirtualTableForSectionEntity.ArabicTitle, true, 200, new List<object>(){ Content });
            }
        }
    }
}
