namespace ExampleCQRS.Domain.Commands.User
{
    using System;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Validations.User;
    using ExampleCQRS.Domain.ValueObjects;
    using FluentValidation.Results;

    public class InsertUserCommand : UserCommand
    {
        public InsertUserCommand(Name name, Email email, BirthDate birthDate)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public Name Name { get; private set; }

        public Email Email { get; private set; }

        public BirthDate BirthDate { get; private set; }

        public async override Task<ValidationResult> IsValidAsync() =>
            await new InsertUserCommandValidation().ValidateAsync(this);
    }
}
