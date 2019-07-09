namespace ExampleCQRS.CrossCutting.ErrorCodes
{
    using System;
    using System.Globalization;

    public static class UserError 
    {
        public enum Code
        {
            InvalidUserId = 1050
        }

        public static string GetString(this Code code) =>
            Convert.ToString(code, CultureInfo.InvariantCulture);
    }
}