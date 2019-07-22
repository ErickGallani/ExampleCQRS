namespace ExampleCQRS.CrossCutting.ErrorCodes
{
    public static partial class Errors
    {
        public enum EmailErrorCode
        {
            InvalidEmail = 2050,
            EmptyOrNullEmail = 2051
        }
    }
}
