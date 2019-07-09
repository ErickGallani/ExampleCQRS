namespace ExampleCQRS.Domain.Validations.ValueObjects
{
    using System;
    using ExampleCQRS.Domain.ValueObjects;
    using FluentValidation;

    public class BirthDateValidation : AbstractValidator<BirthDate>
    {
        public BirthDateValidation() => 
            AddValidateBirthDate();

        private void AddValidateBirthDate() =>
            RuleFor(birthDate => birthDate)
                .NotNull()
                .Must((birthDate) => birthDate > new DateTime(1900, 1, 1))
                .WithErrorCode("");
    }
}