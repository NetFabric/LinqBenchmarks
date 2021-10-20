## List.ValueType.ListValueTypeWhereSelectToArray

### Source
[ListValueTypeWhereSelectToArray.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelectToArray.cs)

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
|                   Method | Count |     Mean |    Error |    StdDev |   Median |        Ratio | RatioSD | Allocated |
|------------------------- |------ |---------:|---------:|----------:|---------:|-------------:|--------:|----------:|
|                  ForLoop |   100 | 13.78 μs | 1.327 μs |  3.808 μs | 12.40 μs |     baseline |         |     11 KB |
|              ForeachLoop |   100 | 14.15 μs | 0.902 μs |  2.632 μs | 13.95 μs | 1.10x slower |   0.35x |     11 KB |
|                     Linq |   100 | 23.41 μs | 2.276 μs |  6.567 μs | 21.35 μs | 1.79x slower |   0.61x |      8 KB |
|               LinqFaster |   100 | 15.25 μs | 1.186 μs |  3.384 μs | 14.75 μs | 1.19x slower |   0.42x |     11 KB |
|             LinqFasterer |   100 | 14.93 μs | 1.094 μs |  3.192 μs | 14.10 μs | 1.16x slower |   0.39x |     13 KB |
|                   LinqAF |   100 | 26.27 μs | 2.227 μs |  6.390 μs | 24.00 μs | 1.98x slower |   0.48x |     11 KB |
|            LinqOptimizer |   100 | 79.99 μs | 4.877 μs | 14.072 μs | 76.70 μs | 6.23x slower |   1.93x |    132 KB |
|                  Streams |   100 | 93.46 μs | 4.334 μs | 12.294 μs | 90.25 μs | 7.22x slower |   2.04x |     12 KB |
|               StructLinq |   100 | 28.99 μs | 2.159 μs |  6.018 μs | 27.75 μs | 2.22x slower |   0.62x |     11 KB |
| StructLinq_ValueDelegate |   100 | 22.65 μs | 1.845 μs |  5.351 μs | 21.40 μs | 1.73x slower |   0.53x |     11 KB |
|                Hyperlinq |   100 | 23.57 μs | 1.936 μs |  5.365 μs | 21.85 μs | 1.79x slower |   0.46x |      7 KB |
|  Hyperlinq_ValueDelegate |   100 | 24.24 μs | 1.949 μs |  5.561 μs | 22.55 μs | 1.84x slower |   0.50x |      7 KB |
|                  Faslinq |   100 | 16.19 μs | 1.155 μs |  3.352 μs | 15.15 μs | 1.26x slower |   0.41x |     11 KB |
