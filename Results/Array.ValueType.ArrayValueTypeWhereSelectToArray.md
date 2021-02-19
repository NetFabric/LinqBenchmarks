## Array.ValueType.ArrayValueTypeWhereSelectToArray

### Source
[ArrayValueTypeWhereSelectToArray.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelectToArray.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   989.8 ns |  6.47 ns |  6.05 ns |  1.00 |    0.00 | 3.4866 |     - |     - |      7 KB |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 1,063.5 ns | 10.04 ns |  8.90 ns |  1.08 |    0.01 | 3.4866 |     - |     - |      7 KB |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 1,309.9 ns | 10.42 ns |  9.24 ns |  1.32 |    0.01 | 2.5082 |     - |     - |      5 KB |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 1,056.3 ns |  9.68 ns |  9.06 ns |  1.07 |    0.01 | 2.9659 |     - |     - |      6 KB |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 2,198.9 ns | 41.99 ns | 39.28 ns |  2.22 |    0.05 | 3.4714 |     - |     - |      7 KB |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 1,255.3 ns |  7.25 ns |  6.43 ns |  1.27 |    0.01 | 1.0891 |     - |     - |      2 KB |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   883.9 ns |  5.27 ns |  4.93 ns |  0.89 |    0.01 | 1.0433 |     - |     - |      2 KB |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 1,112.3 ns |  9.34 ns |  7.29 ns |  1.13 |    0.01 | 1.0433 |     - |     - |      2 KB |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   879.1 ns |  4.12 ns |  3.44 ns |  0.89 |    0.01 | 1.0433 |     - |     - |      2 KB |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 | 1,061.7 ns |  3.92 ns |  3.48 ns |  1.07 |    0.01 | 3.4866 |     - |     - |      7 KB |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 1,128.3 ns | 15.11 ns | 13.39 ns |  1.14 |    0.02 | 3.4866 |     - |     - |      7 KB |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 1,346.9 ns |  6.16 ns |  4.81 ns |  1.36 |    0.01 | 2.5082 |     - |     - |      5 KB |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 1,139.8 ns |  7.73 ns |  6.85 ns |  1.15 |    0.01 | 2.9659 |     - |     - |      6 KB |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 2,266.4 ns | 32.31 ns | 30.23 ns |  2.29 |    0.04 | 3.4714 |     - |     - |      7 KB |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 1,283.4 ns | 15.74 ns | 14.73 ns |  1.30 |    0.02 | 1.0891 |     - |     - |      2 KB |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   895.6 ns |  6.03 ns |  5.64 ns |  0.90 |    0.01 | 1.0433 |     - |     - |      2 KB |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 1,123.8 ns |  5.15 ns |  4.57 ns |  1.14 |    0.01 | 1.0433 |     - |     - |      2 KB |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   889.0 ns | 17.47 ns | 13.64 ns |  0.90 |    0.02 | 1.0433 |     - |     - |      2 KB |
