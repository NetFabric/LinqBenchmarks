## List.ValueType.ListValueTypeWhereSelectToList

### Source
[ListValueTypeWhereSelectToList.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelectToList.cs)

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
|               Method |      Job |  Runtime | Count |       Mean |    Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |-----------:|---------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   923.9 ns |  5.16 ns |   4.57 ns |   925.4 ns |  1.00 |    0.00 | 2.4433 |     - |     - |      5 KB |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 1,153.5 ns | 18.08 ns |  16.02 ns | 1,152.3 ns |  1.25 |    0.02 | 2.4433 |     - |     - |      5 KB |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 1,319.6 ns | 13.53 ns |  12.66 ns | 1,318.4 ns |  1.43 |    0.02 | 2.5768 |     - |     - |      5 KB |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 1,410.6 ns | 10.35 ns |   8.64 ns | 1,409.6 ns |  1.53 |    0.01 | 3.5019 |     - |     - |      7 KB |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 2,723.9 ns | 36.04 ns |  33.71 ns | 2,720.2 ns |  2.95 |    0.04 | 2.4414 |     - |     - |      5 KB |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 1,248.5 ns |  3.02 ns |   2.83 ns | 1,248.3 ns |  1.35 |    0.01 | 1.1082 |     - |     - |      2 KB |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   885.9 ns |  5.73 ns |   5.08 ns |   883.7 ns |  0.96 |    0.01 | 1.0586 |     - |     - |      2 KB |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 1,120.6 ns |  3.49 ns |   3.09 ns | 1,120.4 ns |  1.21 |    0.01 | 1.0586 |     - |     - |      2 KB |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   903.4 ns |  3.82 ns |   3.38 ns |   902.2 ns |  0.98 |    0.01 | 1.0586 |     - |     - |      2 KB |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |   993.7 ns |  9.70 ns |   8.60 ns |   992.2 ns |  1.08 |    0.01 | 2.4433 |     - |     - |      5 KB |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 1,206.9 ns |  8.90 ns |   7.89 ns | 1,208.0 ns |  1.31 |    0.01 | 2.4433 |     - |     - |      5 KB |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 1,393.6 ns | 18.78 ns |  15.69 ns | 1,396.6 ns |  1.51 |    0.02 | 2.5768 |     - |     - |      5 KB |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 1,543.9 ns | 15.45 ns |  14.45 ns | 1,540.5 ns |  1.67 |    0.02 | 3.5019 |     - |     - |      7 KB |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 2,790.5 ns | 22.12 ns |  20.69 ns | 2,795.7 ns |  3.02 |    0.03 | 2.4414 |     - |     - |      5 KB |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 1,384.8 ns | 73.36 ns | 212.83 ns | 1,259.1 ns |  1.40 |    0.05 | 1.1082 |     - |     - |      2 KB |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   907.4 ns |  3.05 ns |   2.38 ns |   907.9 ns |  0.98 |    0.01 | 1.0586 |     - |     - |      2 KB |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 1,151.0 ns |  4.43 ns |   3.70 ns | 1,152.7 ns |  1.25 |    0.01 | 1.0586 |     - |     - |      2 KB |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   899.3 ns |  3.68 ns |   3.45 ns |   899.3 ns |  0.97 |    0.01 | 1.0586 |     - |     - |      2 KB |
