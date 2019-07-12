namespace ExampleCQRS.Application.Errors
{
    public class Error
    {
        public Error(string code, string message)
        {
            this.Code = code;
            this.Message = message;
        }

        public string Code;
        
        public string Message;
    }
}