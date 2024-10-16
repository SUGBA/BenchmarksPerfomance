using BenchmarkDotNet.Attributes;
using BenchmarksPerfomance.Operations.Abstract;

namespace BenchmarksPerfomance.Operations;

/// <summary>
/// Замеры для операции удаления элемента в коллекцию
/// </summary>
public class RemoveBenchmark : AbstractOperationBenchmark
{
    [Benchmark(Description = "HashSet")]
    public void RemoveHashSetBenchmark()
    {
        HashSetColletion.Remove(ExistItem);
    }

    [Benchmark(Description = "Dictionary")]
    public void RemoveDictionaryCollectionBenchmark()
    {
        DictionaryColletion.Remove(ExistItem);
    }

    [Benchmark(Description = "List")]
    public void RemoveListCollectionBenchmark()
    {
        ListCollection.Remove(ExistItem);
    }

    [Benchmark(Description = "LinkedList")]
    public void RemoveLinkedListCollectionBenchmark()
    {
        LinkedListCollection.Remove(ExistItem);
    }
}
