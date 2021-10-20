## List.Int32.ListInt32SelectToList

### Source
[ListInt32SelectToList.cs](../LinqBenchmarks/List/Int32/ListInt32SelectToList.cs)

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
|                       Method | Count |      Mean |     Error |   StdDev |    Median |       P95 |        Ratio | RatioSD | Allocated |
|----------------------------- |------ |----------:|----------:|---------:|----------:|----------:|-------------:|--------:|----------:|
|                      ForLoop |   100 |  6.507 μs | 0.5288 μs | 1.517 μs |  6.200 μs |  9.600 μs |     baseline |         |   1,184 B |
|                  ForeachLoop |   100 |  6.683 μs | 0.4296 μs | 1.226 μs |  6.700 μs |  9.300 μs | 1.08x slower |   0.31x |   1,184 B |
|                         Linq |   100 |  7.422 μs | 0.5328 μs | 1.520 μs |  7.000 μs | 10.635 μs | 1.20x slower |   0.37x |     528 B |
|                   LinqFaster |   100 |  7.118 μs | 0.6264 μs | 1.787 μs |  6.500 μs | 11.270 μs | 1.17x slower |   0.46x |     912 B |
|                 LinqFasterer |   100 | 11.184 μs | 1.5509 μs | 4.450 μs |  9.000 μs | 20.330 μs | 1.81x slower |   0.86x |   1,304 B |
|                       LinqAF |   100 | 11.861 μs | 1.2600 μs | 3.449 μs | 10.550 μs | 20.570 μs | 1.92x slower |   0.77x |   1,184 B |
|                LinqOptimizer |   100 | 44.539 μs | 2.4834 μs | 7.125 μs | 43.000 μs | 57.590 μs | 7.23x slower |   2.02x |   9,816 B |
|                      Streams |   100 | 21.492 μs | 2.1651 μs | 6.212 μs | 18.850 μs | 34.220 μs | 3.50x slower |   1.30x |   1,576 B |
|                   StructLinq |   100 |  9.695 μs | 1.2653 μs | 3.630 μs |  8.200 μs | 16.620 μs | 1.56x slower |   0.68x |     520 B |
|     StructLinq_ValueDelegate |   100 |  8.729 μs | 1.0420 μs | 2.939 μs |  7.750 μs | 13.680 μs | 1.43x slower |   0.61x |     496 B |
|                    Hyperlinq |   100 |  8.162 μs | 1.4557 μs | 3.835 μs |  6.600 μs | 19.800 μs | 1.34x slower |   0.75x |     456 B |
|      Hyperlinq_ValueDelegate |   100 |  8.374 μs | 1.3114 μs | 3.699 μs |  6.700 μs | 16.145 μs | 1.36x slower |   0.71x |     456 B |
|               Hyperlinq_SIMD |   100 |  8.489 μs | 1.7958 μs | 4.976 μs |  6.400 μs | 20.100 μs | 1.37x slower |   0.88x |     456 B |
| Hyperlinq_ValueDelegate_SIMD |   100 |  7.118 μs | 1.1247 μs | 3.098 μs |  6.150 μs | 15.975 μs | 1.15x slower |   0.60x |     456 B |
|                      Faslinq |   100 |  6.684 μs | 0.4944 μs | 1.403 μs |  6.350 μs |  9.530 μs | 1.08x slower |   0.33x |   1,184 B |
