namespace ExampleCQRS.Application.Adapters
{
    using ExampleCQRS.Application.Dtos;
    using ExampleCQRS.CrossCutting.Adapters;
    using ExampleCQRS.Domain.Entities;

    public class UserAdapter : IAdapter<UserDto, User>
    {
        public User Adapt(UserDto source)
        {
            throw new System.NotImplementedException();
        }
    }
}
