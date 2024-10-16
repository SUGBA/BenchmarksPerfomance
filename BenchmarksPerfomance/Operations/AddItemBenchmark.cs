using BenchmarkDotNet.Attributes;
using BenchmarksPerfomance.Operations.Abstract;

namespace BenchmarksPerfomance.Operations;

/// <summary>
/// Замеры для операции добавления элемента в коллекцию
/// </summary>
public class AddItemBenchmark : AbstractOperationBenchmark
{
    [Benchmark(Description = "HashSet")]
    public void AddHashSetBenchmark()
    {
        HashSetColletion.Add(NewItem);
    }

    [Benchmark(Description = "Dictionary")]
    public void AddDictionaryCollectionBenchmark()
    {
        DictionaryColletion.Add(NewItem, NewItem);
    }

    [Benchmark(Description = "List")]
    public void AddListCollectionBenchmark()
    {
        ListCollection.Add(NewItem);
    }

    [Benchmark(Description = "LinkedList")]
    public void AddLinkedListCollectionBenchmark()
    {
        LinkedListCollection.AddLast(NewItem);
    }
}
