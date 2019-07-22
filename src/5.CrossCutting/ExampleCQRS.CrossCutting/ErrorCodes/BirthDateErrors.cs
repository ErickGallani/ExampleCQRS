namespace ExampleCQRS.CrossCutting.ErrorCodes
{
    public static partial class Errors
    {
        public enum BirthDateErrorCode
        {
            InvalidBirthDate = 1050,
            EmptyOrNullBirthDate = 1051
        }
    }
}
