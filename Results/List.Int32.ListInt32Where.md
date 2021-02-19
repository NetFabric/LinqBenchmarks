## List.Int32.ListInt32Where

### Source
[ListInt32Where.cs](../LinqBenchmarks/List/Int32/ListInt32Where.cs)

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
|               Method |      Job |  Runtime | Count |        Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |------------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   145.14 ns | 0.495 ns | 0.413 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   254.26 ns | 1.331 ns | 1.111 ns |  1.75 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 |   806.59 ns | 3.757 ns | 3.331 ns |  5.56 |    0.03 | 0.0343 |     - |     - |      72 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 |   442.06 ns | 2.385 ns | 1.992 ns |  3.05 |    0.02 | 0.3095 |     - |     - |     648 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 1,014.48 ns | 8.920 ns | 8.344 ns |  7.00 |    0.07 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |   344.81 ns | 3.400 ns | 3.014 ns |  2.38 |    0.02 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   167.32 ns | 1.036 ns | 0.866 ns |  1.15 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |   269.23 ns | 2.987 ns | 2.495 ns |  1.86 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   200.04 ns | 0.916 ns | 0.715 ns |  1.38 |    0.01 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |    97.96 ns | 0.306 ns | 0.239 ns |  0.67 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   187.00 ns | 3.196 ns | 2.833 ns |  1.29 |    0.02 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 |   755.89 ns | 3.209 ns | 3.002 ns |  5.21 |    0.03 | 0.0343 |     - |     - |      72 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 |   384.12 ns | 2.341 ns | 1.955 ns |  2.65 |    0.02 | 0.3095 |     - |     - |     648 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 |   928.34 ns | 5.841 ns | 5.178 ns |  6.40 |    0.04 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |   289.60 ns | 0.815 ns | 0.723 ns |  1.99 |    0.01 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   200.70 ns | 0.819 ns | 0.684 ns |  1.38 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |   265.40 ns | 1.325 ns | 1.107 ns |  1.83 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   199.56 ns | 0.336 ns | 0.262 ns |  1.37 |    0.00 |      - |     - |     - |         - |
