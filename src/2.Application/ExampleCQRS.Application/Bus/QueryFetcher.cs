namespace ExampleCQRS.Application.Bus
{
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Interfaces;
    using MediatR;

    public class QueryFetcher : IQueryFetcher
    {
        private readonly IMediator mediator;

        public QueryFetcher(IMediator mediator) => 
            this.mediator = mediator;

        public async Task<TResult> FetchQuery<TQuery, TResult>(TQuery query)
            where TQuery : IQuery<TResult>
            where TResult : class => 
            await this.mediator.Send(query);
    }
}