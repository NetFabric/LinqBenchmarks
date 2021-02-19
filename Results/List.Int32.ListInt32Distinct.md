## List.Int32.ListInt32Distinct

### Source
[ListInt32Distinct.cs](../LinqBenchmarks/List/Int32/ListInt32Distinct.cs)

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
|               Method |      Job |  Runtime | Duplicates | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |----------- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |          4 |   100 | 3,287.3 ns | 10.53 ns |  9.34 ns |  1.00 |    0.00 | 2.8687 |     - |     - |   6,008 B |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |          4 |   100 | 3,866.0 ns | 21.58 ns | 19.13 ns |  1.18 |    0.01 | 2.8687 |     - |     - |   6,008 B |
|                 Linq | .NET 5.0 | .NET 5.0 |          4 |   100 | 7,417.8 ns | 42.06 ns | 37.29 ns |  2.26 |    0.02 | 2.0599 |     - |     - |   4,320 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |          4 |   100 |   740.6 ns |  7.80 ns |  6.91 ns |  0.23 |    0.00 |      - |     - |     - |         - |
|               LinqAF | .NET 5.0 | .NET 5.0 |          4 |   100 | 9,527.5 ns | 65.92 ns | 55.04 ns |  2.90 |    0.02 | 5.9204 |     - |     - |  12,400 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |          4 |   100 | 3,520.8 ns | 12.32 ns | 10.29 ns |  1.07 |    0.01 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |          4 |   100 | 3,519.3 ns | 14.16 ns | 12.56 ns |  1.07 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |          4 |   100 | 3,847.5 ns | 27.10 ns | 22.63 ns |  1.17 |    0.01 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |          4 |   100 | 3,422.7 ns | 23.73 ns | 21.04 ns |  1.04 |    0.01 | 2.8687 |     - |     - |   6,008 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |          4 |   100 | 3,402.3 ns | 19.18 ns | 16.01 ns |  1.03 |    0.01 | 2.8687 |     - |     - |   6,008 B |
|                 Linq | .NET 6.0 | .NET 6.0 |          4 |   100 | 7,306.2 ns | 31.37 ns | 27.81 ns |  2.22 |    0.01 | 2.0599 |     - |     - |   4,320 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |          4 |   100 |   790.5 ns |  4.23 ns |  3.75 ns |  0.24 |    0.00 |      - |     - |     - |         - |
|               LinqAF | .NET 6.0 | .NET 6.0 |          4 |   100 | 9,503.6 ns | 35.91 ns | 31.84 ns |  2.89 |    0.01 | 5.9204 |     - |     - |  12,400 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |          4 |   100 | 3,461.4 ns | 34.27 ns | 32.05 ns |  1.05 |    0.01 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |          4 |   100 | 3,459.5 ns |  8.93 ns |  7.46 ns |  1.05 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |          4 |   100 | 3,825.9 ns | 24.90 ns | 22.07 ns |  1.16 |    0.01 |      - |     - |     - |         - |
