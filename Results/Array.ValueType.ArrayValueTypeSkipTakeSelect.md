## Array.ValueType.ArrayValueTypeSkipTakeSelect

### Source
[ArrayValueTypeSkipTakeSelect.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSkipTakeSelect.cs)

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
|                      Method |      Job |  Runtime | Skip | Count |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |--------- |--------- |----- |------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1.534 μs | 0.0042 μs | 0.0040 μs |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 | 4.070 μs | 0.0210 μs | 0.0196 μs |  2.65 |    0.02 | 0.0153 |     - |     - |      32 B |
|                        Linq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 2.535 μs | 0.0119 μs | 0.0100 μs |  1.65 |    0.01 | 0.1183 |     - |     - |     248 B |
|                  LinqFaster | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.076 μs | 0.0152 μs | 0.0143 μs |  2.01 |    0.01 | 5.7678 |     - |     - |  12,072 B |
|                      LinqAF | .NET 5.0 | .NET 5.0 | 1000 |   100 | 6.484 μs | 0.0587 μs | 0.0491 μs |  4.23 |    0.03 |      - |     - |     - |         - |
|                  StructLinq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1.814 μs | 0.0030 μs | 0.0025 μs |  1.18 |    0.00 | 0.0458 |     - |     - |      96 B |
|        StructLinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1.553 μs | 0.0039 μs | 0.0030 μs |  1.01 |    0.00 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1.709 μs | 0.0062 μs | 0.0058 μs |  1.11 |    0.00 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1.638 μs | 0.0035 μs | 0.0031 μs |  1.07 |    0.00 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1.684 μs | 0.0040 μs | 0.0037 μs |  1.10 |    0.00 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1.613 μs | 0.0035 μs | 0.0031 μs |  1.05 |    0.00 |      - |     - |     - |         - |
|                     ForLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1.502 μs | 0.0037 μs | 0.0031 μs |  0.98 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 | 4.101 μs | 0.0285 μs | 0.0253 μs |  2.67 |    0.01 | 0.0153 |     - |     - |      32 B |
|                        Linq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.267 μs | 0.0147 μs | 0.0131 μs |  2.13 |    0.01 | 0.1183 |     - |     - |     248 B |
|                  LinqFaster | .NET 6.0 | .NET 6.0 | 1000 |   100 | 2.571 μs | 0.0161 μs | 0.0143 μs |  1.68 |    0.01 | 5.7678 |     - |     - |  12,072 B |
|                      LinqAF | .NET 6.0 | .NET 6.0 | 1000 |   100 | 7.522 μs | 0.0177 μs | 0.0139 μs |  4.91 |    0.01 |      - |     - |     - |         - |
|                  StructLinq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1.868 μs | 0.0044 μs | 0.0039 μs |  1.22 |    0.00 | 0.0458 |     - |     - |      96 B |
|        StructLinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1.555 μs | 0.0037 μs | 0.0031 μs |  1.01 |    0.00 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1.723 μs | 0.0072 μs | 0.0067 μs |  1.12 |    0.00 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1.624 μs | 0.0032 μs | 0.0027 μs |  1.06 |    0.00 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1.679 μs | 0.0059 μs | 0.0053 μs |  1.09 |    0.01 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1.642 μs | 0.0062 μs | 0.0055 μs |  1.07 |    0.00 |      - |     - |     - |         - |
