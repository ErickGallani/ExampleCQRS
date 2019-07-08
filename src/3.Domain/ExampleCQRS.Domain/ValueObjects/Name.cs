namespace ExampleCQRS.Domain.ValueObjects
{    
    using System.Collections.Generic;
    using ExampleCQRS.Domain.Core.ValueObjects;

    public class Name : ValueObject
    {    
        private readonly string FirstName;
        
        private readonly string LastName;

        public Name(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override IEnumerable<object> GetValues() 
        {
            yield return this.FirstName;
            yield return this.LastName;    
        }
    }
}