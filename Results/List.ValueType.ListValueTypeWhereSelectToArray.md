## List.ValueType.ListValueTypeWhereSelectToArray

### Source
[ListValueTypeWhereSelectToArray.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelectToArray.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 | 1,072.9 ns |  9.78 ns |  8.67 ns |  1.00 |    0.00 | 3.4866 |     - |     - |      7 KB |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 1,285.1 ns |  5.51 ns |  4.30 ns |  1.20 |    0.01 | 3.4866 |     - |     - |      7 KB |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 1,376.5 ns | 14.11 ns | 12.51 ns |  1.28 |    0.02 | 2.5616 |     - |     - |      5 KB |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 1,399.2 ns |  9.40 ns |  8.33 ns |  1.30 |    0.01 | 3.4866 |     - |     - |      7 KB |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 2,760.0 ns | 27.30 ns | 25.54 ns |  2.57 |    0.03 | 3.4714 |     - |     - |      7 KB |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 1,216.2 ns |  4.44 ns |  3.47 ns |  1.13 |    0.01 | 1.0929 |     - |     - |      2 KB |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   874.9 ns |  4.45 ns |  3.94 ns |  0.82 |    0.01 | 1.0433 |     - |     - |      2 KB |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 1,135.7 ns |  3.08 ns |  2.58 ns |  1.06 |    0.01 | 1.0433 |     - |     - |      2 KB |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   906.2 ns |  4.77 ns |  3.99 ns |  0.84 |    0.01 | 1.0433 |     - |     - |      2 KB |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 | 1,139.4 ns |  7.49 ns |  7.00 ns |  1.06 |    0.01 | 3.4866 |     - |     - |      7 KB |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 1,342.2 ns |  7.53 ns |  7.05 ns |  1.25 |    0.01 | 3.4866 |     - |     - |      7 KB |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 1,400.3 ns | 13.79 ns | 11.52 ns |  1.30 |    0.02 | 2.5616 |     - |     - |      5 KB |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 1,476.6 ns | 21.69 ns | 20.29 ns |  1.37 |    0.02 | 3.4866 |     - |     - |      7 KB |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 2,898.9 ns | 26.00 ns | 24.32 ns |  2.70 |    0.03 | 3.4714 |     - |     - |      7 KB |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 1,254.8 ns |  8.39 ns |  7.85 ns |  1.17 |    0.01 | 1.0929 |     - |     - |      2 KB |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   907.5 ns |  5.53 ns |  4.90 ns |  0.85 |    0.01 | 1.0433 |     - |     - |      2 KB |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 1,131.2 ns |  8.47 ns |  7.51 ns |  1.05 |    0.01 | 1.0433 |     - |     - |      2 KB |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   890.8 ns |  6.60 ns |  5.51 ns |  0.83 |    0.01 | 1.0433 |     - |     - |      2 KB |
