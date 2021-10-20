## List.Int32.ListInt32Select

### Source
[ListInt32Select.cs](../LinqBenchmarks/List/Int32/ListInt32Select.cs)

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
|                   Method | Count |      Mean |     Error |     StdDev |    Median |       P95 |         Ratio | RatioSD | Allocated |
|------------------------- |------ |----------:|----------:|-----------:|----------:|----------:|--------------:|--------:|----------:|
|                  ForLoop |   100 |  1.936 μs | 0.4553 μs |  1.2989 μs |  1.350 μs |  4.785 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  4.762 μs | 1.5341 μs |  4.4751 μs |  2.350 μs | 13.345 μs |  3.43x slower |   4.06x |         - |
|                     Linq |   100 |  8.881 μs | 0.9639 μs |  2.5394 μs |  7.950 μs | 14.350 μs |  6.00x slower |   3.22x |      72 B |
|               LinqFaster |   100 |  7.839 μs | 1.0696 μs |  3.0860 μs |  6.500 μs | 13.725 μs |  5.47x slower |   3.23x |     456 B |
|             LinqFasterer |   100 |  7.877 μs | 0.6058 μs |  1.5530 μs |  7.550 μs | 10.350 μs |  5.33x slower |   2.77x |     880 B |
|                   LinqAF |   100 |  5.365 μs | 0.4115 μs |  1.0768 μs |  5.000 μs |  7.520 μs |  3.77x slower |   2.16x |      40 B |
|            LinqOptimizer |   100 | 46.004 μs | 3.9967 μs | 11.4028 μs | 43.000 μs | 68.410 μs | 32.14x slower |  16.22x |   9,392 B |
|                  Streams |   100 | 11.782 μs | 1.7630 μs |  4.5822 μs | 10.300 μs | 21.700 μs |  8.27x slower |   6.06x |     608 B |
|               StructLinq |   100 |  9.862 μs | 1.7766 μs |  4.7422 μs |  8.750 μs | 24.600 μs |  6.67x slower |   4.55x |      32 B |
| StructLinq_ValueDelegate |   100 |  2.940 μs | 0.3871 μs |  0.9993 μs |  2.700 μs |  5.215 μs |  1.94x slower |   0.99x |         - |
|                Hyperlinq |   100 |  3.468 μs | 0.3869 μs |  1.0057 μs |  3.100 μs |  5.110 μs |  2.38x slower |   1.37x |         - |
|  Hyperlinq_ValueDelegate |   100 |  3.295 μs | 0.3285 μs |  0.8481 μs |  3.000 μs |  5.160 μs |  2.22x slower |   1.27x |         - |
|                  Faslinq |   100 |  8.549 μs | 0.6533 μs |  1.9056 μs |  7.600 μs | 12.330 μs |  5.99x slower |   2.98x |   1,184 B |
