namespace ExampleCQRS.Application.Bus
{
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Interfaces;

    public interface IQueryFetcher
    {
         Task<TResult> FetchQuery<TQuery, TResult>(TQuery query)
            where TQuery : IQuery<TResult>
            where TResult : class;
    }
}