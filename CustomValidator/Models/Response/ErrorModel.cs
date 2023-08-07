namespace CustomValidator.Models.Response
{
    public class ErrorModel
    {
        public string ErrorCode { get; set; }
        public string FieldName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
