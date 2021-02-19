## List.Int32.ListInt32SelectToList

### Source
[ListInt32SelectToList.cs](../LinqBenchmarks/List/Int32/ListInt32SelectToList.cs)

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
|                   Method |      Job |  Runtime | Count |        Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |--------- |--------- |------ |------------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                  ForLoop | .NET 5.0 | .NET 5.0 |   100 |   299.56 ns | 3.531 ns | 3.303 ns |  1.00 |    0.00 | 0.5660 |     - |     - |   1,184 B |
|              ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   499.15 ns | 3.074 ns | 2.876 ns |  1.67 |    0.02 | 0.5655 |     - |     - |   1,184 B |
|                     Linq | .NET 5.0 | .NET 5.0 |   100 |   316.15 ns | 1.486 ns | 1.318 ns |  1.06 |    0.01 | 0.2522 |     - |     - |     528 B |
|               LinqFaster | .NET 5.0 | .NET 5.0 |   100 |   342.58 ns | 1.774 ns | 1.481 ns |  1.14 |    0.01 | 0.4358 |     - |     - |     912 B |
|                   LinqAF | .NET 5.0 | .NET 5.0 |   100 | 1,045.87 ns | 6.920 ns | 6.134 ns |  3.49 |    0.04 | 0.5646 |     - |     - |   1,184 B |
|               StructLinq | .NET 5.0 | .NET 5.0 |   100 |   271.30 ns | 1.429 ns | 1.337 ns |  0.91 |    0.01 | 0.2484 |     - |     - |     520 B |
|     StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   131.38 ns | 0.802 ns | 0.670 ns |  0.44 |    0.01 | 0.2370 |     - |     - |     496 B |
|                Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |   233.48 ns | 1.547 ns | 1.372 ns |  0.78 |    0.01 | 0.2179 |     - |     - |     456 B |
|      Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   107.14 ns | 0.493 ns | 0.411 ns |  0.36 |    0.00 | 0.2180 |     - |     - |     456 B |
|           Hyperlinq_SIMD | .NET 5.0 | .NET 5.0 |   100 |    91.27 ns | 1.282 ns | 1.137 ns |  0.30 |    0.00 | 0.2180 |     - |     - |     456 B |
| Hyperlinq_IFunction_SIMD | .NET 5.0 | .NET 5.0 |   100 |    55.42 ns | 0.255 ns | 0.239 ns |  0.19 |    0.00 | 0.2180 |     - |     - |     456 B |
|                  ForLoop | .NET 6.0 | .NET 6.0 |   100 |   376.27 ns | 2.353 ns | 2.085 ns |  1.26 |    0.01 | 0.5660 |     - |     - |   1,184 B |
|              ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   345.33 ns | 2.265 ns | 2.008 ns |  1.15 |    0.01 | 0.5660 |     - |     - |   1,184 B |
|                     Linq | .NET 6.0 | .NET 6.0 |   100 |   309.68 ns | 1.419 ns | 1.258 ns |  1.03 |    0.01 | 0.2522 |     - |     - |     528 B |
|               LinqFaster | .NET 6.0 | .NET 6.0 |   100 |   335.06 ns | 2.485 ns | 2.075 ns |  1.12 |    0.01 | 0.4358 |     - |     - |     912 B |
|                   LinqAF | .NET 6.0 | .NET 6.0 |   100 | 1,062.90 ns | 8.711 ns | 7.722 ns |  3.55 |    0.05 | 0.5646 |     - |     - |   1,184 B |
|               StructLinq | .NET 6.0 | .NET 6.0 |   100 |   278.72 ns | 2.004 ns | 1.777 ns |  0.93 |    0.01 | 0.2484 |     - |     - |     520 B |
|     StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   139.99 ns | 1.135 ns | 0.948 ns |  0.47 |    0.01 | 0.2370 |     - |     - |     496 B |
|                Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |   258.64 ns | 1.303 ns | 1.088 ns |  0.86 |    0.01 | 0.2179 |     - |     - |     456 B |
|      Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   112.82 ns | 1.356 ns | 1.268 ns |  0.38 |    0.01 | 0.2180 |     - |     - |     456 B |
|           Hyperlinq_SIMD | .NET 6.0 | .NET 6.0 |   100 |   275.16 ns | 1.420 ns | 1.259 ns |  0.92 |    0.01 | 0.2179 |     - |     - |     456 B |
| Hyperlinq_IFunction_SIMD | .NET 6.0 | .NET 6.0 |   100 |   149.47 ns | 1.085 ns | 1.015 ns |  0.50 |    0.01 | 0.2179 |     - |     - |     456 B |
