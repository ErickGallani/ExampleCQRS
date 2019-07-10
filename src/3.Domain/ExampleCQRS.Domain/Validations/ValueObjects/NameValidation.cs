namespace ExampleCQRS.Domain.Validations.ValueObjects
{
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
                .Length(1, 150)
                .WithMessage("Invalid name");
    }
}