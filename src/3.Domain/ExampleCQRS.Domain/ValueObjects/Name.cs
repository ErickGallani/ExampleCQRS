namespace ExampleCQRS.Domain.ValueObjects
{
    using System.Collections.Generic;
    using ExampleCQRS.Domain.Core.ValueObjects;
    using ExampleCQRS.Domain.Validations.ValueObjects;
    using FluentValidation;

    public class Name : ValueObject<Name>
    {    
        private readonly string FirstName;
        
        private readonly string LastName;

        public Name(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string GetFirstName() =>
            this.FirstName;

        public string GetLastName() =>
            this.LastName;

        public override IValidator<Name> GetValidator() =>
            new NameValidation();

        public override IEnumerable<object> GetValues() 
        {
            yield return this.FirstName;
            yield return this.LastName;    
        }

        public static implicit operator string(Name name) =>
            $"{name.FirstName} {name.LastName}";
    }
}