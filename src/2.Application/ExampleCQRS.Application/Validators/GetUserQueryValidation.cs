namespace ExampleCQRS.Application.Validators
{
    using System;
    using ExampleCQRS.Application.Queries.User;
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using ExampleCQRS.CrossCutting.Extensions;
    using FluentValidation;

    public class GetUserQueryValidation : AbstractValidator<GetUserQuery>
    {
        public GetUserQueryValidation()
        {
            AddValidateUserId();
        }

        protected void AddValidateUserId() =>
            RuleFor(user => user.Id)
                .NotEqual(default(Guid))
                .WithErrorCode(UserError.Code.InvalidUserId.GetString());
    }
}