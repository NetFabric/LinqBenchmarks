## List.ValueType.ListValueTypeSelectSum

### Source
[ListValueTypeSelectSum.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSelectSum.cs)

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
|                  ForLoop |   100 |  2.765 μs | 0.2893 μs | 0.8393 μs |  2.500 μs |      baseline |         |      48 B |
|              ForeachLoop |   100 |  3.476 μs | 0.2828 μs | 0.8204 μs |  3.200 μs |  1.38x slower |   0.55x |         - |
|                     Linq |   100 |  7.026 μs | 0.5060 μs | 1.4272 μs |  6.800 μs |  2.79x slower |   0.99x |      96 B |
|               LinqFaster |   100 |  2.698 μs | 0.2107 μs | 0.5978 μs |  2.500 μs |  1.05x slower |   0.34x |      48 B |
|             LinqFasterer |   100 |  7.874 μs | 0.6508 μs | 1.8672 μs |  7.500 μs |  3.09x slower |   1.10x |   6,472 B |
|                   LinqAF |   100 |  8.717 μs | 0.9969 μs | 2.8281 μs |  7.800 μs |  3.44x slower |   1.51x |      96 B |
|            LinqOptimizer |   100 | 43.074 μs | 3.3810 μs | 9.8626 μs | 39.850 μs | 16.81x slower |   6.06x |     704 B |
|                  Streams |   100 | 23.465 μs | 3.3788 μs | 9.6398 μs | 19.000 μs |  9.29x slower |   4.81x |     408 B |
|               StructLinq |   100 |  9.284 μs | 1.1513 μs | 3.3034 μs |  7.850 μs |  3.65x slower |   1.68x |      40 B |
| StructLinq_ValueDelegate |   100 |  4.375 μs | 0.9442 μs | 2.6005 μs |  3.200 μs |  1.76x slower |   1.24x |         - |
|                Hyperlinq |   100 |  4.346 μs | 0.4596 μs | 1.1783 μs |  3.950 μs |  1.72x slower |   0.63x |      48 B |
|  Hyperlinq_ValueDelegate |   100 |  3.188 μs | 0.3886 μs | 1.0169 μs |  2.850 μs |  1.25x slower |   0.42x |         - |
|                  Faslinq |   100 | 12.360 μs | 1.5141 μs | 4.4406 μs | 10.700 μs |  4.88x slower |   2.27x |   1,224 B |
