using ExampleCQRS.Application.Dtos;
using ExampleCQRS.CrossCutting.Adapters;
using ExampleCQRS.Domain.Entities;

namespace ExampleCQRS.Application.Adapters
{
    public class UserToUserDtoAdapter: IAdapter<User, UserDto>
    {
        public UserDto Adapt(User source)
        {
            if(source is null) 
            {
                return null;
            }

            return new UserDto() 
            {
                Id = source.Id,
                FirstName = source.Name.FirstName,
                LastName = source.Name.LastName,
                Email = source.Email,
                BirthDate = source.BirthDate
            };
        }
    }
}