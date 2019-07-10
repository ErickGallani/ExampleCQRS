namespace ExampleCQRS.Domain.Adapters
{
    using ExampleCQRS.CrossCutting.Adapters;
    using ExampleCQRS.Domain.Commands.User;
    using ExampleCQRS.Domain.Entities;

    public class InsertUserCommandToUserAdapter : IAdapter<InsertUserCommand, User>
    {
        public User Adapt(InsertUserCommand source)
        {
            if (source is null)
            {
                return null;
            }

            return new User(
                source.Id,
                source.Name, 
                source.Email, 
                source.BirthDate);
        }
    }
}