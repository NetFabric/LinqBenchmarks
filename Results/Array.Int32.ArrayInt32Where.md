## Array.Int32.ArrayInt32Where

### Source
[ArrayInt32Where.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Where.cs)

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
|                  ForLoop |   100 |  2.318 μs | 0.1453 μs | 0.4169 μs |  2.300 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  2.424 μs | 0.1446 μs | 0.4195 μs |  2.400 μs |  1.08x slower |   0.27x |         - |
|                     Linq |   100 |  8.613 μs | 1.0527 μs | 3.0035 μs |  7.700 μs |  3.80x slower |   1.42x |     424 B |
|               LinqFaster |   100 |  7.923 μs | 0.4873 μs | 1.3745 μs |  7.450 μs |  3.52x slower |   0.88x |     664 B |
|             LinqFasterer |   100 |  9.633 μs | 0.7395 μs | 2.1218 μs |  8.850 μs |  4.28x slower |   1.20x |     448 B |
|                   LinqAF |   100 | 10.154 μs | 2.4846 μs | 7.2478 μs |  5.900 μs |  4.41x slower |   2.87x |         - |
|            LinqOptimizer |   100 | 42.544 μs | 2.6588 μs | 7.6286 μs | 40.800 μs | 18.90x slower |   4.52x |   9,168 B |
|                 SpanLinq |   100 |  5.747 μs | 0.2028 μs | 0.5753 μs |  5.650 μs |  2.54x slower |   0.48x |         - |
|                  Streams |   100 | 10.425 μs | 0.2595 μs | 0.7103 μs | 10.400 μs |  4.60x slower |   0.80x |     584 B |
|               StructLinq |   100 |  7.957 μs | 0.4654 μs | 1.3126 μs |  7.800 μs |  3.51x slower |   0.77x |      32 B |
| StructLinq_ValueDelegate |   100 |  4.308 μs | 0.1656 μs | 0.4616 μs |  4.250 μs |  1.91x slower |   0.38x |         - |
|                Hyperlinq |   100 |  4.350 μs | 0.1949 μs | 0.5400 μs |  4.250 μs |  1.92x slower |   0.36x |         - |
|  Hyperlinq_ValueDelegate |   100 |  3.757 μs | 0.1445 μs | 0.4005 μs |  3.700 μs |  1.66x slower |   0.31x |         - |
|                  Faslinq |   100 |  5.921 μs | 0.2913 μs | 0.8073 μs |  5.900 μs |  2.62x slower |   0.55x |     424 B |
