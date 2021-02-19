## List.ValueType.ListValueTypeWhereSelect

### Source
[ListValueTypeWhereSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelect.cs)

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
|               Method |      Job |  Runtime | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   922.6 ns |  3.36 ns |  2.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 1,119.9 ns |  2.42 ns |  2.15 ns |  1.21 |    0.00 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 2,741.0 ns |  7.67 ns |  6.40 ns |  2.97 |    0.01 | 0.1335 |     - |     - |     280 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 1,778.5 ns | 20.39 ns | 19.07 ns |  1.93 |    0.03 | 2.4433 |     - |     - |   5,112 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 2,447.0 ns | 27.23 ns | 25.47 ns |  2.65 |    0.03 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 1,178.8 ns |  4.53 ns |  4.23 ns |  1.28 |    0.01 | 0.0343 |     - |     - |      72 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   952.6 ns |  6.48 ns |  6.06 ns |  1.03 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 1,094.8 ns |  4.12 ns |  3.65 ns |  1.19 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 1,098.8 ns |  5.15 ns |  4.57 ns |  1.19 |    0.00 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |   923.4 ns |  3.57 ns |  3.16 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 1,126.2 ns |  4.68 ns |  4.14 ns |  1.22 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 1,747.9 ns |  5.60 ns |  4.68 ns |  1.90 |    0.01 | 0.1335 |     - |     - |     280 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 1,772.5 ns | 13.67 ns | 12.12 ns |  1.92 |    0.01 | 2.4433 |     - |     - |   5,112 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 2,457.7 ns | 17.94 ns | 15.91 ns |  2.66 |    0.02 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 1,208.7 ns |  2.93 ns |  2.74 ns |  1.31 |    0.00 | 0.0343 |     - |     - |      72 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   950.5 ns |  3.04 ns |  2.70 ns |  1.03 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 1,113.4 ns |  3.00 ns |  2.34 ns |  1.21 |    0.00 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 1,106.9 ns |  7.30 ns |  6.48 ns |  1.20 |    0.01 |      - |     - |     - |         - |
