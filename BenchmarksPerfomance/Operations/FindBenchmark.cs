using BenchmarkDotNet.Attributes;
using BenchmarksPerfomance.Operations.Abstract;

namespace BenchmarksPerfomance.Operations;

/// <summary>
/// Замеры для операций поиска элемента в коллекцию
/// </summary>
public class FindBenchmark : AbstractOperationBenchmark
{
    [Benchmark(Description = "HashSet")]
    public void FindHashSetBenchmark()
    {
        HashSetColletion.FirstOrDefault(ExistItem);
    }

    [Benchmark(Description = "Dictionary")]
    public void FindDictionaryCollectionBenchmark()
    {
        DictionaryColletion.GetValueOrDefault(ExistItem);
    }

    [Benchmark(Description = "List")]
    public void FindListCollectionBenchmark()
    {
        ListCollection.FirstOrDefault(ExistItem);
    }

    [Benchmark(Description = "LinkedList")]
    public void FindLinkedListCollectionBenchmark()
    {
        LinkedListCollection.FirstOrDefault(ExistItem);
    }

    [Benchmark(Description = "ReadOnlyDictionary")]
    public void FindReadOnlyDictionaryCollectionBenchmark()
    {
        ReadOnlyDictionaryColletion.GetValueOrDefault(NewItem);
    }
}