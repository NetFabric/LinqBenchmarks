## Array.ValueType.ArrayValueTypeDistinct

### Source
[ArrayValueTypeDistinct.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeDistinct.cs)

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
|               Method |      Job |  Runtime | Duplicates | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |     Gen 0 | Gen 1 | Gen 2 |   Allocated |
|--------------------- |--------- |--------- |----------- |------ |-------------:|-----------:|-----------:|------:|--------:|----------:|------:|------:|------------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |          4 |   100 |   534.961 μs |  6.3957 μs |  5.3407 μs | 1.000 |    0.00 | 1095.7031 |     - |     - | 2,292,184 B |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |          4 |   100 |   534.362 μs |  2.0502 μs |  1.7120 μs | 0.999 |    0.01 | 1095.7031 |     - |     - | 2,292,184 B |
|                 Linq | .NET 5.0 | .NET 5.0 |          4 |   100 |   545.573 μs |  2.3323 μs |  2.1817 μs | 1.019 |    0.01 | 1092.7734 |     - |     - | 2,286,672 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |          4 |   100 | 1,728.387 μs | 10.1812 μs |  9.5235 μs | 3.232 |    0.03 | 2187.5000 |     - |     - | 4,575,075 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |          4 |   100 |   605.034 μs |  2.2084 μs |  1.8441 μs | 1.131 |    0.01 | 1086.9141 |     - |     - | 2,273,657 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |          4 |   100 |     4.462 μs |  0.0130 μs |  0.0108 μs | 0.008 |    0.00 |         - |     - |     - |           - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |          4 |   100 |   505.136 μs |  3.1941 μs |  2.9877 μs | 0.945 |    0.01 | 1045.8984 |     - |     - | 2,187,585 B |
|              ForLoop | .NET 6.0 | .NET 6.0 |          4 |   100 |   572.295 μs |  3.9842 μs |  3.5319 μs | 1.070 |    0.01 | 1095.7031 |     - |     - | 2,292,184 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |          4 |   100 |   551.703 μs |  3.0511 μs |  2.7047 μs | 1.032 |    0.01 | 1095.7031 |     - |     - | 2,292,184 B |
|                 Linq | .NET 6.0 | .NET 6.0 |          4 |   100 |   582.032 μs |  4.9751 μs |  4.4103 μs | 1.088 |    0.02 | 1092.7734 |     - |     - | 2,286,672 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |          4 |   100 | 1,735.135 μs | 11.9246 μs | 10.5708 μs | 3.240 |    0.03 | 2187.5000 |     - |     - | 4,575,074 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |          4 |   100 |   615.180 μs |  3.2563 μs |  2.8867 μs | 1.150 |    0.01 | 1086.9141 |     - |     - | 2,273,657 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |          4 |   100 |     4.488 μs |  0.0176 μs |  0.0156 μs | 0.008 |    0.00 |         - |     - |     - |           - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |          4 |   100 |   504.195 μs |  4.0431 μs |  3.5841 μs | 0.943 |    0.01 | 1045.8984 |     - |     - | 2,187,586 B |
