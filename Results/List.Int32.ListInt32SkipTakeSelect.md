## List.Int32.ListInt32SkipTakeSelect

### Source
[ListInt32SkipTakeSelect.cs](../LinqBenchmarks/List/Int32/ListInt32SkipTakeSelect.cs)

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
|                  ForLoop | 1000 |   100 |  2.162 μs | 0.1462 μs | 0.4124 μs |  2.050 μs |      baseline |         |         - |
|                     Linq | 1000 |   100 |  9.738 μs | 0.8100 μs | 2.1197 μs |  9.400 μs |  4.66x slower |   1.29x |     152 B |
|               LinqFaster | 1000 |   100 |  6.861 μs | 0.5169 μs | 1.4748 μs |  6.550 μs |  3.28x slower |   0.88x |   1,368 B |
|             LinqFasterer | 1000 |   100 | 11.622 μs | 1.5655 μs | 4.4155 μs |  9.750 μs |  5.62x slower |   2.47x |   5,304 B |
|                   LinqAF | 1000 |   100 | 17.051 μs | 1.1838 μs | 3.0977 μs | 15.650 μs |  8.19x slower |   2.24x |         - |
|            LinqOptimizer | 1000 |   100 | 44.715 μs | 2.4871 μs | 6.8916 μs | 43.600 μs | 21.41x slower |   5.56x |   9,392 B |
|                  Streams | 1000 |   100 | 21.149 μs | 1.9594 μs | 5.5904 μs | 19.100 μs | 10.15x slower |   3.09x |     936 B |
|               StructLinq | 1000 |   100 | 12.271 μs | 1.5021 μs | 4.3097 μs | 10.300 μs |  5.91x slower |   2.48x |      96 B |
| StructLinq_ValueDelegate | 1000 |   100 |  5.613 μs | 1.0201 μs | 2.9105 μs |  4.200 μs |  2.72x slower |   1.52x |         - |
|                Hyperlinq | 1000 |   100 |  4.177 μs | 0.3949 μs | 1.0263 μs |  3.900 μs |  2.01x slower |   0.58x |         - |
|  Hyperlinq_ValueDelegate | 1000 |   100 |  3.777 μs | 0.1937 μs | 0.5433 μs |  3.700 μs |  1.81x slower |   0.44x |         - |
