namespace ExampleCQRS.Domain.ValueObjects
{
    using System.Collections.Generic;
    using ExampleCQRS.Domain.Core.ValueObjects;
    using ExampleCQRS.Domain.Validations.ValueObjects;
    using FluentValidation;

    public class Name : ValueObject<Name>
    {
        private Name() { }

        public Name(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; private set; }
        
        public string LastName { get; private set; }

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