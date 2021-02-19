## List.ValueType.ListValueTypeSkipTakeWhere

### Source
[ListValueTypeSkipTakeWhere.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSkipTakeWhere.cs)

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
|               Method |      Job |  Runtime | Skip | Count |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |----- |------ |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 |   494.8 ns |   1.90 ns |   1.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 | 5,362.5 ns |  33.44 ns |  26.10 ns | 10.83 |    0.08 | 0.0305 |     - |     - |      72 B |
|                 Linq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1,865.7 ns |   8.60 ns |   7.18 ns |  3.77 |    0.02 | 0.1183 |     - |     - |     248 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 | 1000 |   100 | 2,366.4 ns |  25.75 ns |  22.83 ns |  4.78 |    0.05 | 6.3133 |     - |     - |  13,224 B |
|               LinqAF | .NET 5.0 | .NET 5.0 | 1000 |   100 | 9,284.4 ns |  31.50 ns |  27.93 ns | 18.76 |    0.08 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   656.3 ns |   3.05 ns |   2.55 ns |  1.33 |    0.01 | 0.0572 |     - |     - |     120 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   521.8 ns |   1.38 ns |   1.15 ns |  1.05 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   581.1 ns |   3.18 ns |   2.65 ns |  1.17 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   492.4 ns |   2.27 ns |   2.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 |   479.6 ns |   1.18 ns |   0.98 ns |  0.97 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 | 5,306.7 ns |  28.94 ns |  25.66 ns | 10.72 |    0.06 | 0.0305 |     - |     - |      72 B |
|                 Linq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1,896.0 ns |   7.00 ns |   6.54 ns |  3.83 |    0.02 | 0.1183 |     - |     - |     248 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 | 1000 |   100 | 2,479.5 ns |  35.00 ns |  31.02 ns |  5.01 |    0.07 | 6.3133 |     - |     - |  13,224 B |
|               LinqAF | .NET 6.0 | .NET 6.0 | 1000 |   100 | 9,170.6 ns | 181.26 ns | 169.55 ns | 18.51 |    0.37 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   657.6 ns |   1.55 ns |   1.30 ns |  1.33 |    0.00 | 0.0572 |     - |     - |     120 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   520.2 ns |   0.98 ns |   0.77 ns |  1.05 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   580.9 ns |   2.44 ns |   2.16 ns |  1.17 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   508.7 ns |   2.11 ns |   1.87 ns |  1.03 |    0.01 |      - |     - |     - |         - |
