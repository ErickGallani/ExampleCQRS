namespace ExampleCQRS.CrossCutting.ErrorMappings
{
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using System;
    using System.Collections.Generic;

    public static partial class ErrorMapping
    {
        public static IDictionary<Enum, string> BirthDateMap =>
            new Dictionary<Enum, string>()
            {
                { Errors.BirthDateErrorCode.InvalidBirthDate, "Invalid birth date" },
                { Errors.BirthDateErrorCode.EmptyOrNullBirthDate, "Birth date can't be null or empty" }
            };
    }
}
