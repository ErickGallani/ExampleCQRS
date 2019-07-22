namespace ExampleCQRS.Domain.Validations.ValueObjects
{
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using ExampleCQRS.CrossCutting.ErrorMappings;
    using ExampleCQRS.CrossCutting.Extensions;
    using ExampleCQRS.Domain.ValueObjects;
    using FluentValidation;

    public class EmailValidation : AbstractValidator<Email>
    {
        public EmailValidation() => 
            AddValidateEmailValue();

        private void AddValidateEmailValue() =>
            RuleFor<string>(email => email)
                .NotNull()
                .NotEmpty()
                    .WithErrorCode(Errors.EmailErrorCode.EmptyOrNullEmail.GetString())
                    .WithMessage(ErrorMapping.EmailMap[Errors.EmailErrorCode.EmptyOrNullEmail])
                .EmailAddress()
                    .WithErrorCode(Errors.EmailErrorCode.InvalidEmail.GetString())
                    .WithMessage(ErrorMapping.EmailMap[Errors.EmailErrorCode.InvalidEmail]);
    }
}