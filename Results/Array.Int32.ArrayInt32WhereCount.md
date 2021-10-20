## Array.Int32.ArrayInt32WhereCount

### Source
[ArrayInt32WhereCount.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereCount.cs)

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
|                  ForLoop |   100 |  2.201 μs | 0.1114 μs | 0.3178 μs |  2.100 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  2.172 μs | 0.1032 μs | 0.2860 μs |  2.100 μs |  1.00x slower |   0.17x |         - |
|                     Linq |   100 |  6.244 μs | 0.3017 μs | 0.8560 μs |  6.000 μs |  2.89x slower |   0.54x |      32 B |
|               LinqFaster |   100 |  2.378 μs | 0.1013 μs | 0.2857 μs |  2.350 μs |  1.10x slower |   0.19x |         - |
|             LinqFasterer |   100 |  3.472 μs | 0.1290 μs | 0.3638 μs |  3.400 μs |  1.61x slower |   0.27x |         - |
|                   LinqAF |   100 |  4.597 μs | 0.3216 μs | 0.8303 μs |  4.400 μs |  2.14x slower |   0.50x |         - |
|            LinqOptimizer |   100 | 38.706 μs | 2.5051 μs | 7.1471 μs | 37.200 μs | 17.92x slower |   4.08x |     512 B |
|                 SpanLinq |   100 |  5.551 μs | 0.2277 μs | 0.6460 μs |  5.500 μs |  2.57x slower |   0.45x |         - |
|                  Streams |   100 | 17.514 μs | 2.6454 μs | 7.7168 μs | 14.100 μs |  8.02x slower |   3.61x |     360 B |
|               StructLinq |   100 | 12.008 μs | 1.5213 μs | 4.3649 μs | 10.300 μs |  5.49x slower |   1.99x |      64 B |
| StructLinq_ValueDelegate |   100 |  3.942 μs | 0.3539 μs | 0.9136 μs |  3.700 μs |  1.84x slower |   0.53x |         - |
|                Hyperlinq |   100 |  4.351 μs | 0.8204 μs | 2.3004 μs |  3.400 μs |  1.99x slower |   1.06x |         - |
|  Hyperlinq_ValueDelegate |   100 |  2.995 μs | 0.2959 μs | 0.7794 μs |  2.700 μs |  1.40x slower |   0.45x |         - |
