namespace ExampleCQRS.Domain.ValueObjects
{
    using System.Collections.Generic;
    using ExampleCQRS.Domain.Core.ValueObjects;

    public class Email : ValueObject
    {
        public string EmailValue { get; set; }

        public Email(string emailValue) => 
            this.EmailValue = emailValue;

        public override IEnumerable<object> GetValues()
        {
            yield return EmailValue; 
        }
    }
}