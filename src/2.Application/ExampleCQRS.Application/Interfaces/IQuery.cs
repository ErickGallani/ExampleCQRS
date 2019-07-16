namespace ExampleCQRS.Application.Interfaces
{
    using MediatR;
    
    public interface IQuery<out TResult> : IRequest<TResult>
        where TResult : class
    {
         
    }
}