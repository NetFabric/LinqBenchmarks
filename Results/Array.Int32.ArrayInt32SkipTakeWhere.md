## Array.Int32.ArrayInt32SkipTakeWhere

### Source
[ArrayInt32SkipTakeWhere.cs](../LinqBenchmarks/Array/Int32/ArrayInt32SkipTakeWhere.cs)

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
|               Method |      Job |  Runtime | Skip | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |----- |------ |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 |    93.56 ns |  0.296 ns |  0.277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 | 2,397.39 ns | 12.236 ns | 11.445 ns | 25.62 |    0.13 | 0.0153 |     - |     - |      32 B |
|                 Linq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1,601.54 ns |  8.080 ns |  6.747 ns | 17.12 |    0.08 | 0.0725 |     - |     - |     152 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 | 1000 |   100 |   339.69 ns |  1.470 ns |  1.227 ns |  3.63 |    0.02 | 0.7191 |     - |     - |   1,504 B |
|               LinqAF | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3,052.26 ns | 18.361 ns | 16.276 ns | 32.62 |    0.20 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   329.75 ns |  3.398 ns |  3.178 ns |  3.52 |    0.04 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   164.60 ns |  0.579 ns |  0.452 ns |  1.76 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   258.03 ns |  2.114 ns |  1.977 ns |  2.76 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   199.51 ns |  1.259 ns |  1.052 ns |  2.13 |    0.01 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 |    94.83 ns |  1.438 ns |  1.201 ns |  1.01 |    0.01 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 | 2,652.65 ns |  9.183 ns |  7.668 ns | 28.35 |    0.11 | 0.0153 |     - |     - |      32 B |
|                 Linq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1,593.87 ns |  4.560 ns |  3.560 ns | 17.03 |    0.08 | 0.0725 |     - |     - |     152 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 | 1000 |   100 |   360.61 ns |  6.269 ns | 10.473 ns |  3.84 |    0.13 | 0.7191 |     - |     - |   1,504 B |
|               LinqAF | .NET 6.0 | .NET 6.0 | 1000 |   100 | 2,927.09 ns | 17.675 ns | 15.668 ns | 31.28 |    0.18 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   292.48 ns |  1.698 ns |  1.418 ns |  3.13 |    0.02 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   166.01 ns |  0.606 ns |  0.567 ns |  1.77 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   261.35 ns |  2.090 ns |  1.745 ns |  2.79 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   199.05 ns |  0.823 ns |  0.729 ns |  2.13 |    0.01 |      - |     - |     - |         - |
