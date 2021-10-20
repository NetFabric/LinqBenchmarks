## Array.ValueType.ArrayValueTypeWhere

### Source
[ArrayValueTypeWhere.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhere.cs)

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
|                   Method | Count |      Mean |     Error |    StdDev |    Median |         Ratio | RatioSD | Allocated |
|------------------------- |------ |----------:|----------:|----------:|----------:|--------------:|--------:|----------:|
|                  ForLoop |   100 |  4.014 μs | 0.2016 μs | 0.5685 μs |  3.900 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  4.356 μs | 0.2342 μs | 0.6719 μs |  4.250 μs |  1.11x slower |   0.24x |      96 B |
|                     Linq |   100 | 10.080 μs | 0.4750 μs | 1.3398 μs |  9.800 μs |  2.56x slower |   0.51x |     104 B |
|               LinqFaster |   100 |  9.498 μs | 0.5201 μs | 1.4755 μs |  9.050 μs |  2.41x slower |   0.49x |   9,904 B |
|             LinqFasterer |   100 | 11.018 μs | 0.4976 μs | 1.4034 μs | 10.950 μs |  2.79x slower |   0.47x |   6,328 B |
|                   LinqAF |   100 | 10.932 μs | 1.7929 μs | 4.9978 μs |  8.450 μs |  2.79x slower |   1.44x |         - |
|            LinqOptimizer |   100 | 43.780 μs | 1.8447 μs | 5.0497 μs | 42.250 μs | 11.10x slower |   1.92x | 135,288 B |
|                 SpanLinq |   100 |  7.364 μs | 0.1749 μs | 0.4757 μs |  7.300 μs |  1.87x slower |   0.27x |         - |
|                  Streams |   100 | 42.710 μs | 1.2433 μs | 3.5872 μs | 41.750 μs | 10.79x slower |   1.54x |     824 B |
|               StructLinq |   100 |  9.487 μs | 0.4531 μs | 1.2780 μs |  9.100 μs |  2.41x slower |   0.48x |      32 B |
| StructLinq_ValueDelegate |   100 |  5.003 μs | 0.1993 μs | 0.5556 μs |  4.900 μs |  1.27x slower |   0.21x |         - |
|                Hyperlinq |   100 |  6.644 μs | 0.3812 μs | 1.0813 μs |  6.250 μs |  1.68x slower |   0.33x |         - |
|  Hyperlinq_ValueDelegate |   100 |  5.936 μs | 0.2177 μs | 0.6106 μs |  5.800 μs |  1.51x slower |   0.27x |         - |
|                  Faslinq |   100 | 10.811 μs | 1.2714 μs | 3.6684 μs |  9.350 μs |  2.77x slower |   1.10x |   6,424 B |
