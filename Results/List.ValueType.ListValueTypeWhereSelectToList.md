## List.ValueType.ListValueTypeWhereSelectToList

### Source
[ListValueTypeWhereSelectToList.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelectToList.cs)

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
|                   Method | Count |      Mean |    Error |    StdDev |    Median |         Ratio | RatioSD | Allocated |
|------------------------- |------ |----------:|---------:|----------:|----------:|--------------:|--------:|----------:|
|                  ForLoop |   100 |  11.50 μs | 0.730 μs |  2.095 μs |  10.80 μs |      baseline |         |      8 KB |
|              ForeachLoop |   100 |  11.22 μs | 0.758 μs |  2.161 μs |  10.65 μs |  1.00x slower |   0.24x |      8 KB |
|                     Linq |   100 |  18.73 μs | 1.156 μs |  3.242 μs |  18.70 μs |  1.68x slower |   0.40x |      8 KB |
|               LinqFaster |   100 |  16.00 μs | 1.027 μs |  2.996 μs |  15.55 μs |  1.43x slower |   0.35x |     11 KB |
|             LinqFasterer |   100 |  22.74 μs | 1.758 μs |  5.044 μs |  21.05 μs |  2.03x slower |   0.54x |     17 KB |
|                   LinqAF |   100 |  22.54 μs | 1.926 μs |  5.558 μs |  21.15 μs |  2.02x slower |   0.61x |      8 KB |
|            LinqOptimizer |   100 |  78.10 μs | 3.803 μs | 10.788 μs |  76.70 μs |  7.03x slower |   1.52x |    136 KB |
|                  Streams |   100 | 118.43 μs | 3.427 μs |  9.264 μs | 116.20 μs | 10.50x slower |   1.76x |      9 KB |
|               StructLinq |   100 |  29.43 μs | 2.056 μs |  5.966 μs |  27.90 μs |  2.64x slower |   0.71x |     11 KB |
| StructLinq_ValueDelegate |   100 |  24.33 μs | 1.887 μs |  5.352 μs |  22.70 μs |  2.18x slower |   0.60x |     11 KB |
|                Hyperlinq |   100 |  25.15 μs | 2.133 μs |  6.189 μs |  22.70 μs |  2.24x slower |   0.59x |      7 KB |
|  Hyperlinq_ValueDelegate |   100 |  23.56 μs | 2.009 μs |  5.830 μs |  21.70 μs |  2.10x slower |   0.62x |      7 KB |
|                  Faslinq |   100 |  11.29 μs | 0.660 μs |  1.915 μs |  10.75 μs |  1.01x slower |   0.26x |      8 KB |
