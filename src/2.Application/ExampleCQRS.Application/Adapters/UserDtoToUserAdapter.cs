namespace ExampleCQRS.Application.Adapters
{
    using ExampleCQRS.Application.Dtos;
    using ExampleCQRS.CrossCutting.Adapters;
    using ExampleCQRS.Domain.Entities;
    using ExampleCQRS.Domain.ValueObjects;

    public class UserDtoToUserAdapter : IAdapter<UserDto, User>
    {
        public User Adapt(UserDto source)
        {
            if(source is null) 
            {
                return null;
            }

            var name = new Name(source.FirstName, source.LastName);
            var email = new Email(source.Email);
            var birthDate = new BirthDate(source.BirthDate);

            var user = new User(name, email, birthDate);

            return user;
        }
    }
}
