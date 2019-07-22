namespace ExampleCQRS.CrossCutting.ErrorMappings
{
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using System;
    using System.Collections.Generic;

    public static partial class ErrorMapping
    {
        public static IDictionary<Enum, string> NameMap =>
            new Dictionary<Enum, string>()
            {
                { Errors.NameErrorCode.InvalidName, "Invalid name. A name musta have from 1 to 150 characteres" },
                { Errors.NameErrorCode.EmptyOrNullName, "Name can't be null or empty" }
            };
    }
}
