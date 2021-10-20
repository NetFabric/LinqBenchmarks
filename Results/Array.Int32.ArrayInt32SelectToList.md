## Array.Int32.ArrayInt32SelectToList

### Source
[ArrayInt32SelectToList.cs](../LinqBenchmarks/Array/Int32/ArrayInt32SelectToList.cs)

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
|                       Method | Count |      Mean |     Error |    StdDev |    Median |        Ratio | RatioSD | Allocated |
|----------------------------- |------ |----------:|----------:|----------:|----------:|-------------:|--------:|----------:|
|                      ForLoop |   100 |  5.723 μs | 0.2325 μs | 0.6596 μs |  5.650 μs |     baseline |         |   1,184 B |
|                  ForeachLoop |   100 |  5.309 μs | 0.3276 μs | 0.9400 μs |  5.200 μs | 1.10x faster |   0.24x |   1,184 B |
|                         Linq |   100 | 10.824 μs | 1.9299 μs | 5.6297 μs |  7.900 μs | 1.95x slower |   1.03x |     880 B |
|                   LinqFaster |   100 |  6.652 μs | 0.3267 μs | 0.9053 μs |  6.700 μs | 1.18x slower |   0.21x |     880 B |
|              LinqFaster_SIMD |   100 |  5.224 μs | 0.5746 μs | 1.6579 μs |  4.950 μs | 1.25x faster |   0.50x |     880 B |
|                 LinqFasterer |   100 |  9.025 μs | 1.8220 μs | 5.3721 μs |  7.650 μs | 1.63x slower |   0.98x |     880 B |
|                       LinqAF |   100 |  8.909 μs | 1.2730 μs | 3.5696 μs |  9.000 μs | 1.58x slower |   0.69x |   1,184 B |
|                LinqOptimizer |   100 | 22.300 μs | 2.3559 μs | 6.8722 μs | 20.950 μs | 3.96x slower |   1.33x |   9,776 B |
|                     SpanLinq |   100 |  8.546 μs | 0.2529 μs | 0.7008 μs |  8.400 μs | 1.51x slower |   0.20x |     456 B |
|                      Streams |   100 | 15.793 μs | 1.4205 μs | 4.0985 μs | 14.200 μs | 2.81x slower |   0.80x |   1,576 B |
|                   StructLinq |   100 | 10.219 μs | 1.6747 μs | 4.8851 μs |  7.750 μs | 1.84x slower |   0.92x |     520 B |
|     StructLinq_ValueDelegate |   100 |  6.459 μs | 0.7638 μs | 2.1668 μs |  6.200 μs | 1.14x slower |   0.39x |     496 B |
|                    Hyperlinq |   100 |  7.010 μs | 1.7828 μs | 5.1439 μs |  4.950 μs | 1.26x slower |   0.91x |     456 B |
|      Hyperlinq_ValueDelegate |   100 |  5.476 μs | 1.0817 μs | 3.0685 μs |  4.700 μs | 1.38x faster |   0.73x |     456 B |
|               Hyperlinq_SIMD |   100 |  8.832 μs | 2.2214 μs | 6.4799 μs |  6.050 μs | 1.60x slower |   1.18x |     456 B |
| Hyperlinq_ValueDelegate_SIMD |   100 |  9.443 μs | 1.9495 μs | 5.7176 μs |  6.300 μs | 1.70x slower |   1.05x |     456 B |
