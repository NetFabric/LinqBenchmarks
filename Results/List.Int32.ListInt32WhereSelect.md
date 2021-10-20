## List.Int32.ListInt32WhereSelect

### Source
[ListInt32WhereSelect.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelect.cs)

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
|                  ForLoop |   100 |  3.275 μs | 0.2518 μs | 0.7384 μs |  3.000 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  3.900 μs | 0.2020 μs | 0.5827 μs |  3.700 μs |  1.25x slower |   0.32x |         - |
|                     Linq |   100 |  9.765 μs | 0.4575 μs | 1.2829 μs |  9.600 μs |  3.15x slower |   0.79x |   1,296 B |
|               LinqFaster |   100 |  9.475 μs | 0.7773 μs | 2.2303 μs |  8.900 μs |  3.03x slower |   0.97x |     648 B |
|             LinqFasterer |   100 |  9.239 μs | 0.5813 μs | 1.6956 μs |  8.900 μs |  2.94x slower |   0.77x |     936 B |
|                   LinqAF |   100 |  8.830 μs | 0.7136 μs | 1.8546 μs |  8.150 μs |  2.79x slower |   0.77x |         - |
|            LinqOptimizer |   100 | 43.977 μs | 2.9042 μs | 8.3327 μs | 40.750 μs | 14.11x slower |   4.19x |   9,208 B |
|                  Streams |   100 | 13.912 μs | 1.0183 μs | 2.9705 μs | 12.700 μs |  4.44x slower |   1.30x |     760 B |
|               StructLinq |   100 | 11.697 μs | 1.3280 μs | 3.8315 μs | 10.350 μs |  3.71x slower |   1.33x |      64 B |
| StructLinq_ValueDelegate |   100 |  5.223 μs | 0.4166 μs | 1.0753 μs |  4.850 μs |  1.65x slower |   0.44x |         - |
|                Hyperlinq |   100 |  6.171 μs | 0.5152 μs | 1.3206 μs |  5.700 μs |  1.95x slower |   0.55x |         - |
|  Hyperlinq_ValueDelegate |   100 |  5.478 μs | 0.5233 μs | 1.3509 μs |  4.950 μs |  1.74x slower |   0.57x |         - |
|                  Faslinq |   100 |  9.230 μs | 0.9631 μs | 2.6527 μs |  8.400 μs |  2.92x slower |   0.88x |     648 B |
