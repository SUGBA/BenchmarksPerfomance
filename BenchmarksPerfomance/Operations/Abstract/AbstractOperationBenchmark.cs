using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;

namespace BenchmarksPerfomance.Operations.Abstract;

/// <summary>
/// Инициализация и конфигурация бенчмарков
/// </summary>
public abstract class AbstractOperationBenchmark
{
    #region Fields

    protected const long NewItem = default;

    protected const long ExistItem = 50000;

    protected HashSet<long> HashSetColletion { get; set; }

    protected Dictionary<long, long> DictionaryColletion { get; set; }

    protected List<long> ListCollection { get; set; }

    protected LinkedList<long> LinkedListCollection { get; set; }

    protected ReadOnlyDictionary<long, long> ReadOnlyDictionaryColletion { get; set; }

    #endregion

    #region MemoryHelpers

    [IterationSetup]
    public void Setup()
    {
        HashSetColletion = Enumerable.Range(1, 100000).Select(x => (long)x).ToHashSet();
        DictionaryColletion = Enumerable.Range(1, 100000).Select(x => (long)x).ToDictionary(k => k);
        ListCollection = Enumerable.Range(1, 100000).Select(x => (long)x).ToList();
        LinkedListCollection = new LinkedList<long>(Enumerable.Range(1, 100000).Select(x => (long)x));
        ReadOnlyDictionaryColletion = new ReadOnlyDictionary<long, long>(Enumerable.Range(1, 100000).Select(x => (long)x).ToDictionary(k => k));
    }

    [IterationCleanup]
    public void Cleanup()
    {
        HashSetColletion.Clear();
        DictionaryColletion.Clear();
        ListCollection.Clear();
        LinkedListCollection.Clear();
        ReadOnlyDictionaryColletion = new ReadOnlyDictionary<long, long>(new Dictionary<long, long>());
    }

    #endregion
}
