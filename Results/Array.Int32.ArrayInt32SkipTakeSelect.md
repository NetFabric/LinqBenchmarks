## Array.Int32.ArrayInt32SkipTakeSelect

### Source
[ArrayInt32SkipTakeSelect.cs](../LinqBenchmarks/Array/Int32/ArrayInt32SkipTakeSelect.cs)

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
|                      Method |      Job |  Runtime | Skip | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |--------- |--------- |----- |------ |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 |    57.93 ns |  0.267 ns |  0.250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 | 2,621.07 ns |  8.591 ns |  8.036 ns | 45.25 |    0.22 | 0.0153 |     - |     - |      32 B |
|                        Linq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1,076.58 ns |  6.472 ns |  5.738 ns | 18.58 |    0.13 | 0.0725 |     - |     - |     152 B |
|                  LinqFaster | .NET 5.0 | .NET 5.0 | 1000 |   100 |   331.11 ns |  3.782 ns |  3.353 ns |  5.72 |    0.06 | 0.6080 |     - |     - |   1,272 B |
|                      LinqAF | .NET 5.0 | .NET 5.0 | 1000 |   100 | 2,674.57 ns | 12.910 ns | 11.444 ns | 46.17 |    0.28 |      - |     - |     - |         - |
|                  StructLinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   277.03 ns |  1.562 ns |  1.461 ns |  4.78 |    0.03 | 0.0458 |     - |     - |      96 B |
|        StructLinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   165.99 ns |  0.467 ns |  0.437 ns |  2.87 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 5.0 | .NET 5.0 | 1000 |   100 |   240.61 ns |  1.206 ns |  1.069 ns |  4.15 |    0.03 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   171.72 ns |  0.721 ns |  0.639 ns |  2.96 |    0.02 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 5.0 | .NET 5.0 | 1000 |   100 |   223.25 ns |  0.737 ns |  0.616 ns |  3.85 |    0.02 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |    90.84 ns |  0.487 ns |  0.455 ns |  1.57 |    0.01 |      - |     - |     - |         - |
|                     ForLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 |    58.03 ns |  0.240 ns |  0.200 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 | 2,611.90 ns | 20.925 ns | 19.573 ns | 45.09 |    0.36 | 0.0153 |     - |     - |      32 B |
|                        Linq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   977.05 ns |  4.946 ns |  4.626 ns | 16.87 |    0.10 | 0.0725 |     - |     - |     152 B |
|                  LinqFaster | .NET 6.0 | .NET 6.0 | 1000 |   100 |   319.12 ns |  4.867 ns |  4.553 ns |  5.51 |    0.08 | 0.6080 |     - |     - |   1,272 B |
|                      LinqAF | .NET 6.0 | .NET 6.0 | 1000 |   100 | 2,767.22 ns | 11.523 ns |  9.623 ns | 47.77 |    0.27 |      - |     - |     - |         - |
|                  StructLinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   264.52 ns |  0.930 ns |  0.824 ns |  4.57 |    0.02 | 0.0458 |     - |     - |      96 B |
|        StructLinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   174.88 ns |  0.401 ns |  0.335 ns |  3.02 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 6.0 | .NET 6.0 | 1000 |   100 |   208.66 ns |  1.160 ns |  1.085 ns |  3.60 |    0.02 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   167.60 ns |  0.685 ns |  0.607 ns |  2.89 |    0.01 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 6.0 | .NET 6.0 | 1000 |   100 |   222.56 ns |  0.724 ns |  0.604 ns |  3.84 |    0.02 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |    90.86 ns |  0.288 ns |  0.255 ns |  1.57 |    0.01 |      - |     - |     - |         - |
