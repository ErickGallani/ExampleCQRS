namespace ExampleCQRS.Application.Queries
{
    using System.Threading;
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Interfaces;
    using ExampleCQRS.Domain.Core.Bus;
    using FluentValidation.Results;

    public abstract class QueryHandler<TQuery, TResult> : IQueryHandler<TQuery, TResult>
        where TQuery : Query<TResult>
        where TResult : class
    {
        protected readonly IEventPublisher eventPublisher;

        public QueryHandler(IEventPublisher eventPublisher) => 
            this.eventPublisher = eventPublisher;

        public delegate Task<bool> OnSuccessAsync(TQuery query);

        public delegate Task<bool> OnInvalidAsync(ValidationResult validationResult);

        protected async Task<bool> ExecuteHandlerAsync(
            TQuery query, 
            OnSuccessAsync onSuccessAsync, 
            OnInvalidAsync onInvalidAsync)
        {
            var validationResult = await query.IsValidAsync();

            if(!validationResult.IsValid)
                return await onInvalidAsync(validationResult);

            return await onSuccessAsync(query);
        }

        public abstract Task<TResult> Handle(TQuery request, CancellationToken cancellationToken);
    }
}