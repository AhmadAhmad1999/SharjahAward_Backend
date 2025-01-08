namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetInputedAdvancedFormsByVirtualTableId
{
    public class GetInputedAdvancedFormsByVirtualTableIdDto
    {
        public List<object> ColumnsNames { get; set; } = new List<object>();
        public object Values { get; set; } = new object();
    }
}
