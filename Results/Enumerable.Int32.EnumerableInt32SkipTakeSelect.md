﻿## Enumerable.Int32.EnumerableInt32SkipTakeSelect

### Source
[EnumerableInt32SkipTakeSelect.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32SkipTakeSelect.cs)

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
|                   Method | Skip | Count |      Mean |     Error |    StdDev |         Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |----- |------ |----------:|----------:|----------:|--------------:|--------:|--------:|------:|------:|----------:|
|                     Linq | 1000 |   100 |  3.805 μs | 0.0379 μs | 0.0316 μs |      baseline |         |  0.0992 |     - |     - |     208 B |
|                   LinqAF | 1000 |   100 |  3.527 μs | 0.0277 μs | 0.0232 μs |  1.08x faster |   0.01x |  0.0191 |     - |     - |      40 B |
|            LinqOptimizer | 1000 |   100 | 53.609 μs | 0.5157 μs | 1.2053 μs | 14.27x slower |   0.47x | 15.5640 |     - |     - |  32,618 B |
|                  Streams | 1000 |   100 |  8.937 μs | 0.0870 μs | 0.0679 μs |  2.35x slower |   0.02x |  0.4272 |     - |     - |     920 B |
|               StructLinq | 1000 |   100 |  2.804 μs | 0.0234 μs | 0.0195 μs |  1.36x faster |   0.02x |  0.0610 |     - |     - |     128 B |
| StructLinq_ValueDelegate | 1000 |   100 |  3.502 μs | 0.0354 μs | 0.0314 μs |  1.09x faster |   0.01x |  0.0191 |     - |     - |      40 B |
|                Hyperlinq | 1000 |   100 |  2.663 μs | 0.0195 μs | 0.0182 μs |  1.43x faster |   0.01x |  0.0191 |     - |     - |      40 B |
|  Hyperlinq_ValueDelegate | 1000 |   100 |  2.552 μs | 0.0193 μs | 0.0171 μs |  1.49x faster |   0.01x |  0.0191 |     - |     - |      40 B |
