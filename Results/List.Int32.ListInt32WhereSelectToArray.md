## List.Int32.ListInt32WhereSelectToArray

### Source
[ListInt32WhereSelectToArray.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelectToArray.cs)

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
|               Method |      Job |  Runtime | Count |       Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |-----------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   272.9 ns | 1.65 ns | 1.47 ns |  1.00 |    0.00 | 0.4244 |     - |     - |     888 B |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   422.3 ns | 3.13 ns | 2.78 ns |  1.55 |    0.01 | 0.4244 |     - |     - |     888 B |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 |   554.5 ns | 2.46 ns | 2.19 ns |  2.03 |    0.01 | 0.4015 |     - |     - |     840 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 |   477.6 ns | 2.10 ns | 1.86 ns |  1.75 |    0.01 | 0.4244 |     - |     - |     888 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 1,183.5 ns | 5.77 ns | 5.11 ns |  4.34 |    0.03 | 0.4082 |     - |     - |     856 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |   518.0 ns | 4.87 ns | 4.55 ns |  1.90 |    0.02 | 0.1602 |     - |     - |     336 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   278.5 ns | 1.04 ns | 0.97 ns |  1.02 |    0.01 | 0.1144 |     - |     - |     240 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |   573.7 ns | 3.80 ns | 3.37 ns |  2.10 |    0.01 | 0.1144 |     - |     - |     240 B |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   341.6 ns | 1.43 ns | 1.19 ns |  1.25 |    0.01 | 0.1144 |     - |     - |     240 B |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |   282.6 ns | 1.35 ns | 1.20 ns |  1.04 |    0.01 | 0.4244 |     - |     - |     888 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   281.5 ns | 2.28 ns | 1.90 ns |  1.03 |    0.01 | 0.4244 |     - |     - |     888 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 |   557.1 ns | 2.62 ns | 2.32 ns |  2.04 |    0.02 | 0.4015 |     - |     - |     840 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 |   478.5 ns | 3.79 ns | 3.17 ns |  1.75 |    0.02 | 0.4244 |     - |     - |     888 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 1,175.1 ns | 7.91 ns | 7.01 ns |  4.31 |    0.03 | 0.4082 |     - |     - |     856 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |   554.6 ns | 2.25 ns | 1.88 ns |  2.03 |    0.01 | 0.1602 |     - |     - |     336 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   291.4 ns | 1.16 ns | 1.02 ns |  1.07 |    0.01 | 0.1144 |     - |     - |     240 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |   606.0 ns | 2.90 ns | 2.57 ns |  2.22 |    0.02 | 0.1144 |     - |     - |     240 B |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   352.8 ns | 1.97 ns | 1.84 ns |  1.29 |    0.01 | 0.1144 |     - |     - |     240 B |
