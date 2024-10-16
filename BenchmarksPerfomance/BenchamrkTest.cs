using BenchmarkDotNet.Running;
using BenchmarksPerfomance.Operations;

namespace BenchmarksPerfomance;

[TestFixture]
public class BenchamrkTest
{
    [Test]
    public void test_add()
    {
        BenchmarkRunner.Run<AddItemBenchmark>();
    }

    [Test]
    public void test_remove()
    {
        BenchmarkRunner.Run<RemoveBenchmark>();
    }

    [Test]
    public void test_find()
    {
        BenchmarkRunner.Run<FindBenchmark>();
    }
}
