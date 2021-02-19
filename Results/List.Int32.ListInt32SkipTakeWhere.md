## List.Int32.ListInt32SkipTakeWhere

### Source
[ListInt32SkipTakeWhere.cs](../LinqBenchmarks/List/Int32/ListInt32SkipTakeWhere.cs)

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
|               Method |      Job |  Runtime | Skip | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |----- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 |   116.3 ns |  1.05 ns |  0.88 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 | 4,555.5 ns | 22.45 ns | 19.90 ns | 39.18 |    0.30 | 0.0153 |     - |     - |      40 B |
|                 Linq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1,533.3 ns |  5.72 ns |  5.07 ns | 13.19 |    0.10 | 0.0725 |     - |     - |     152 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 | 1000 |   100 |   803.3 ns | 11.26 ns |  9.98 ns |  6.90 |    0.09 | 0.7458 |     - |     - |   1,560 B |
|               LinqAF | .NET 5.0 | .NET 5.0 | 1000 |   100 | 5,659.9 ns | 24.30 ns | 18.97 ns | 48.73 |    0.39 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   304.0 ns |  2.16 ns |  1.81 ns |  2.61 |    0.03 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   188.4 ns |  0.57 ns |  0.50 ns |  1.62 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   311.6 ns |  4.24 ns |  3.31 ns |  2.68 |    0.03 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   200.3 ns |  0.68 ns |  0.57 ns |  1.72 |    0.01 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 |   117.3 ns |  0.70 ns |  1.13 ns |  1.01 |    0.01 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 | 4,555.0 ns | 22.86 ns | 21.39 ns | 39.16 |    0.32 | 0.0153 |     - |     - |      40 B |
|                 Linq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1,553.9 ns | 12.24 ns | 11.44 ns | 13.33 |    0.11 | 0.0725 |     - |     - |     152 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 | 1000 |   100 |   817.1 ns |  4.44 ns |  3.71 ns |  7.02 |    0.06 | 0.7458 |     - |     - |   1,560 B |
|               LinqAF | .NET 6.0 | .NET 6.0 | 1000 |   100 | 5,958.0 ns | 17.80 ns | 14.86 ns | 51.22 |    0.35 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   310.3 ns |  2.24 ns |  1.87 ns |  2.67 |    0.02 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   167.0 ns |  0.88 ns |  0.73 ns |  1.44 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   304.9 ns |  4.29 ns |  4.01 ns |  2.63 |    0.05 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   200.8 ns |  0.99 ns |  0.87 ns |  1.73 |    0.01 |      - |     - |     - |         - |
