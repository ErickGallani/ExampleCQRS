namespace ExampleCQRS.Application.Queries.User
{
    using System;
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Dtos;
    using ExampleCQRS.Application.Validators;
    using FluentValidation.Results;

    public class GetUserQuery: Query<UserDto>
    {
        public Guid Id { get; set; }

        public override Task<ValidationResult> IsValidAsync() =>
             new GetUserQueryValidation().ValidateAsync(this);
    }
}