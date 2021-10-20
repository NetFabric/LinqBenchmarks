## Array.Int32.ArrayInt32Select

### Source
[ArrayInt32Select.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Select.cs)

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
|                   Method | Count |        Mean |       Error |      StdDev |      Median | Ratio | RatioSD | Allocated |
|------------------------- |------ |------------:|------------:|------------:|------------:|------:|--------:|----------:|
|                  ForLoop |   100 |    473.3 ns |    95.26 ns |    265.6 ns |    450.0 ns |     ? |       ? |         - |
|              ForeachLoop |   100 |    884.4 ns |   278.65 ns |    804.0 ns |    650.0 ns |     ? |       ? |         - |
|                     Linq |   100 |  5,778.6 ns |   915.71 ns |  2,671.2 ns |  4,400.0 ns |     ? |       ? |     424 B |
|               LinqFaster |   100 |  4,202.0 ns |   359.61 ns |  1,049.0 ns |  4,200.0 ns |     ? |       ? |     424 B |
|          LinqFaster_SIMD |   100 |  5,205.3 ns |   372.84 ns |  1,069.7 ns |  4,900.0 ns |     ? |       ? |     424 B |
|             LinqFasterer |   100 | 10,728.6 ns | 2,009.19 ns |  5,860.9 ns |  7,800.0 ns |     ? |       ? |     456 B |
|                   LinqAF |   100 | 12,564.6 ns | 3,756.61 ns | 11,017.5 ns |  6,600.0 ns |     ? |       ? |         - |
|            LinqOptimizer |   100 | 53,664.6 ns | 5,726.39 ns | 16,521.9 ns | 50,100.0 ns |     ? |       ? |   9,352 B |
|                 SpanLinq |   100 | 10,099.0 ns | 2,062.39 ns |  6,016.1 ns |  7,000.0 ns |     ? |       ? |         - |
|                  Streams |   100 | 22,562.5 ns | 6,706.80 ns | 19,350.7 ns | 12,000.0 ns |     ? |       ? |     584 B |
|               StructLinq |   100 |  9,969.8 ns | 1,965.72 ns |  5,671.5 ns |  7,350.0 ns |     ? |       ? |      32 B |
| StructLinq_ValueDelegate |   100 |  5,919.4 ns | 1,805.19 ns |  5,265.8 ns |  3,000.0 ns |     ? |       ? |         - |
|                Hyperlinq |   100 |  7,501.5 ns | 2,222.55 ns |  6,448.0 ns |  4,550.0 ns |     ? |       ? |         - |
|  Hyperlinq_ValueDelegate |   100 |  5,144.3 ns | 1,260.83 ns |  3,657.9 ns |  3,500.0 ns |     ? |       ? |         - |
|                  Faslinq |   100 |  2,844.3 ns |   370.34 ns |  1,074.4 ns |  2,700.0 ns |     ? |       ? |     424 B |
