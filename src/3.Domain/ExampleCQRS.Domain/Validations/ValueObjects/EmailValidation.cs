namespace ExampleCQRS.Domain.Validations.ValueObjects
{
    using ExampleCQRS.Domain.ValueObjects;
    using FluentValidation;

    public class EmailValidation : AbstractValidator<Email>
    {
        public EmailValidation() => 
            AddValidateEmailValue();

        private void AddValidateEmailValue() =>
            RuleFor<string>(email => email)
                .EmailAddress()
                .WithMessage("Invalid email");
    }
}