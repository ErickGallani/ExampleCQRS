namespace ExampleCQRS.Application.Services
{
    using System.Collections.Generic;
    using ExampleCQRS.Application.Enums;
    using ExampleCQRS.Application.Errors;

    public struct ServiceResponse
    {
        public ServiceResponse(
            ServiceResponseStatus status, 
            IEnumerable<Error> errors)
        {
            this.Status = status;
            this.Errors = errors;
        }

        public ServiceResponseStatus Status;

        public IEnumerable<Error> Errors;
    }
}