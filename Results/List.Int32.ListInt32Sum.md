## List.Int32.ListInt32Sum

### Source
[ListInt32Sum.cs](../LinqBenchmarks/List/Int32/ListInt32Sum.cs)

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
|               Method |      Job |  Runtime | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 | 137.54 ns | 0.829 ns | 0.776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 297.22 ns | 1.183 ns | 1.107 ns |  2.16 |    0.02 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 635.61 ns | 2.527 ns | 2.363 ns |  4.62 |    0.03 | 0.0191 |     - |     - |      40 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 651.56 ns | 2.936 ns | 2.603 ns |  4.74 |    0.03 | 0.0191 |     - |     - |      40 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 475.58 ns | 2.700 ns | 2.526 ns |  3.46 |    0.03 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |  81.68 ns | 0.234 ns | 0.208 ns |  0.59 |    0.00 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |  64.25 ns | 0.578 ns | 0.512 ns |  0.47 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |  22.03 ns | 0.224 ns | 0.199 ns |  0.16 |    0.00 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 | 104.55 ns | 0.529 ns | 0.469 ns |  0.76 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 138.74 ns | 0.484 ns | 0.453 ns |  1.01 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 658.48 ns | 2.962 ns | 2.625 ns |  4.79 |    0.04 | 0.0191 |     - |     - |      40 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 658.84 ns | 2.107 ns | 1.868 ns |  4.79 |    0.03 | 0.0191 |     - |     - |      40 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 501.57 ns | 2.596 ns | 2.301 ns |  3.65 |    0.03 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |  82.56 ns | 0.209 ns | 0.185 ns |  0.60 |    0.00 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |  63.69 ns | 0.228 ns | 0.213 ns |  0.46 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |  15.95 ns | 0.085 ns | 0.075 ns |  0.12 |    0.00 |      - |     - |     - |         - |
