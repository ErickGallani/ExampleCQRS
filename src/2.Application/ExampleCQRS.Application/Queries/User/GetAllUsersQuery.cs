namespace ExampleCQRS.Application.Queries.User
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Dtos;
    using FluentValidation.Results;

    public class GetAllUsersQuery : Query<IEnumerable<UserDto>>
    {
        public override Task<ValidationResult> IsValidAsync() =>
            Task.FromResult(new ValidationResult());
    }
}