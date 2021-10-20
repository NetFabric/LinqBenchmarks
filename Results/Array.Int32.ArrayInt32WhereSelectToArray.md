## Array.Int32.ArrayInt32WhereSelectToArray

### Source
[ArrayInt32WhereSelectToArray.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelectToArray.cs)

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
|                   Method | Count |      Mean |     Error |    StdDev |    Median |        Ratio | RatioSD | Allocated |
|------------------------- |------ |----------:|----------:|----------:|----------:|-------------:|--------:|----------:|
|                  ForLoop |   100 |  9.465 μs | 1.0393 μs | 2.9986 μs |  8.150 μs |     baseline |         |     888 B |
|              ForeachLoop |   100 |  7.407 μs | 0.3217 μs | 0.8753 μs |  7.400 μs | 1.30x faster |   0.42x |     888 B |
|                     Linq |   100 | 11.135 μs | 0.9112 μs | 2.4006 μs | 10.600 μs | 1.25x slower |   0.36x |   1,272 B |
|               LinqFaster |   100 |  6.367 μs | 0.3009 μs | 0.8487 μs |  6.300 μs | 1.53x faster |   0.56x |     664 B |
|             LinqFasterer |   100 |  6.798 μs | 0.4020 μs | 1.1338 μs |  6.750 μs | 1.41x faster |   0.41x |     832 B |
|                   LinqAF |   100 | 15.424 μs | 2.1797 μs | 6.3582 μs | 12.400 μs | 1.67x slower |   0.50x |     856 B |
|            LinqOptimizer |   100 | 38.412 μs | 2.4794 μs | 6.8704 μs | 37.350 μs | 4.43x slower |   1.43x |   9,136 B |
|                 SpanLinq |   100 | 12.917 μs | 0.4446 μs | 1.2466 μs | 12.650 μs | 1.48x slower |   0.43x |     888 B |
|                  Streams |   100 | 19.666 μs | 2.0204 μs | 5.7969 μs | 17.800 μs | 2.18x slower |   0.66x |   1,400 B |
|               StructLinq |   100 | 16.062 μs | 2.1370 μs | 5.8140 μs | 14.550 μs | 1.79x slower |   0.64x |     904 B |
| StructLinq_ValueDelegate |   100 | 15.151 μs | 2.0142 μs | 5.8435 μs | 13.100 μs | 1.66x slower |   0.60x |     760 B |
|                Hyperlinq |   100 | 19.720 μs | 3.0824 μs | 8.5413 μs | 15.700 μs | 2.13x slower |   0.63x |     680 B |
|  Hyperlinq_ValueDelegate |   100 | 18.459 μs | 1.7377 μs | 5.0688 μs | 16.550 μs | 2.07x slower |   0.64x |     728 B |
