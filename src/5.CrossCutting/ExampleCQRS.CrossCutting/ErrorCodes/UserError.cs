namespace ExampleCQRS.CrossCutting.ErrorCodes
{
    public static class UserError
    {
        public enum Code
        {
            InvalidUserId = 1050,
            UserAlreadyExists = 1051
        }
    }
}