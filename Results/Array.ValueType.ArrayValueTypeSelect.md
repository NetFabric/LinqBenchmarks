## Array.ValueType.ArrayValueTypeSelect

### Source
[ArrayValueTypeSelect.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSelect.cs)

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
|                      Method |      Job |  Runtime | Count |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |--------- |--------- |------ |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                     ForLoop | .NET 5.0 | .NET 5.0 |   100 | 1.489 μs | 0.0023 μs | 0.0020 μs |  1.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 1.562 μs | 0.0049 μs | 0.0044 μs |  1.05 |      - |     - |     - |         - |
|                        Linq | .NET 5.0 | .NET 5.0 |   100 | 2.128 μs | 0.0029 μs | 0.0026 μs |  1.43 | 0.0381 |     - |     - |      80 B |
|                  LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 2.007 μs | 0.0121 μs | 0.0107 μs |  1.35 | 1.9226 |     - |     - |   4,024 B |
|                      LinqAF | .NET 5.0 | .NET 5.0 |   100 | 2.651 μs | 0.0042 μs | 0.0035 μs |  1.78 |      - |     - |     - |         - |
|                  StructLinq | .NET 5.0 | .NET 5.0 |   100 | 1.780 μs | 0.0049 μs | 0.0041 μs |  1.20 | 0.0153 |     - |     - |      32 B |
|        StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 1.552 μs | 0.0015 μs | 0.0013 μs |  1.04 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 5.0 | .NET 5.0 |   100 | 1.714 μs | 0.0045 μs | 0.0040 μs |  1.15 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 5.0 | .NET 5.0 |   100 | 1.553 μs | 0.0055 μs | 0.0051 μs |  1.04 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 5.0 | .NET 5.0 |   100 | 1.702 μs | 0.0044 μs | 0.0039 μs |  1.14 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | .NET 5.0 | .NET 5.0 |   100 | 1.544 μs | 0.0034 μs | 0.0028 μs |  1.04 |      - |     - |     - |         - |
|                     ForLoop | .NET 6.0 | .NET 6.0 |   100 | 1.506 μs | 0.0069 μs | 0.0061 μs |  1.01 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 1.608 μs | 0.0033 μs | 0.0030 μs |  1.08 |      - |     - |     - |         - |
|                        Linq | .NET 6.0 | .NET 6.0 |   100 | 2.125 μs | 0.0086 μs | 0.0071 μs |  1.43 | 0.0381 |     - |     - |      80 B |
|                  LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 2.014 μs | 0.0108 μs | 0.0101 μs |  1.35 | 1.9226 |     - |     - |   4,024 B |
|                      LinqAF | .NET 6.0 | .NET 6.0 |   100 | 2.551 μs | 0.0061 μs | 0.0057 μs |  1.71 |      - |     - |     - |         - |
|                  StructLinq | .NET 6.0 | .NET 6.0 |   100 | 1.824 μs | 0.0037 μs | 0.0033 μs |  1.22 | 0.0153 |     - |     - |      32 B |
|        StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 1.550 μs | 0.0035 μs | 0.0028 μs |  1.04 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 6.0 | .NET 6.0 |   100 | 1.704 μs | 0.0029 μs | 0.0024 μs |  1.14 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 6.0 | .NET 6.0 |   100 | 1.534 μs | 0.0026 μs | 0.0020 μs |  1.03 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 6.0 | .NET 6.0 |   100 | 1.684 μs | 0.0061 μs | 0.0054 μs |  1.13 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | .NET 6.0 | .NET 6.0 |   100 | 1.548 μs | 0.0023 μs | 0.0020 μs |  1.04 |      - |     - |     - |         - |
