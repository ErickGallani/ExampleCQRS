namespace ExampleCQRS.CrossCutting.ErrorMappings
{
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using System;
    using System.Collections.Generic;

    public static partial class ErrorMapping
    {
        public static IDictionary<Enum, string> EmailMap =>
            new Dictionary<Enum, string>()
            {
                { Errors.EmailErrorCode.InvalidEmail, "Invalid email" },
                { Errors.EmailErrorCode.EmptyOrNullEmail, "Email can't be null or empty" }
            };
    }
}
