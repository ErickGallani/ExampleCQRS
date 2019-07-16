namespace ExampleCQRS.Application.Interfaces
{
    using MediatR;

    public interface IQueryHandler<TQuery, TResult> : IRequestHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
        where TResult : class
    {
         
    }
}