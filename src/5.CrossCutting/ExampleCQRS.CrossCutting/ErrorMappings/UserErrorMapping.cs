using System;
using System.Collections.Generic;
using ExampleCQRS.CrossCutting.ErrorCodes;

namespace ExampleCQRS.CrossCutting.ErrorMappings
{
    public static class UserErrorMapping
    {
        public static IDictionary<Enum, string> Map => 
            new Dictionary<Enum, string>()
            {
                { UserError.Code.InvalidUserId, "Invalid user id" },
                { UserError.Code.UserAlreadyExists, "An user with this email already exists" }
            };
    }
}