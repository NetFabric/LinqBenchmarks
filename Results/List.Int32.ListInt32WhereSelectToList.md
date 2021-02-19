## List.Int32.ListInt32WhereSelectToList

### Source
[ListInt32WhereSelectToList.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelectToList.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   288.7 ns |  1.53 ns |  1.43 ns |  1.00 |    0.00 | 0.3095 |     - |     - |     648 B |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   359.0 ns |  1.53 ns |  1.20 ns |  1.24 |    0.01 | 0.3095 |     - |     - |     648 B |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 |   543.1 ns |  7.16 ns |  5.98 ns |  1.88 |    0.02 | 0.3824 |     - |     - |     800 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 |   544.2 ns |  7.13 ns |  6.32 ns |  1.89 |    0.02 | 0.4396 |     - |     - |     920 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 1,169.4 ns |  5.51 ns |  4.30 ns |  4.05 |    0.02 | 0.3090 |     - |     - |     648 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |   539.5 ns |  5.30 ns |  4.43 ns |  1.87 |    0.01 | 0.1755 |     - |     - |     368 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   283.4 ns |  2.13 ns |  2.00 ns |  0.98 |    0.01 | 0.1297 |     - |     - |     272 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |   565.9 ns |  2.41 ns |  2.02 ns |  1.96 |    0.01 | 0.1297 |     - |     - |     272 B |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   347.9 ns |  1.65 ns |  1.46 ns |  1.21 |    0.00 | 0.1297 |     - |     - |     272 B |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |   256.3 ns |  2.26 ns |  1.88 ns |  0.89 |    0.01 | 0.3095 |     - |     - |     648 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   252.4 ns |  1.55 ns |  1.37 ns |  0.87 |    0.01 | 0.3095 |     - |     - |     648 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 |   494.1 ns |  3.81 ns |  3.38 ns |  1.71 |    0.01 | 0.3824 |     - |     - |     800 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 |   467.1 ns |  2.96 ns |  2.47 ns |  1.62 |    0.01 | 0.4396 |     - |     - |     920 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 1,152.7 ns | 17.48 ns | 16.35 ns |  3.99 |    0.06 | 0.3090 |     - |     - |     648 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |   558.7 ns |  1.91 ns |  1.69 ns |  1.94 |    0.01 | 0.1755 |     - |     - |     368 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   308.6 ns |  2.41 ns |  2.26 ns |  1.07 |    0.01 | 0.1297 |     - |     - |     272 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |   615.1 ns |  3.44 ns |  2.87 ns |  2.13 |    0.01 | 0.1297 |     - |     - |     272 B |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   355.7 ns |  2.79 ns |  2.47 ns |  1.23 |    0.01 | 0.1297 |     - |     - |     272 B |
