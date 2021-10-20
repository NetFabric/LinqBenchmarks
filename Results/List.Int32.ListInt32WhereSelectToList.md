## List.Int32.ListInt32WhereSelectToList

### Source
[ListInt32WhereSelectToList.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelectToList.cs)

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
|                   Method | Count |      Mean |     Error |   StdDev |    Median |        Ratio | RatioSD | Allocated |
|------------------------- |------ |----------:|----------:|---------:|----------:|-------------:|--------:|----------:|
|                  ForLoop |   100 |  8.297 μs | 0.4660 μs | 1.344 μs |  8.200 μs |     baseline |         |     696 B |
|              ForeachLoop |   100 |  8.477 μs | 0.5618 μs | 1.648 μs |  8.200 μs | 1.05x slower |   0.27x |     696 B |
|                     Linq |   100 | 14.473 μs | 1.2516 μs | 3.651 μs | 13.250 μs | 1.77x slower |   0.51x |     896 B |
|               LinqFaster |   100 |  9.255 μs | 0.6744 μs | 1.924 μs |  8.700 μs | 1.15x slower |   0.30x |     920 B |
|             LinqFasterer |   100 | 11.988 μs | 0.8963 μs | 2.600 μs | 11.250 μs | 1.48x slower |   0.38x |   1,176 B |
|                   LinqAF |   100 | 17.218 μs | 1.3221 μs | 3.815 μs | 15.850 μs | 2.13x slower |   0.59x |     696 B |
|            LinqOptimizer |   100 | 48.704 μs | 3.4171 μs | 9.804 μs | 46.100 μs | 6.04x slower |   1.63x |   9,544 B |
|                  Streams |   100 | 23.839 μs | 2.1316 μs | 6.116 μs | 21.900 μs | 2.94x slower |   0.86x |   1,288 B |
|               StructLinq |   100 | 23.167 μs | 1.9973 μs | 5.763 μs | 21.900 μs | 2.84x slower |   0.76x |     984 B |
| StructLinq_ValueDelegate |   100 | 18.667 μs | 2.0186 μs | 5.792 μs | 16.300 μs | 2.31x slower |   0.80x |     840 B |
|                Hyperlinq |   100 | 20.702 μs | 1.8225 μs | 5.258 μs | 19.700 μs | 2.56x slower |   0.73x |     760 B |
|  Hyperlinq_ValueDelegate |   100 | 19.468 μs | 1.6907 μs | 4.878 μs | 19.750 μs | 2.40x slower |   0.68x |     760 B |
|                  Faslinq |   100 |  7.922 μs | 0.4683 μs | 1.321 μs |  7.700 μs | 1.08x faster |   0.24x |     648 B |
