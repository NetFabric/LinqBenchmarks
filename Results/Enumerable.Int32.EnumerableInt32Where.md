## Enumerable.Int32.EnumerableInt32Where

### Source
[EnumerableInt32Where.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Where.cs)

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
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 850.0 ns | 3.61 ns | 3.37 ns |  1.00 | 0.0458 |     - |     - |      96 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 792.1 ns | 4.56 ns | 4.04 ns |  0.93 | 0.0191 |     - |     - |      40 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 730.6 ns | 2.09 ns | 1.95 ns |  0.86 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 563.1 ns | 1.88 ns | 1.67 ns |  0.66 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 715.8 ns | 3.67 ns | 3.43 ns |  0.84 | 0.0191 |     - |     - |      40 B |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 528.7 ns | 3.54 ns | 2.96 ns |  0.62 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 911.0 ns | 4.24 ns | 3.54 ns |  1.07 | 0.0458 |     - |     - |      96 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 844.8 ns | 6.15 ns | 5.45 ns |  0.99 | 0.0191 |     - |     - |      40 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 693.5 ns | 3.75 ns | 2.93 ns |  0.82 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 561.1 ns | 3.81 ns | 3.38 ns |  0.66 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 676.7 ns | 3.26 ns | 2.89 ns |  0.80 | 0.0191 |     - |     - |      40 B |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 538.9 ns | 3.66 ns | 3.05 ns |  0.63 | 0.0191 |     - |     - |      40 B |
