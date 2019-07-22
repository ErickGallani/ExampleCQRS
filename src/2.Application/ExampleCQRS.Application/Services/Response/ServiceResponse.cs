namespace ExampleCQRS.Application.Services.Response
{
    using ExampleCQRS.Application.Enums;

    public class ServiceResponse
    {
        private readonly ServiceResponseStatus status;

        public ServiceResponse(ServiceResponseStatus status) 
            => this.status = status;

        public bool Success() => this.status == ServiceResponseStatus.Success;
    }
}