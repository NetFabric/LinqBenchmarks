## Enumerable.Int32.EnumerableInt32Sum

### Source
[EnumerableInt32Sum.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Sum.cs)

### References:
- Cistern.ValueLinq: [0.1.14](https://www.nuget.org/packages/Cistern.ValueLinq/0.1.14)
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqFaster.SIMD: [1.1.2](https://www.nuget.org/packages/LinqFaster.SIMD/1.0.3)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- StructLinq.BCL: [0.25.3](https://www.nuget.org/packages/StructLinq.BCL/0.25.3)
- NetFabric.Hyperlinq: [3.0.0-beta44](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta44)

### Results:
``` ini

BenchmarkDotNet=v0.12.1.1527-nightly, OS=Windows 10.0.19043
Intel Core i7-7567U CPU 3.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.3.21202.5
  [Host] : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT
  .NET 5 : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT
  .NET 6 : .NET 6.0.0 (6.0.21.20104), X64 RyuJIT

EnvironmentVariables=COMPlus_ReadyToRun=0,COMPlus_TC_QuickJitForLoops=1,COMPlus_TieredPGO=1  

```
|               Method |    Job |  Runtime | Count |        Mean |      Error |     StdDev |      Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------- |--------- |------ |------------:|-----------:|-----------:|------------:|------:|--------:|-------:|------:|------:|----------:|
|          **ForeachLoop** | **.NET 5** | **.NET 5.0** |    **10** |    **66.82 ns** |   **1.353 ns** |   **1.448 ns** |    **66.41 ns** |  **1.00** |    **0.00** | **0.0191** |     **-** |     **-** |      **40 B** |
|                 Linq | .NET 5 | .NET 5.0 |    10 |    67.61 ns |   1.428 ns |   1.266 ns |    67.76 ns |  1.01 |    0.03 | 0.0191 |     - |     - |      40 B |
|               LinqAF | .NET 5 | .NET 5.0 |    10 |    85.63 ns |   1.397 ns |   1.238 ns |    85.44 ns |  1.28 |    0.03 | 0.0191 |     - |     - |      40 B |
|           StructLinq | .NET 5 | .NET 5.0 |    10 |    86.95 ns |   0.913 ns |   0.713 ns |    86.84 ns |  1.30 |    0.03 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 5 | .NET 5.0 |    10 |    69.51 ns |   0.802 ns |   0.711 ns |    69.36 ns |  1.04 |    0.03 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 5 | .NET 5.0 |    10 |    73.09 ns |   1.396 ns |   1.166 ns |    73.17 ns |  1.09 |    0.02 | 0.0191 |     - |     - |      40 B |
|                      |        |          |       |             |            |            |             |       |         |        |       |       |           |
|          ForeachLoop | .NET 6 | .NET 6.0 |    10 |    41.07 ns |   0.857 ns |   0.802 ns |    41.24 ns |  1.00 |    0.00 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 6 | .NET 6.0 |    10 |    39.96 ns |   0.714 ns |   0.633 ns |    39.93 ns |  0.97 |    0.02 | 0.0191 |     - |     - |      40 B |
|               LinqAF | .NET 6 | .NET 6.0 |    10 |    64.67 ns |   1.223 ns |   1.201 ns |    64.38 ns |  1.58 |    0.04 | 0.0191 |     - |     - |      40 B |
|           StructLinq | .NET 6 | .NET 6.0 |    10 |    61.85 ns |   0.842 ns |   0.747 ns |    61.77 ns |  1.51 |    0.03 | 0.0306 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 6 | .NET 6.0 |    10 |    46.02 ns |   0.959 ns |   0.850 ns |    45.90 ns |  1.12 |    0.03 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 6 | .NET 6.0 |    10 |    47.50 ns |   0.939 ns |   1.516 ns |    47.20 ns |  1.19 |    0.04 | 0.0191 |     - |     - |      40 B |
|                      |        |          |       |             |            |            |             |       |         |        |       |       |           |
|          **ForeachLoop** | **.NET 5** | **.NET 5.0** |  **1000** | **4,761.19 ns** |  **75.750 ns** |  **70.857 ns** | **4,763.44 ns** |  **1.00** |    **0.00** | **0.0153** |     **-** |     **-** |      **40 B** |
|                 Linq | .NET 5 | .NET 5.0 |  1000 | 4,735.78 ns |  65.318 ns |  57.903 ns | 4,734.70 ns |  1.00 |    0.02 | 0.0153 |     - |     - |      40 B |
|               LinqAF | .NET 5 | .NET 5.0 |  1000 | 5,048.05 ns |  78.661 ns | 165.923 ns | 5,000.05 ns |  1.06 |    0.05 | 0.0153 |     - |     - |      40 B |
|           StructLinq | .NET 5 | .NET 5.0 |  1000 | 4,994.95 ns |  88.012 ns |  82.327 ns | 4,973.49 ns |  1.05 |    0.03 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 5 | .NET 5.0 |  1000 | 5,000.14 ns |  71.180 ns |  66.582 ns | 4,983.81 ns |  1.05 |    0.02 | 0.0153 |     - |     - |      40 B |
|            Hyperlinq | .NET 5 | .NET 5.0 |  1000 | 4,739.56 ns |  93.896 ns | 108.131 ns | 4,704.29 ns |  1.00 |    0.03 | 0.0153 |     - |     - |      40 B |
|                      |        |          |       |             |            |            |             |       |         |        |       |       |           |
|          ForeachLoop | .NET 6 | .NET 6.0 |  1000 | 3,042.41 ns |  59.615 ns |  61.221 ns | 3,025.08 ns |  1.00 |    0.00 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 6 | .NET 6.0 |  1000 | 2,039.27 ns |  40.550 ns |  71.020 ns | 2,034.43 ns |  0.68 |    0.03 | 0.0191 |     - |     - |      40 B |
|               LinqAF | .NET 6 | .NET 6.0 |  1000 | 3,574.53 ns |  30.604 ns |  27.129 ns | 3,567.77 ns |  1.18 |    0.03 | 0.0153 |     - |     - |      40 B |
|           StructLinq | .NET 6 | .NET 6.0 |  1000 | 2,488.87 ns |  19.093 ns |  17.860 ns | 2,489.73 ns |  0.82 |    0.02 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 6 | .NET 6.0 |  1000 | 3,537.51 ns | 194.432 ns | 573.287 ns | 3,270.96 ns |  1.32 |    0.23 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 6 | .NET 6.0 |  1000 | 2,482.16 ns |  40.765 ns |  31.827 ns | 2,474.16 ns |  0.81 |    0.02 | 0.0191 |     - |     - |      40 B |
