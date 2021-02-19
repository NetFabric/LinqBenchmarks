## List.ValueType.ListValueTypeWhere

### Source
[ListValueTypeWhere.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhere.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   500.6 ns |  1.60 ns |  1.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   709.4 ns |  3.07 ns |  2.87 ns |  1.42 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 1,265.1 ns | 12.03 ns | 11.25 ns |  2.52 |    0.02 | 0.0648 |     - |     - |     136 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 1,156.8 ns | 11.97 ns |  9.99 ns |  2.31 |    0.02 | 2.4433 |     - |     - |   5,112 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 1,608.3 ns | 14.59 ns | 12.94 ns |  3.21 |    0.03 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |   616.5 ns |  1.81 ns |  1.61 ns |  1.23 |    0.01 | 0.0191 |     - |     - |      40 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   527.7 ns |  1.56 ns |  1.38 ns |  1.05 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |   601.1 ns |  3.09 ns |  2.41 ns |  1.20 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   529.1 ns |  1.17 ns |  1.04 ns |  1.06 |    0.00 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |   505.4 ns |  2.79 ns |  2.47 ns |  1.01 |    0.01 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   716.5 ns |  2.24 ns |  1.87 ns |  1.43 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 1,249.7 ns |  7.26 ns |  6.44 ns |  2.50 |    0.02 | 0.0648 |     - |     - |     136 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 1,174.4 ns | 13.19 ns | 11.69 ns |  2.35 |    0.02 | 2.4433 |     - |     - |   5,112 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 1,582.5 ns | 18.31 ns | 16.23 ns |  3.16 |    0.03 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |   616.9 ns |  1.93 ns |  1.80 ns |  1.23 |    0.00 | 0.0191 |     - |     - |      40 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   526.7 ns |  1.17 ns |  0.97 ns |  1.05 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |   608.2 ns |  2.07 ns |  1.73 ns |  1.22 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   530.6 ns |  1.27 ns |  1.06 ns |  1.06 |    0.00 |      - |     - |     - |         - |
