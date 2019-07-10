namespace ExampleCQRS.Domain.ValueObjects
{
    using System.Collections.Generic;
    using ExampleCQRS.Domain.Core.ValueObjects;
    using ExampleCQRS.Domain.Validations.ValueObjects;
    using FluentValidation;

    public class Email : ValueObject<Email>
    {
        private Email() { }

        public Email(string value) => 
            this.Value = value;

        public string Value { get; private set; }

        public override IValidator<Email> GetValidator() =>
            new EmailValidation();

        public override IEnumerable<object> GetValues()
        {
            yield return Value; 
        }

        public static implicit operator string(Email email) =>
            email.Value;
    }
}