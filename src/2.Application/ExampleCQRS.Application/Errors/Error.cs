namespace ExampleCQRS.Application.Errors
{
    public class Error
    {
        private readonly string code;
        
        private readonly string message;

        public Error(string code, string message)
        {
            this.code = code;
            this.message = message;
        }
    }
}