## Array.ValueType.ArrayValueTypeWhereCount

### Source
[ArrayValueTypeWhereCount.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereCount.cs)

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
|                  ForLoop |   100 |  2.742 μs | 0.1019 μs | 0.2890 μs |  2.700 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  2.888 μs | 0.1153 μs | 0.3215 μs |  2.850 μs |  1.06x slower |   0.16x |         - |
|                     Linq |   100 |  8.029 μs | 0.4123 μs | 1.1562 μs |  7.750 μs |  2.95x slower |   0.49x |      32 B |
|               LinqFaster |   100 |  3.476 μs | 0.1965 μs | 0.5510 μs |  3.400 μs |  1.28x slower |   0.23x |         - |
|             LinqFasterer |   100 |  4.433 μs | 0.3009 μs | 0.8776 μs |  4.100 μs |  1.63x slower |   0.38x |         - |
|                   LinqAF |   100 |  6.767 μs | 0.8562 μs | 2.4148 μs |  5.700 μs |  2.50x slower |   0.94x |         - |
|               StructLinq |   100 | 11.737 μs | 1.1409 μs | 3.2733 μs | 11.150 μs |  4.30x slower |   1.29x |      64 B |
|            LinqOptimizer |   100 | 41.489 μs | 3.3715 μs | 9.6736 μs | 39.100 μs | 15.32x slower |   3.78x |     512 B |
|                  Streams |   100 | 48.663 μs | 3.2854 μs | 9.6872 μs | 46.750 μs | 18.12x slower |   4.41x |     456 B |
| StructLinq_ValueDelegate |   100 |  4.456 μs | 0.5596 μs | 1.4840 μs |  3.850 μs |  1.64x slower |   0.57x |      48 B |
|                Hyperlinq |   100 |  4.943 μs | 0.6329 μs | 1.7325 μs |  4.200 μs |  1.82x slower |   0.65x |      96 B |
|  Hyperlinq_ValueDelegate |   100 |  4.393 μs | 0.5178 μs | 1.3640 μs |  3.900 μs |  1.62x slower |   0.53x |         - |
