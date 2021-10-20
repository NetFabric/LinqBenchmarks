## Array.ValueType.ArrayValueTypeWhereSelect

### Source
[ArrayValueTypeWhereSelect.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelect.cs)

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
|                  ForLoop |   100 |  5.072 μs | 0.2560 μs | 0.7136 μs |  4.850 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  4.740 μs | 0.1253 μs | 0.3533 μs |  4.650 μs |  1.07x faster |   0.15x |      48 B |
|                     Linq |   100 | 15.296 μs | 1.5364 μs | 4.4818 μs | 13.350 μs |  3.12x slower |   1.01x |     216 B |
|               LinqFaster |   100 | 10.792 μs | 0.5579 μs | 1.5551 μs | 10.400 μs |  2.16x slower |   0.39x |   9,904 B |
|             LinqFasterer |   100 | 15.054 μs | 0.5821 μs | 1.6226 μs | 14.500 μs |  3.02x slower |   0.51x |  12,624 B |
|                   LinqAF |   100 | 11.320 μs | 0.7665 μs | 2.0058 μs | 10.600 μs |  2.28x slower |   0.49x |         - |
|            LinqOptimizer |   100 | 52.890 μs | 3.3726 μs | 9.6223 μs | 50.350 μs | 10.66x slower |   2.47x | 135,288 B |
|                 SpanLinq |   100 | 12.872 μs | 0.2917 μs | 0.8083 μs | 12.800 μs |  2.59x slower |   0.36x |         - |
|                  Streams |   100 | 81.404 μs | 2.7046 μs | 7.8465 μs | 78.400 μs | 16.34x slower |   2.60x |     976 B |
|               StructLinq |   100 | 13.517 μs | 1.1365 μs | 3.1110 μs | 12.200 μs |  2.71x slower |   0.68x |      64 B |
| StructLinq_ValueDelegate |   100 |  8.362 μs | 0.9609 μs | 2.6142 μs |  7.250 μs |  1.68x slower |   0.55x |         - |
|                Hyperlinq |   100 |  9.491 μs | 0.6223 μs | 1.5952 μs |  9.100 μs |  1.94x slower |   0.42x |         - |
|  Hyperlinq_ValueDelegate |   100 |  7.868 μs | 0.5732 μs | 1.4899 μs |  7.550 μs |  1.58x slower |   0.29x |         - |
|                  Faslinq |   100 | 11.508 μs | 1.1890 μs | 3.4494 μs | 10.050 μs |  2.34x slower |   0.78x |   6,424 B |
