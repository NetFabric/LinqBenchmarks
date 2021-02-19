## Enumerable.Int32.EnumerableInt32WhereCount

### Source
[EnumerableInt32WhereCount.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereCount.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqFaster.SIMD: [1.1.2](https://www.nuget.org/packages/LinqFaster.SIMD/1.0.3)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- StructLinq.BCL: [0.25.3](https://www.nuget.org/packages/StructLinq.BCL/0.25.3)
- NetFabric.Hyperlinq: [3.0.0-beta38](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta38)

### Results:
``` ini

BenchmarkDotNet=v0.12.1.1514-nightly, OS=Windows 10.0.19042.804 (20H2/October2020Update)
Intel Core i7-7567U CPU 3.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.1.21103.13
  [Host]   : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT
  .NET 5.0 : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT
  .NET 6.0 : .NET 6.0.0 (6.0.21.10212), X64 RyuJIT


```
|               Method |      Job |  Runtime | Count |     Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |---------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 496.6 ns | 2.27 ns | 1.89 ns |  1.00 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 603.4 ns | 4.71 ns | 3.68 ns |  1.22 | 0.0191 |     - |     - |      40 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 684.6 ns | 3.96 ns | 3.31 ns |  1.38 | 0.0191 |     - |     - |      40 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 657.6 ns | 2.59 ns | 2.16 ns |  1.32 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 492.5 ns | 2.78 ns | 2.47 ns |  0.99 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 628.2 ns | 2.09 ns | 1.75 ns |  1.26 | 0.0191 |     - |     - |      40 B |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 469.8 ns | 1.74 ns | 1.54 ns |  0.95 | 0.0191 |     - |     - |      40 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 474.6 ns | 2.21 ns | 1.96 ns |  0.96 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 648.4 ns | 2.31 ns | 2.16 ns |  1.31 | 0.0191 |     - |     - |      40 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 657.5 ns | 2.42 ns | 2.27 ns |  1.32 | 0.0191 |     - |     - |      40 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 694.5 ns | 3.90 ns | 3.46 ns |  1.40 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 482.9 ns | 2.24 ns | 1.99 ns |  0.97 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 600.5 ns | 2.47 ns | 2.19 ns |  1.21 | 0.0191 |     - |     - |      40 B |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 470.2 ns | 2.01 ns | 1.88 ns |  0.95 | 0.0191 |     - |     - |      40 B |
