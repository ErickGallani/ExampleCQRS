namespace ExampleCQRS.Application.Services.Response
{
    using ExampleCQRS.Application.Enums;
    using ExampleCQRS.Application.Errors;
    using System.Collections.Generic;

    public class ServiceResponseError : ServiceResponse
    {
        public ServiceResponseError(IEnumerable<Error> errors) :
            base(ServiceResponseStatus.Error) => 
            this.Errors = errors;

        public IEnumerable<Error> Errors { get; private set; }
    }
}
