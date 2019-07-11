namespace ExampleCQRS.Domain.Notifications
{
    using System;
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using ExampleCQRS.Domain.Core.Events;

    public class ErrorNotification : Event
    {
        public ErrorNotification(string code, string message) 
            : base()
        {
            this.Code = code;
            this.Message = message;
        }

        public string Code { get; private set; }

        public string Message { get; private set; }
    }
}