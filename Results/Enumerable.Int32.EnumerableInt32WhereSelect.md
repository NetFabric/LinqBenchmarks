## Enumerable.Int32.EnumerableInt32WhereSelect

### Source
[EnumerableInt32WhereSelect.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelect.cs)

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
|               Method |      Job |  Runtime | Count |       Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |-----------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   442.9 ns | 2.48 ns | 2.20 ns |  1.00 |    0.00 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 |   974.7 ns | 8.17 ns | 7.24 ns |  2.20 |    0.02 | 0.0763 |     - |     - |     160 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 |   925.1 ns | 1.83 ns | 1.62 ns |  2.09 |    0.01 | 0.0191 |     - |     - |      40 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |   767.3 ns | 3.79 ns | 3.36 ns |  1.73 |    0.01 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   550.1 ns | 2.42 ns | 2.15 ns |  1.24 |    0.01 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |   855.3 ns | 1.64 ns | 1.28 ns |  1.93 |    0.01 | 0.0191 |     - |     - |      40 B |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   571.5 ns | 3.32 ns | 2.94 ns |  1.29 |    0.01 | 0.0191 |     - |     - |      40 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   473.0 ns | 1.43 ns | 1.19 ns |  1.07 |    0.01 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 1,020.6 ns | 4.18 ns | 3.26 ns |  2.30 |    0.01 | 0.0763 |     - |     - |     160 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 |   877.7 ns | 5.53 ns | 4.31 ns |  1.98 |    0.02 | 0.0191 |     - |     - |      40 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |   889.5 ns | 3.72 ns | 3.10 ns |  2.01 |    0.01 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   538.4 ns | 2.81 ns | 2.49 ns |  1.22 |    0.01 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |   825.5 ns | 4.52 ns | 4.01 ns |  1.86 |    0.01 | 0.0191 |     - |     - |      40 B |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   568.6 ns | 2.77 ns | 2.31 ns |  1.28 |    0.01 | 0.0191 |     - |     - |      40 B |
