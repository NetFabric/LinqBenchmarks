## Array.Int32.ArrayInt32SkipTakeWhere

### Source
[ArrayInt32SkipTakeWhere.cs](../LinqBenchmarks/Array/Int32/ArrayInt32SkipTakeWhere.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqFaster.SIMD: [1.1.2](https://www.nuget.org/packages/LinqFaster.SIMD/1.0.3)
- LinqFasterer: [2.1.0](https://www.nuget.org/packages/LinqFasterer/2.1.0)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- LinqOptimizer.CSharp: [0.7.0](https://www.nuget.org/packages/LinqOptimizer.CSharp/0.7.0)
- SpanLinq: [0.0.1](https://www.nuget.org/packages/SpanLinq/0.0.1)
- Streams.CSharp: [0.6.0](https://www.nuget.org/packages/Streams.CSharp/0.6.0)
- StructLinq.BCL: [0.27.0](https://www.nuget.org/packages/StructLinq/0.27.0)
- NetFabric.Hyperlinq: [3.0.0-beta48](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta48)
- System.Linq.Async: [5.0.0](https://www.nuget.org/packages/System.Linq.Async/5.0.0)
- Faslinq: [1.0.5](https://www.nuget.org/packages/Faslinq/1.0.5)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.21390
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.100-rc.2.21505.57
  [Host] : .NET Core 3.1.20 (CoreCLR 4.700.21.47003, CoreFX 4.700.21.47101), X64 RyuJIT DEBUG  [AttachedDebugger]

Toolchain=InProcessEmitToolchain  InvocationCount=1  UnrollFactor=1  

```
|                   Method | Skip | Count |      Mean |     Error |    StdDev |    Median |         Ratio | RatioSD | Allocated |
|------------------------- |----- |------ |----------:|----------:|----------:|----------:|--------------:|--------:|----------:|
|                  ForLoop | 1000 |   100 |  3.712 μs | 0.5425 μs |  1.565 μs |  3.050 μs |      baseline |         |         - |
|                     Linq | 1000 |   100 | 12.085 μs | 0.8076 μs |  2.085 μs | 11.500 μs |  3.71x slower |   1.53x |     152 B |
|               LinqFaster | 1000 |   100 | 10.403 μs | 1.5641 μs |  4.437 μs |  8.400 μs |  3.29x slower |   1.91x |   1,504 B |
|             LinqFasterer | 1000 |   100 | 12.481 μs | 1.4669 μs |  4.089 μs | 10.950 μs |  3.87x slower |   2.01x |     688 B |
|                   LinqAF | 1000 |   100 | 13.487 μs | 0.8244 μs |  2.128 μs | 12.900 μs |  4.12x slower |   1.68x |         - |
|            LinqOptimizer | 1000 |   100 | 53.038 μs | 5.3647 μs | 15.564 μs | 48.200 μs | 16.84x slower |   8.14x |   9,200 B |
|                 SpanLinq | 1000 |   100 |  7.658 μs | 0.5269 μs |  1.388 μs |  7.200 μs |  2.33x slower |   0.92x |         - |
|                  Streams | 1000 |   100 | 38.853 μs | 9.2330 μs | 26.933 μs | 22.450 μs | 12.98x slower |  11.17x |     912 B |
|               StructLinq | 1000 |   100 | 12.182 μs | 1.1335 μs |  2.946 μs | 11.500 μs |  3.73x slower |   1.70x |      96 B |
| StructLinq_ValueDelegate | 1000 |   100 |  5.012 μs | 0.4381 μs |  1.123 μs |  4.700 μs |  1.50x slower |   0.60x |         - |
|                Hyperlinq | 1000 |   100 |  5.803 μs | 0.5616 μs |  1.460 μs |  5.400 μs |  1.77x slower |   0.77x |         - |
|  Hyperlinq_ValueDelegate | 1000 |   100 |  5.762 μs | 0.7510 μs |  1.952 μs |  5.200 μs |  1.75x slower |   0.95x |         - |
