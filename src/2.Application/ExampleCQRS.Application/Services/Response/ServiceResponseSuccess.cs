namespace ExampleCQRS.Application.Services.Response
{
    using ExampleCQRS.Application.Enums;

    public class ServiceResponseSuccess : ServiceResponse
    {
        public ServiceResponseSuccess() : 
            base(ServiceResponseStatus.Success)
        { }
    }
}
