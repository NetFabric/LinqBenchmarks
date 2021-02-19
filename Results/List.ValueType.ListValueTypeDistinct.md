## List.ValueType.ListValueTypeDistinct

### Source
[ListValueTypeDistinct.cs](../LinqBenchmarks/List/ValueType/ListValueTypeDistinct.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |          4 |   100 |   526.939 μs |  4.2414 μs |  3.7599 μs | 1.000 |    0.00 | 1095.7031 |     - |     - | 2,292,184 B |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |          4 |   100 |   524.982 μs |  2.0251 μs |  1.8943 μs | 0.996 |    0.01 | 1095.7031 |     - |     - | 2,292,184 B |
|                 Linq | .NET 5.0 | .NET 5.0 |          4 |   100 |   548.413 μs |  3.4998 μs |  3.1025 μs | 1.041 |    0.01 | 1092.7734 |     - |     - | 2,286,712 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |          4 |   100 |     2.246 μs |  0.0059 μs |  0.0049 μs | 0.004 |    0.00 |    0.0114 |     - |     - |        24 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |          4 |   100 | 1,730.251 μs | 29.6106 μs | 26.2490 μs | 3.284 |    0.04 | 2187.5000 |     - |     - | 4,575,073 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |          4 |   100 |   592.116 μs |  4.3688 μs |  3.4109 μs | 1.125 |    0.01 | 1086.9141 |     - |     - | 2,273,665 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |          4 |   100 |     4.567 μs |  0.0097 μs |  0.0076 μs | 0.009 |    0.00 |         - |     - |     - |           - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |          4 |   100 |   497.933 μs |  2.7076 μs |  2.4002 μs | 0.945 |    0.01 | 1045.8984 |     - |     - | 2,187,585 B |
|              ForLoop | .NET 6.0 | .NET 6.0 |          4 |   100 |   556.782 μs |  5.0546 μs |  4.4808 μs | 1.057 |    0.01 | 1095.7031 |     - |     - | 2,292,185 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |          4 |   100 |   568.816 μs |  4.3985 μs |  3.6729 μs | 1.080 |    0.01 | 1095.7031 |     - |     - | 2,292,184 B |
|                 Linq | .NET 6.0 | .NET 6.0 |          4 |   100 |   560.309 μs |  4.7166 μs |  4.1811 μs | 1.063 |    0.01 | 1092.7734 |     - |     - | 2,286,712 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |          4 |   100 |     2.287 μs |  0.0140 μs |  0.0131 μs | 0.004 |    0.00 |    0.0114 |     - |     - |        24 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |          4 |   100 | 1,778.279 μs | 11.5936 μs | 10.8447 μs | 3.375 |    0.03 | 2187.5000 |     - |     - | 4,575,076 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |          4 |   100 |   613.511 μs | 11.2111 μs | 10.4869 μs | 1.164 |    0.02 | 1086.9141 |     - |     - | 2,273,665 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |          4 |   100 |     5.001 μs |  0.0238 μs |  0.0211 μs | 0.009 |    0.00 |         - |     - |     - |           - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |          4 |   100 |   511.330 μs |  4.7125 μs |  3.9352 μs | 0.971 |    0.01 | 1045.8984 |     - |     - | 2,187,585 B |
