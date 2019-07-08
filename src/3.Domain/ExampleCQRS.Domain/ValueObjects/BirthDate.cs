namespace ExampleCQRS.Domain.ValueObjects
{
    using System.Collections.Generic;
    using System;
    using ExampleCQRS.Domain.Core.ValueObjects;

    public class BirthDate : ValueObject
    {
        private readonly DateTime DateOfBirth;

        public BirthDate(DateTime birthDate) => 
            this.DateOfBirth = birthDate;

        public override IEnumerable<object> GetValues() 
        {
            yield return this.DateOfBirth;
        }
    }
}