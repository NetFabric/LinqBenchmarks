## List.Int32.ListInt32Where

### Source
[ListInt32Where.cs](../LinqBenchmarks/List/Int32/ListInt32Where.cs)

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
|                  ForLoop |   100 |  2.629 μs | 0.1256 μs |  0.3500 μs |  2.550 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  4.005 μs | 0.2330 μs |  0.6760 μs |  3.800 μs |  1.53x slower |   0.30x |         - |
|                     Linq |   100 |  8.791 μs | 0.5958 μs |  1.6903 μs |  8.300 μs |  3.42x slower |   0.83x |      72 B |
|               LinqFaster |   100 |  9.423 μs | 0.6853 μs |  2.0100 μs |  8.700 μs |  3.63x slower |   0.90x |     648 B |
|             LinqFasterer |   100 |  9.541 μs | 0.6179 μs |  1.7630 μs |  8.800 μs |  3.68x slower |   0.83x |     696 B |
|                   LinqAF |   100 |  6.991 μs | 0.5089 μs |  1.3136 μs |  6.550 μs |  2.68x slower |   0.52x |         - |
|            LinqOptimizer |   100 | 46.326 μs | 3.5313 μs | 10.1885 μs | 43.950 μs | 18.17x slower |   4.54x |   9,208 B |
|                  Streams |   100 | 14.277 μs | 1.0939 μs |  3.1909 μs | 13.650 μs |  5.51x slower |   1.49x |     608 B |
|               StructLinq |   100 |  8.882 μs | 0.7228 μs |  2.0856 μs |  8.100 μs |  3.45x slower |   0.98x |      32 B |
| StructLinq_ValueDelegate |   100 |  4.147 μs | 0.2115 μs |  0.5999 μs |  4.000 μs |  1.61x slower |   0.33x |         - |
|                Hyperlinq |   100 |  4.521 μs | 0.2591 μs |  0.7223 μs |  4.400 μs |  1.74x slower |   0.34x |         - |
|  Hyperlinq_ValueDelegate |   100 |  4.269 μs | 0.2504 μs |  0.7103 μs |  4.100 μs |  1.65x slower |   0.35x |         - |
|                  Faslinq |   100 | 10.515 μs | 1.3711 μs |  4.0212 μs |  9.450 μs |  4.18x slower |   1.64x |     648 B |
