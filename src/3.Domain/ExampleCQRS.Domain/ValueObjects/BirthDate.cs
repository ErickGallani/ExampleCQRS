namespace ExampleCQRS.Domain.ValueObjects
{
    using System.Collections.Generic;
    using System;
    using ExampleCQRS.Domain.Core.ValueObjects;
    using FluentValidation;
    using ExampleCQRS.Domain.Validations.ValueObjects;

    public class BirthDate : ValueObject<BirthDate>
    {
        private BirthDate() { }

        public BirthDate(DateTime birthDate) => 
            this.DateOfBirth = birthDate;

        public DateTime DateOfBirth { get; private set; }

        public override IValidator<BirthDate> GetValidator() =>
            new BirthDateValidation();

        public override IEnumerable<object> GetValues() 
        {
            yield return this.DateOfBirth;
        }

        public static implicit operator DateTime(BirthDate birthDate) =>
            birthDate.DateOfBirth;
    }
}