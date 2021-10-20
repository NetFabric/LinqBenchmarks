## Array.ValueType.ArrayValueTypeWhereSelectToArray

### Source
[ArrayValueTypeWhereSelectToArray.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelectToArray.cs)

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
|                   Method | Count |     Mean |    Error |   StdDev |   Median |        Ratio | RatioSD | Allocated |
|------------------------- |------ |---------:|---------:|---------:|---------:|-------------:|--------:|----------:|
|                  ForLoop |   100 | 12.32 μs | 0.976 μs | 2.784 μs | 11.25 μs |     baseline |         |     11 KB |
|              ForeachLoop |   100 | 13.99 μs | 0.687 μs | 1.948 μs | 14.05 μs | 1.19x slower |   0.28x |     11 KB |
|                     Linq |   100 | 21.67 μs | 1.614 μs | 4.658 μs | 20.70 μs | 1.82x slower |   0.46x |      8 KB |
|               LinqFaster |   100 | 12.97 μs | 0.846 μs | 2.387 μs | 13.05 μs | 1.09x slower |   0.27x |     10 KB |
|             LinqFasterer |   100 | 15.35 μs | 0.787 μs | 2.271 μs | 15.00 μs | 1.31x slower |   0.32x |     12 KB |
|                   LinqAF |   100 | 23.55 μs | 2.134 μs | 6.225 μs | 20.85 μs | 1.95x slower |   0.50x |     11 KB |
|            LinqOptimizer |   100 | 68.79 μs | 3.150 μs | 8.884 μs | 67.25 μs | 5.86x slower |   1.36x |    132 KB |
|                 SpanLinq |   100 | 22.45 μs | 0.708 μs | 1.963 μs | 22.60 μs | 1.90x slower |   0.40x |     11 KB |
|                  Streams |   100 | 82.03 μs | 2.871 μs | 8.050 μs | 78.85 μs | 6.92x slower |   1.33x |     12 KB |
|               StructLinq |   100 | 22.96 μs | 2.857 μs | 8.289 μs | 18.80 μs | 1.89x slower |   0.62x |      3 KB |
| StructLinq_ValueDelegate |   100 | 17.89 μs | 1.506 μs | 4.393 μs | 17.05 μs | 1.51x slower |   0.44x |      3 KB |
|                Hyperlinq |   100 | 20.98 μs | 2.048 μs | 5.942 μs | 18.70 μs | 1.75x slower |   0.48x |      3 KB |
|  Hyperlinq_ValueDelegate |   100 | 18.37 μs | 1.861 μs | 5.399 μs | 16.20 μs | 1.53x slower |   0.50x |      3 KB |
