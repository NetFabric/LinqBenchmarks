## List.ValueType.ListValueTypeSkipTakeSelect

### Source
[ListValueTypeSkipTakeSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSkipTakeSelect.cs)

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
|                   Method | Skip | Count |       Mean |     Error |    StdDev |     Median |         Ratio | RatioSD | Allocated |
|------------------------- |----- |------ |-----------:|----------:|----------:|-----------:|--------------:|--------:|----------:|
|                  ForLoop | 1000 |   100 |   6.607 μs | 0.3682 μs |  1.068 μs |   6.150 μs |      baseline |         |      96 B |
|                     Linq | 1000 |   100 |  16.061 μs | 1.5351 μs |  4.071 μs |  15.200 μs |  2.48x slower |   0.76x |     464 B |
|               LinqFaster | 1000 |   100 |  16.441 μs | 0.8625 μs |  2.502 μs |  16.050 μs |  2.54x slower |   0.52x |  19,464 B |
|             LinqFasterer | 1000 |   100 |  33.031 μs | 2.8269 μs |  8.246 μs |  30.400 μs |  5.10x slower |   1.42x |  83,400 B |
|                   LinqAF | 1000 |   100 |  41.971 μs | 2.6690 μs |  7.261 μs |  38.700 μs |  6.50x slower |   1.53x |      96 B |
|            LinqOptimizer | 1000 |   100 |  75.473 μs | 4.8848 μs | 13.857 μs |  72.650 μs | 11.69x slower |   2.75x | 138,424 B |
|                  Streams | 1000 |   100 | 186.526 μs | 3.9445 μs | 10.864 μs | 183.750 μs | 28.90x slower |   4.48x |   1,272 B |
|               StructLinq | 1000 |   100 |  18.110 μs | 1.4916 μs |  4.231 μs |  17.200 μs |  2.81x slower |   0.78x |     168 B |
| StructLinq_ValueDelegate | 1000 |   100 |  12.031 μs | 1.6506 μs |  4.736 μs |   9.950 μs |  1.85x slower |   0.73x |      48 B |
|                Hyperlinq | 1000 |   100 |  10.993 μs | 1.0533 μs |  2.988 μs |   9.850 μs |  1.70x slower |   0.50x |      96 B |
|  Hyperlinq_ValueDelegate | 1000 |   100 |   8.865 μs | 0.4055 μs |  1.137 μs |   8.450 μs |  1.38x slower |   0.29x |      96 B |
