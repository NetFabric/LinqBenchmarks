## List.ValueType.ListValueTypeWhereSelect

### Source
[ListValueTypeWhereSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelect.cs)

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
|                   Method | Count |      Mean |     Error |     StdDev |    Median |         Ratio | RatioSD | Allocated |
|------------------------- |------ |----------:|----------:|-----------:|----------:|--------------:|--------:|----------:|
|                  ForLoop |   100 |  5.682 μs | 0.1917 μs |  0.5375 μs |  5.550 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  7.002 μs | 0.3850 μs |  1.1170 μs |  6.600 μs |  1.23x slower |   0.22x |         - |
|                     Linq |   100 | 18.495 μs | 1.8052 μs |  5.2944 μs | 15.850 μs |  3.29x slower |   1.00x |     376 B |
|               LinqFaster |   100 | 12.362 μs | 0.7355 μs |  2.1338 μs | 11.950 μs |  2.20x slower |   0.48x |   8,136 B |
|             LinqFasterer |   100 | 16.214 μs | 0.9126 μs |  2.6331 μs | 15.450 μs |  2.86x slower |   0.52x |  13,512 B |
|                   LinqAF |   100 | 14.849 μs | 1.0231 μs |  2.6954 μs | 13.900 μs |  2.63x slower |   0.51x |      48 B |
|            LinqOptimizer |   100 | 61.878 μs | 4.1181 μs | 12.0776 μs | 58.000 μs | 11.02x slower |   2.25x | 135,576 B |
|                  Streams |   100 | 81.410 μs | 1.8909 μs |  5.0797 μs | 80.550 μs | 14.45x slower |   1.55x |   1,096 B |
|               StructLinq |   100 | 17.018 μs | 1.8964 μs |  5.3798 μs | 15.100 μs |  3.02x slower |   0.93x |     264 B |
| StructLinq_ValueDelegate |   100 |  8.733 μs | 0.6257 μs |  1.6592 μs |  8.200 μs |  1.55x slower |   0.34x |      96 B |
|                Hyperlinq |   100 | 12.045 μs | 1.8898 μs |  5.3610 μs |  9.400 μs |  2.16x slower |   0.98x |      96 B |
|  Hyperlinq_ValueDelegate |   100 |  9.303 μs | 0.9186 μs |  2.4037 μs |  8.500 μs |  1.65x slower |   0.48x |      96 B |
|                  Faslinq |   100 | 15.089 μs | 1.3270 μs |  3.8075 μs | 13.500 μs |  2.68x slower |   0.73x |   8,184 B |
