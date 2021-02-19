## Array.ValueType.ArrayValueTypeSelectSum

### Source
[ArrayValueTypeSelectSum.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSelectSum.cs)

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
|               Method |      Job |  Runtime | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |  63.20 ns |  0.279 ns |  0.261 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 135.45 ns |  0.642 ns |  0.569 ns |  2.14 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 625.01 ns |  2.334 ns |  2.069 ns |  9.89 |    0.04 | 0.0153 |     - |     - |      32 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 264.79 ns |  0.683 ns |  0.605 ns |  4.19 |    0.02 |      - |     - |     - |         - |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 562.61 ns | 11.049 ns | 23.785 ns |  9.32 |    0.29 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 203.23 ns |  0.915 ns |  0.856 ns |  3.22 |    0.01 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |  74.10 ns |  0.216 ns |  0.180 ns |  1.17 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 193.60 ns |  0.568 ns |  0.503 ns |  3.06 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |  68.75 ns |  0.320 ns |  0.299 ns |  1.09 |    0.01 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |  66.20 ns |  0.280 ns |  0.262 ns |  1.05 |    0.01 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |  91.54 ns |  0.375 ns |  0.313 ns |  1.45 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 626.08 ns |  2.524 ns |  2.237 ns |  9.91 |    0.05 | 0.0153 |     - |     - |      32 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 240.97 ns |  0.942 ns |  0.881 ns |  3.81 |    0.02 |      - |     - |     - |         - |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 582.11 ns | 11.217 ns | 12.918 ns |  9.22 |    0.24 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 205.10 ns |  0.820 ns |  0.727 ns |  3.25 |    0.02 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |  74.07 ns |  0.137 ns |  0.121 ns |  1.17 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 171.85 ns |  0.878 ns |  0.821 ns |  2.72 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |  67.80 ns |  0.254 ns |  0.237 ns |  1.07 |    0.01 |      - |     - |     - |         - |
