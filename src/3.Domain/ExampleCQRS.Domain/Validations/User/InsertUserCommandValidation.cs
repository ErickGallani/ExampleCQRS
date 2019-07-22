namespace ExampleCQRS.Domain.Validations.User
{
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using ExampleCQRS.CrossCutting.ErrorMappings;
    using ExampleCQRS.CrossCutting.Extensions;
    using ExampleCQRS.Domain.Commands.User;
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
                .NotEmpty()
                    .WithErrorCode(Errors.NameErrorCode.EmptyOrNullName.GetString())
                    .WithMessage(ErrorMapping.NameMap[Errors.NameErrorCode.EmptyOrNullName])
                .SetValidator(insertUser => insertUser.Name.GetValidator());
                
        private void AddEmailValidation() =>
            RuleFor(insertUser => insertUser.Email)
                .NotNull()
                .NotEmpty()
                    .WithErrorCode(Errors.EmailErrorCode.EmptyOrNullEmail.GetString())
                    .WithMessage(ErrorMapping.EmailMap[Errors.EmailErrorCode.EmptyOrNullEmail])
                .SetValidator(insertUser => insertUser.Email.GetValidator());

        private void AddBirthDateValidation() =>
            RuleFor(insertUser => insertUser.BirthDate)
                .NotNull()
                    .WithErrorCode(Errors.BirthDateErrorCode.EmptyOrNullBirthDate.GetString())
                    .WithMessage(ErrorMapping.BirthDateMap[Errors.EmailErrorCode.EmptyOrNullEmail])
                .SetValidator(insertUser => insertUser.BirthDate.GetValidator());
    }
}