## ImmutableArray.Int32.ImmutableArrayInt32Select

### Source
[ImmutableArrayInt32Select.cs](../LinqBenchmarks/ImmutableArray/Int32/ImmutableArrayInt32Select.cs)

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
|                  ForLoop |   100 |  1.022 μs | 0.0890 μs |  0.2552 μs |  1.000 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  3.645 μs | 1.2230 μs |  3.5677 μs |  1.700 μs |  4.03x slower |   4.59x |         - |
|                     Linq |   100 |  5.531 μs | 0.9446 μs |  2.6176 μs |  4.600 μs |  5.88x slower |   3.30x |      48 B |
|             LinqFasterer |   100 |  7.249 μs | 1.6770 μs |  4.8386 μs |  5.750 μs |  7.49x slower |   5.02x |     904 B |
|            LinqOptimizer |   100 | 24.987 μs | 3.7812 μs | 11.0897 μs | 24.250 μs | 27.02x slower |  17.03x |   9,384 B |
|                  Streams |   100 | 12.186 μs | 1.9707 μs |  5.5583 μs | 11.900 μs | 13.08x slower |   8.53x |     608 B |
|               StructLinq |   100 | 12.526 μs | 2.7160 μs |  7.9656 μs |  7.700 μs | 13.62x slower |  10.05x |      32 B |
| StructLinq_ValueDelegate |   100 |  5.934 μs | 1.6206 μs |  4.7275 μs |  3.250 μs |  6.61x slower |   6.81x |         - |
|                Hyperlinq |   100 |  5.914 μs | 1.5045 μs |  4.4124 μs |  3.500 μs |  6.33x slower |   5.29x |         - |
|  Hyperlinq_ValueDelegate |   100 |  2.566 μs | 0.1412 μs |  0.3959 μs |  2.600 μs |  2.72x slower |   0.98x |         - |
