using homework1.dataStructures;

namespace homework1.delegates_events;

public class DataPipeline<T>
{
    public List<Func<T, bool>> Filters { get; } = new();
    
    
    public IEnumerable<T> ProcessFilters(IEnumerable<T> input)
    {
        IEnumerable<T> result = input;
        
        foreach (var filter in Filters)
            result = result.Where(filter);

        return result;
    }

    public IEnumerable<V> ProcessTransform<V>(IEnumerable<T> input, Func<T, V> transform)
    {
        IEnumerable<V> result;
        
        result = input.Select(transform);
        return result;

    }
    

    
    
}
