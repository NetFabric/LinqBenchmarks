## List.Int32.ListInt32SkipTakeWhere

### Source
[ListInt32SkipTakeWhere.cs](../LinqBenchmarks/List/Int32/ListInt32SkipTakeWhere.cs)

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
|                   Method | Skip | Count |      Mean |     Error |     StdDev |    Median |         Ratio | RatioSD | Allocated |
|------------------------- |----- |------ |----------:|----------:|-----------:|----------:|--------------:|--------:|----------:|
|                  ForLoop | 1000 |   100 |  3.171 μs | 0.1339 μs |  0.3755 μs |  3.150 μs |      baseline |         |         - |
|                     Linq | 1000 |   100 | 12.778 μs | 1.4297 μs |  3.9377 μs | 11.050 μs |  4.10x slower |   1.31x |     152 B |
|               LinqFaster | 1000 |   100 | 13.106 μs | 1.5516 μs |  4.5506 μs | 10.750 μs |  4.24x slower |   1.50x |   1,560 B |
|             LinqFasterer | 1000 |   100 | 10.608 μs | 0.7964 μs |  2.2978 μs | 10.200 μs |  3.40x slower |   0.84x |   5,112 B |
|                   LinqAF | 1000 |   100 | 18.673 μs | 1.6361 μs |  4.5609 μs | 16.800 μs |  5.97x slower |   1.60x |         - |
|            LinqOptimizer | 1000 |   100 | 54.284 μs | 4.1978 μs | 12.2453 μs | 49.950 μs | 17.35x slower |   4.28x |   9,200 B |
|                  Streams | 1000 |   100 | 24.135 μs | 2.0289 μs |  5.8862 μs | 21.000 μs |  7.72x slower |   2.14x |     936 B |
|               StructLinq | 1000 |   100 | 13.042 μs | 1.6365 μs |  4.6953 μs | 11.000 μs |  4.21x slower |   1.63x |      96 B |
| StructLinq_ValueDelegate | 1000 |   100 |  5.164 μs | 0.3465 μs |  0.9249 μs |  4.900 μs |  1.67x slower |   0.37x |         - |
|                Hyperlinq | 1000 |   100 |  5.897 μs | 0.4068 μs |  1.0572 μs |  5.600 μs |  1.90x slower |   0.41x |         - |
|  Hyperlinq_ValueDelegate | 1000 |   100 |  5.470 μs | 0.3883 μs |  1.0160 μs |  5.050 μs |  1.76x slower |   0.36x |         - |
