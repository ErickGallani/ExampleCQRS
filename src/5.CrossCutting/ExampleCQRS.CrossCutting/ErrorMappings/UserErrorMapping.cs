namespace ExampleCQRS.CrossCutting.ErrorMappings
{
    using System;
    using System.Collections.Generic;
    using ExampleCQRS.CrossCutting.ErrorCodes;

    public static partial class ErrorMapping
    {
        public static IDictionary<Enum, string> UserMap => 
            new Dictionary<Enum, string>()
            {
                { Errors.UserErrorCode.InvalidUserId, "Invalid user id" },
                { Errors.UserErrorCode.UserAlreadyExists, "An user with this email already exists" }
            };
    }
}