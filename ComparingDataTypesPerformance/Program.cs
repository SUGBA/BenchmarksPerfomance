using BenchmarkDotNet.Running;
using ComparingDataTypesPerformance.DataTypes;

namespace ComparingDataTypesPerformance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<LongHashSetCompare>();
        }
    }
}
