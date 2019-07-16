namespace ExampleCQRS.Application.Queries
{
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Interfaces;
    using FluentValidation.Results;

    public abstract class Query<TResult> : IQuery<TResult>
        where TResult : class
    {
        public abstract Task<ValidationResult> IsValidAsync();
    }
}