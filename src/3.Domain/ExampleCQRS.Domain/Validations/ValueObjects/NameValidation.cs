namespace ExampleCQRS.Domain.Validations.ValueObjects
{
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using ExampleCQRS.CrossCutting.ErrorMappings;
    using ExampleCQRS.CrossCutting.Extensions;
    using ExampleCQRS.Domain.ValueObjects;
    using FluentValidation;

    public class NameValidation  : AbstractValidator<Name>
    {
        public NameValidation() => 
            AddValidatorName();

        private void AddValidatorName() =>
            RuleFor<string>(name => name)
                .NotNull()
                .NotEmpty()
                    .WithErrorCode(Errors.NameErrorCode.EmptyOrNullName.GetString())
                    .WithMessage(ErrorMapping.NameMap[Errors.NameErrorCode.EmptyOrNullName])
                .Length(1, 150)
                    .WithErrorCode(Errors.NameErrorCode.InvalidName.GetString())
                    .WithMessage(ErrorMapping.NameMap[Errors.NameErrorCode.InvalidName]);
    }
}