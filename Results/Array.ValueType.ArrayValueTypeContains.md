﻿## Array.ValueType.ArrayValueTypeContains

### Source
[ArrayValueTypeContains.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeContains.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqFaster.SIMD: [1.1.2](https://www.nuget.org/packages/LinqFaster.SIMD/1.0.3)
- LinqFasterer: [2.1.0](https://www.nuget.org/packages/LinqFasterer/2.1.0)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- LinqOptimizer.CSharp: [](https://www.nuget.org/packages/LinqOptimizer.CSharp/)
- Streams.CSharp: [0.6.0](https://www.nuget.org/packages/Streams.CSharp/0.6.0)
- StructLinq.BCL: [0.26.0](https://www.nuget.org/packages/StructLinq/0.26.0)
- NetFabric.Hyperlinq: [3.0.0-beta44](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta44)

### Results:
``` ini

BenchmarkDotNet=v0.12.1.1527-nightly, OS=Windows 10.0.19043
Intel Core i7-7567U CPU 3.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.4.21227.6
  [Host] : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT
  .NET 6 : .NET 6.0.0 (6.0.21.22210), X64 RyuJIT

Job=.NET 6  EnvironmentVariables=COMPlus_ReadyToRun=0,COMPlus_TC_QuickJitForLoops=1,COMPlus_TieredPGO=1  Runtime=.NET 6.0  

```
|                   Method | Count |     Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |------ |---------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|                  ForLoop |   100 | 455.9 ns | 2.22 ns | 1.73 ns |  1.00 |      - |     - |     - |         - |
|              ForeachLoop |   100 | 463.7 ns | 1.76 ns | 1.56 ns |  1.02 |      - |     - |     - |         - |
|                     Linq |   100 | 171.3 ns | 0.50 ns | 0.42 ns |  0.38 |      - |     - |     - |         - |
|               LinqFaster |   100 | 177.0 ns | 1.45 ns | 1.28 ns |  0.39 |      - |     - |     - |         - |
|             LinqFasterer |   100 | 197.6 ns | 0.86 ns | 0.76 ns |  0.43 |      - |     - |     - |         - |
|                   LinqAF |   100 | 180.3 ns | 0.72 ns | 0.63 ns |  0.40 |      - |     - |     - |         - |
|               StructLinq |   100 | 519.4 ns | 2.35 ns | 2.20 ns |  1.14 | 0.0153 |     - |     - |      32 B |
| StructLinq_ValueDelegate |   100 | 495.0 ns | 1.51 ns | 2.81 ns |  1.09 |      - |     - |     - |         - |
|                Hyperlinq |   100 | 196.6 ns | 0.86 ns | 0.76 ns |  0.43 |      - |     - |     - |         - |