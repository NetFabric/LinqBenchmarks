## List.ValueType.ListValueTypeSelectSum

### Source
[ListValueTypeSelectSum.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSelectSum.cs)

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
|               Method |      Job |  Runtime | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   189.07 ns |  0.465 ns |  0.388 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   378.47 ns |  2.552 ns |  2.262 ns |  2.00 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 1,022.89 ns |  5.810 ns |  5.150 ns |  5.41 |    0.03 | 0.0343 |     - |     - |      72 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 |   287.93 ns |  0.883 ns |  0.826 ns |  1.52 |    0.01 |      - |     - |     - |         - |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 |   883.70 ns | 17.333 ns | 29.432 ns |  4.62 |    0.16 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |   230.42 ns |  1.401 ns |  1.170 ns |  1.22 |    0.01 | 0.0191 |     - |     - |      40 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |    83.17 ns |  0.260 ns |  0.230 ns |  0.44 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |   198.98 ns |  2.844 ns |  2.521 ns |  1.05 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |    68.74 ns |  0.255 ns |  0.238 ns |  0.36 |    0.00 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |   190.02 ns |  0.492 ns |  0.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   376.39 ns |  2.206 ns |  1.842 ns |  1.99 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 |   944.87 ns |  3.699 ns |  3.279 ns |  5.00 |    0.02 | 0.0343 |     - |     - |      72 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 |   322.65 ns |  1.268 ns |  1.124 ns |  1.71 |    0.01 |      - |     - |     - |         - |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 |   886.08 ns | 17.526 ns | 30.231 ns |  4.70 |    0.15 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |   232.19 ns |  1.697 ns |  1.587 ns |  1.23 |    0.01 | 0.0191 |     - |     - |      40 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |    83.57 ns |  0.338 ns |  0.300 ns |  0.44 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |   194.98 ns |  0.843 ns |  0.747 ns |  1.03 |    0.00 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |    68.36 ns |  0.354 ns |  0.296 ns |  0.36 |    0.00 |      - |     - |     - |         - |
