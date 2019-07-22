namespace ExampleCQRS.Domain.Validations.ValueObjects
{
    using System;
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using ExampleCQRS.CrossCutting.ErrorMappings;
    using ExampleCQRS.CrossCutting.Extensions;
    using ExampleCQRS.Domain.ValueObjects;
    using FluentValidation;

    public class BirthDateValidation : AbstractValidator<BirthDate>
    {
        public BirthDateValidation() => 
            AddValidateBirthDate();

        private void AddValidateBirthDate() =>
            RuleFor(birthDate => birthDate)
                .NotNull()
                    .WithErrorCode(Errors.BirthDateErrorCode.EmptyOrNullBirthDate.GetString())
                    .WithMessage(ErrorMapping.BirthDateMap[Errors.EmailErrorCode.EmptyOrNullEmail])
                .Must((birthDate) => birthDate > new DateTime(1900, 1, 1))
                    .WithErrorCode(Errors.BirthDateErrorCode.InvalidBirthDate.GetString())
                    .WithMessage(ErrorMapping.BirthDateMap[Errors.EmailErrorCode.EmptyOrNullEmail]);
    }
}