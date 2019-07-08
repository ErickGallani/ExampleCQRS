namespace ExampleCQRS.Domain.Core.Interfaces
{
    using MediatR;

    public interface ICommand : 
        IRequest<bool>
    {
    }
}
