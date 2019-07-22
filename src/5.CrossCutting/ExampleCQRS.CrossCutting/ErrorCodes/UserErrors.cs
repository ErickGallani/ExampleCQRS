namespace ExampleCQRS.CrossCutting.ErrorCodes
{
    public static partial class Errors
    {
        public enum UserErrorCode
        {
            InvalidUserId = 4050,
            UserAlreadyExists = 4051
        }
    }
}