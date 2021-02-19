## Array.Int32.ArrayInt32Where

### Source
[ArrayInt32Where.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Where.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |  67.98 ns | 1.364 ns | 1.956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |  78.72 ns | 0.407 ns | 0.340 ns |  1.14 |    0.04 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 495.06 ns | 3.769 ns | 3.148 ns |  7.15 |    0.23 | 0.0229 |     - |     - |      48 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 286.50 ns | 1.879 ns | 1.758 ns |  4.16 |    0.14 | 0.3171 |     - |     - |     664 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 394.16 ns | 2.810 ns | 2.347 ns |  5.70 |    0.19 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 269.96 ns | 0.945 ns | 0.838 ns |  3.91 |    0.12 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 189.04 ns | 0.831 ns | 0.737 ns |  2.74 |    0.08 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 254.45 ns | 1.615 ns | 1.349 ns |  3.68 |    0.12 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 195.50 ns | 0.472 ns | 0.369 ns |  2.82 |    0.09 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |  66.34 ns | 0.391 ns | 0.366 ns |  0.96 |    0.03 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |  66.32 ns | 0.201 ns | 0.168 ns |  0.96 |    0.03 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 467.87 ns | 2.910 ns | 2.272 ns |  6.75 |    0.23 | 0.0229 |     - |     - |      48 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 294.44 ns | 1.708 ns | 1.333 ns |  4.25 |    0.13 | 0.3171 |     - |     - |     664 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 383.30 ns | 2.626 ns | 2.328 ns |  5.55 |    0.17 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 298.93 ns | 4.452 ns | 3.947 ns |  4.33 |    0.17 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 165.53 ns | 0.717 ns | 0.635 ns |  2.40 |    0.07 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 265.23 ns | 2.718 ns | 2.542 ns |  3.85 |    0.12 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 200.20 ns | 0.930 ns | 0.776 ns |  2.89 |    0.08 |      - |     - |     - |         - |
