namespace ExampleCQRS.CrossCutting.Adapters
{
    public interface IAdapter<in TSource, out TDestination>
        where TSource : class
        where TDestination : class
    {
        TDestination Adapt(TSource source);
    }
}
