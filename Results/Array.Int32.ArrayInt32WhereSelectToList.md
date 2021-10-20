## Array.Int32.ArrayInt32WhereSelectToList

### Source
[ArrayInt32WhereSelectToList.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelectToList.cs)

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
|                   Method | Count |      Mean |     Error |   StdDev |    Median |        Ratio | RatioSD | Allocated |
|------------------------- |------ |----------:|----------:|---------:|----------:|-------------:|--------:|----------:|
|                  ForLoop |   100 |  7.088 μs | 0.7674 μs | 2.251 μs |  6.800 μs |     baseline |         |     648 B |
|              ForeachLoop |   100 |  6.671 μs | 0.8603 μs | 2.523 μs |  5.600 μs | 1.03x slower |   0.49x |     744 B |
|                     Linq |   100 | 12.596 μs | 1.2665 μs | 3.634 μs | 12.200 μs | 1.97x slower |   0.93x |   1,400 B |
|               LinqFaster |   100 |  9.978 μs | 0.4666 μs | 1.285 μs |  9.500 μs | 1.54x slower |   0.54x |     936 B |
|             LinqFasterer |   100 | 13.596 μs | 1.4145 μs | 4.081 μs | 12.150 μs | 2.12x slower |   0.96x |   1,472 B |
|                   LinqAF |   100 | 13.505 μs | 1.8144 μs | 5.264 μs | 11.500 μs | 2.09x slower |   1.05x |     744 B |
|            LinqOptimizer |   100 | 34.402 μs | 2.1843 μs | 6.196 μs | 33.000 μs | 5.32x slower |   1.83x |   9,600 B |
|                 SpanLinq |   100 | 11.309 μs | 0.5934 μs | 1.702 μs | 10.900 μs | 1.75x slower |   0.60x |     696 B |
|                  Streams |   100 | 20.157 μs | 1.5417 μs | 4.424 μs | 18.950 μs | 3.13x slower |   1.20x |   1,288 B |
|               StructLinq |   100 | 21.769 μs | 1.8486 μs | 5.334 μs | 19.550 μs | 3.39x slower |   1.35x |     984 B |
| StructLinq_ValueDelegate |   100 | 14.161 μs | 1.4971 μs | 4.271 μs | 12.100 μs | 2.16x slower |   0.89x |     888 B |
|                Hyperlinq |   100 | 17.820 μs | 2.3922 μs | 6.864 μs | 15.500 μs | 2.73x slower |   1.32x |     760 B |
|  Hyperlinq_ValueDelegate |   100 | 15.439 μs | 1.6292 μs | 4.727 μs | 13.150 μs | 2.42x slower |   1.15x |     760 B |
