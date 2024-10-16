using BenchmarkDotNet.Attributes;
using ComparingDataTypesPerformance.Abstract;

namespace ComparingDataTypesPerformance.DataTypes;

/// <summary>
/// Тесты производительности для хэшсета с лонгами
/// </summary>
public class LongHashSetCompare : AbstractComparer<HashSet<long>, long>
{
    private HashSet<long> Collection { get; }

    private long Item { get; }

    public LongHashSetCompare()
    {
        var random = new Random();
        Collection = Enumerable.Range(1, int.MaxValue)
            .Select(x => (long)random.Next(int.MinValue, int.MaxValue))
            .ToHashSet();

        Item = random.Next(int.MinValue, int.MaxValue);
    }

    ///<inheritdoc/>
    [Benchmark]
    public override void Add()
    {
        Collection.Add(Item);
    }
}
