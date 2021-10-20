## Array.ValueType.ArrayValueTypeWhereSelectToList

### Source
[ArrayValueTypeWhereSelectToList.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelectToList.cs)

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
|                   Method | Count |       Mean |     Error |     StdDev |     Median |         Ratio | RatioSD | Allocated |
|------------------------- |------ |-----------:|----------:|-----------:|-----------:|--------------:|--------:|----------:|
|                  ForLoop |   100 |   8.948 μs | 0.3502 μs |  0.9763 μs |   8.550 μs |      baseline |         |      8 KB |
|              ForeachLoop |   100 |   9.211 μs | 0.4014 μs |  1.1256 μs |   9.000 μs |  1.04x slower |   0.17x |      8 KB |
|                     Linq |   100 |  20.280 μs | 1.6129 μs |  4.6794 μs |  18.800 μs |  2.35x slower |   0.57x |      8 KB |
|               LinqFaster |   100 |  15.561 μs | 0.8661 μs |  2.4430 μs |  15.400 μs |  1.76x slower |   0.33x |     13 KB |
|             LinqFasterer |   100 |  22.895 μs | 1.7888 μs |  5.1896 μs |  21.100 μs |  2.60x slower |   0.67x |     18 KB |
|                   LinqAF |   100 |  16.701 μs | 1.1040 μs |  2.9847 μs |  15.700 μs |  1.89x slower |   0.42x |      8 KB |
|            LinqOptimizer |   100 |  73.348 μs | 3.8628 μs | 10.7680 μs |  71.900 μs |  8.29x slower |   1.46x |    136 KB |
|                 SpanLinq |   100 |  18.069 μs | 0.4697 μs |  1.3016 μs |  17.700 μs |  2.04x slower |   0.26x |      8 KB |
|                  Streams |   100 | 109.869 μs | 2.1893 μs |  5.7289 μs | 108.600 μs | 12.34x slower |   1.38x |      8 KB |
|               StructLinq |   100 |  21.608 μs | 1.7929 μs |  5.2016 μs |  20.000 μs |  2.47x slower |   0.62x |      4 KB |
| StructLinq_ValueDelegate |   100 |  17.493 μs | 1.4702 μs |  4.2183 μs |  16.000 μs |  1.98x slower |   0.56x |      3 KB |
|                Hyperlinq |   100 |  19.345 μs | 1.4403 μs |  3.9911 μs |  18.100 μs |  2.19x slower |   0.50x |      3 KB |
|  Hyperlinq_ValueDelegate |   100 |  19.471 μs | 1.5828 μs |  4.5920 μs |  17.200 μs |  2.19x slower |   0.54x |      3 KB |
