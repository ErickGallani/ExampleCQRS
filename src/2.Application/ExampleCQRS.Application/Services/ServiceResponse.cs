using System.Collections.Generic;
using ExampleCQRS.Application.Enums;
using ExampleCQRS.Application.Errors;

namespace ExampleCQRS.Application.Services
{
    public readonly struct ServiceResponse
    {
        private readonly ServiceResponseStatus status;

        private readonly IEnumerable<Error> errors;

        public ServiceResponse(
            ServiceResponseStatus status, 
            IEnumerable<Error> errors)
        {
            this.status = status;
            this.errors = errors;
        }
        
        public ServiceResponseStatus GetSuccess() => status;

        public IEnumerable<Error> GetErrors() => this.errors;
    }
}