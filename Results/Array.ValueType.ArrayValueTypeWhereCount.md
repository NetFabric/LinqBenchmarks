## Array.ValueType.ArrayValueTypeWhereCount

### Source
[ArrayValueTypeWhereCount.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereCount.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |  69.17 ns |  0.565 ns |  0.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |  91.14 ns |  0.283 ns |  0.221 ns |  1.32 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 760.77 ns |  5.473 ns |  4.273 ns | 11.00 |    0.12 | 0.0153 |     - |     - |      32 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 275.71 ns |  1.627 ns |  1.270 ns |  3.99 |    0.03 |      - |     - |     - |         - |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 969.85 ns |  8.644 ns |  8.085 ns | 14.02 |    0.19 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 283.43 ns |  0.724 ns |  0.565 ns |  4.10 |    0.03 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 173.69 ns |  0.856 ns |  0.669 ns |  2.51 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 195.49 ns |  0.719 ns |  0.600 ns |  2.83 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 113.22 ns |  0.345 ns |  0.288 ns |  1.64 |    0.01 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |  67.86 ns |  0.316 ns |  0.247 ns |  0.98 |    0.01 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |  93.06 ns |  0.413 ns |  0.345 ns |  1.35 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 748.18 ns |  7.727 ns |  6.849 ns | 10.82 |    0.15 | 0.0153 |     - |     - |      32 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 269.46 ns |  1.035 ns |  0.864 ns |  3.90 |    0.03 |      - |     - |     - |         - |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 572.21 ns | 10.748 ns | 15.755 ns |  8.21 |    0.20 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 356.37 ns |  0.770 ns |  0.601 ns |  5.15 |    0.03 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 173.30 ns |  0.767 ns |  0.680 ns |  2.50 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 217.45 ns |  0.775 ns |  0.687 ns |  3.14 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |  90.60 ns |  0.255 ns |  0.226 ns |  1.31 |    0.01 |      - |     - |     - |         - |
