﻿## Enumerable.Int32.EnumerableInt32Contains

### Source
[EnumerableInt32Contains.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Contains.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqFaster.SIMD: [1.1.2](https://www.nuget.org/packages/LinqFaster.SIMD/1.0.3)
- LinqFasterer: [2.1.0](https://www.nuget.org/packages/LinqFasterer/2.1.0)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- LinqOptimizer.CSharp: [0.7.0](https://www.nuget.org/packages/LinqOptimizer.CSharp/0.7.0)
- SpanLinq: [0.0.1](https://www.nuget.org/packages/SpanLinq/0.0.1)
- Streams.CSharp: [0.6.0](https://www.nuget.org/packages/Streams.CSharp/0.6.0)
- StructLinq.BCL: [0.26.0](https://www.nuget.org/packages/StructLinq/0.26.0)
- NetFabric.Hyperlinq: [3.0.0-beta44](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta44)
- System.Linq.Async: [5.0.0](https://www.nuget.org/packages/System.Linq.Async/5.0.0)

### Results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.985 (21H1/May2021Update)
Intel Core i7-7567U CPU 3.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.4.21227.6
  [Host] : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  .NET 6 : .NET 6.0.0 (6.0.21.22210), X64 RyuJIT

Job=.NET 6  EnvironmentVariables=COMPlus_ReadyToRun=0,COMPlus_TC_QuickJitForLoops=1,COMPlus_TieredPGO=1  Runtime=.NET 6.0  

```
|                   Method | Count |     Mean |   Error |  StdDev |        Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |------ |---------:|--------:|--------:|-------------:|--------:|-------:|------:|------:|----------:|
|              ForeachLoop |   100 | 240.3 ns | 3.56 ns | 3.16 ns |     baseline |         | 0.0191 |     - |     - |      40 B |
|                     Linq |   100 | 333.7 ns | 2.69 ns | 2.52 ns | 1.39x slower |   0.02x | 0.0191 |     - |     - |      40 B |
|                   LinqAF |   100 | 309.3 ns | 1.64 ns | 1.46 ns | 1.29x slower |   0.02x | 0.0191 |     - |     - |      40 B |
|               StructLinq |   100 | 389.2 ns | 2.18 ns | 1.93 ns | 1.62x slower |   0.02x | 0.0305 |     - |     - |      64 B |
| StructLinq_ValueDelegate |   100 | 379.0 ns | 3.08 ns | 2.73 ns | 1.58x slower |   0.02x | 0.0191 |     - |     - |      40 B |
|                Hyperlinq |   100 | 340.7 ns | 2.00 ns | 1.67 ns | 1.42x slower |   0.02x | 0.0191 |     - |     - |      40 B |
