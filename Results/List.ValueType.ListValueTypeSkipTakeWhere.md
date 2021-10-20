## List.ValueType.ListValueTypeSkipTakeWhere

### Source
[ListValueTypeSkipTakeWhere.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSkipTakeWhere.cs)

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
|                   Method | Skip | Count |       Mean |     Error |     StdDev |     Median |         Ratio | RatioSD | Allocated |
|------------------------- |----- |------ |-----------:|----------:|-----------:|-----------:|--------------:|--------:|----------:|
|                  ForLoop | 1000 |   100 |   4.594 μs | 0.2362 μs |  0.6387 μs |   4.400 μs |      baseline |         |         - |
|                     Linq | 1000 |   100 |  16.195 μs | 1.6026 μs |  4.5463 μs |  14.400 μs |  3.63x slower |   1.07x |     320 B |
|               LinqFaster | 1000 |   100 |  17.466 μs | 1.2344 μs |  3.5219 μs |  16.350 μs |  3.89x slower |   0.92x |  21,144 B |
|             LinqFasterer | 1000 |   100 |  27.405 μs | 1.7533 μs |  4.9163 μs |  26.400 μs |  6.08x slower |   1.22x |  80,264 B |
|                   LinqAF | 1000 |   100 |  40.475 μs | 2.6806 μs |  7.7769 μs |  36.650 μs |  9.00x slower |   2.07x |      48 B |
|            LinqOptimizer | 1000 |   100 |  64.679 μs | 2.9332 μs |  8.1765 μs |  62.150 μs | 14.27x slower |   2.53x | 135,288 B |
|                  Streams | 1000 |   100 | 149.195 μs | 3.8492 μs | 10.6018 μs | 145.400 μs | 33.05x slower |   4.70x |   1,272 B |
|               StructLinq | 1000 |   100 |  16.826 μs | 1.7341 μs |  4.9192 μs |  15.000 μs |  3.76x slower |   1.25x |     216 B |
| StructLinq_ValueDelegate | 1000 |   100 |   7.552 μs | 0.8651 μs |  2.3091 μs |   7.000 μs |  1.67x slower |   0.54x |      48 B |
|                Hyperlinq | 1000 |   100 |   9.191 μs | 0.8457 μs |  2.1981 μs |   8.600 μs |  2.02x slower |   0.43x |      48 B |
|  Hyperlinq_ValueDelegate | 1000 |   100 |   7.625 μs | 0.6411 μs |  1.6663 μs |   7.300 μs |  1.69x slower |   0.41x |      48 B |
