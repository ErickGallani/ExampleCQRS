namespace ExampleCQRS.Domain.Validations.User
{
    using ExampleCQRS.Domain.Commands.User;
    using ExampleCQRS.Domain.ValueObjects;
    using FluentValidation;

    public class InsertUserCommandValidation : UserCommandValidation<InsertUserCommand>
    {
        public InsertUserCommandValidation() 
        {
            AddValidateUserId();
            AddNameValidation();
            AddEmailValidation();
            AddBirthDateValidation();
        }

        private void AddNameValidation() =>     
            RuleFor(insertUser => insertUser.Name)
                .NotNull()
                .SetValidator(insertUser => insertUser.Name.GetValidator());
                
        private void AddEmailValidation() =>
            RuleFor(insertUser => insertUser.Email)
                .NotNull()
                .SetValidator(insertUser => insertUser.Email.GetValidator());

        private void AddBirthDateValidation() =>
            RuleFor(insertUser => insertUser.BirthDate)
                .NotNull()
                .SetValidator(insertUser => insertUser.BirthDate.GetValidator());
    }
}