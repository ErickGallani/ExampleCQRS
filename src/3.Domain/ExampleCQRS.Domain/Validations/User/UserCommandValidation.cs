namespace ExampleCQRS.Domain.Validations.User
{
    using System;
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using ExampleCQRS.CrossCutting.Extensions;
    using ExampleCQRS.Domain.Commands.User;
    using FluentValidation;

    public abstract class UserCommandValidation<TUserCommand> : AbstractValidator<TUserCommand> 
        where TUserCommand : UserCommand
    {
        protected void AddValidateUserId() =>
            RuleFor(user => user.Id)
                .NotEqual(default(Guid))
                .WithErrorCode(Errors.UserErrorCode.InvalidUserId.GetString());
    }
}