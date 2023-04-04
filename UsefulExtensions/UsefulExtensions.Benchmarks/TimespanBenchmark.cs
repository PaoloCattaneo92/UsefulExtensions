using BenchmarkDotNet.Attributes;
using PaoloCattaneo.UsefulExtensions;

namespace UsefulExtensions.Benchmarks;

[MemoryDiagnoser]
public class TimespanBenchmark
{
    [Params(133056000, 55552896, 3180000, 24430, 123)]
    public int DATA;


    [GlobalSetup]
    public void Setup()
    {
    }

    [Benchmark]
    public void ToHumanReadable_StringBuilder() => TimeSpan.FromMilliseconds(DATA).ToHumanReadable_StringBuilder();

    [Benchmark]
    public void ToHumanReadable_Concatenate() => TimeSpan.FromMilliseconds(DATA).ToHumanReadable_Concatenate();
}
