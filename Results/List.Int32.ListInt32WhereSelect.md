## List.Int32.ListInt32WhereSelect

### Source
[ListInt32WhereSelect.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelect.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   129.56 ns | 0.737 ns | 0.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   256.65 ns | 1.922 ns | 1.798 ns |  1.98 |    0.02 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 1,057.85 ns | 4.643 ns | 3.877 ns |  8.17 |    0.05 | 0.0725 |     - |     - |     152 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 |   554.16 ns | 4.106 ns | 3.640 ns |  4.28 |    0.03 | 0.3090 |     - |     - |     648 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 1,057.78 ns | 3.312 ns | 2.936 ns |  8.16 |    0.05 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |   369.68 ns | 2.395 ns | 2.000 ns |  2.85 |    0.02 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   183.18 ns | 0.549 ns | 0.487 ns |  1.41 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |   374.92 ns | 1.354 ns | 1.266 ns |  2.89 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   207.89 ns | 0.755 ns | 0.631 ns |  1.60 |    0.01 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |    98.12 ns | 0.446 ns | 0.373 ns |  0.76 |    0.01 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   159.74 ns | 1.205 ns | 1.006 ns |  1.23 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 |   978.58 ns | 4.082 ns | 3.408 ns |  7.55 |    0.05 | 0.0725 |     - |     - |     152 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 |   454.99 ns | 2.495 ns | 2.083 ns |  3.51 |    0.02 | 0.3095 |     - |     - |     648 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 1,035.22 ns | 8.918 ns | 8.342 ns |  8.00 |    0.08 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |   396.50 ns | 1.850 ns | 1.444 ns |  3.06 |    0.02 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   182.79 ns | 1.107 ns | 0.924 ns |  1.41 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |   376.78 ns | 2.482 ns | 2.073 ns |  2.91 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   207.30 ns | 1.170 ns | 1.037 ns |  1.60 |    0.01 |      - |     - |     - |         - |
