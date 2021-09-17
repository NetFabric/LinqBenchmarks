﻿## AsyncEnumerable.Int32.AsyncEnumerableInt32WhereSelectToArrayAsync

### Source
[AsyncEnumerableInt32WhereSelectToArrayAsync.cs](../LinqBenchmarks/AsyncEnumerable/Int32/AsyncEnumerableInt32WhereSelectToArrayAsync.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqFaster.SIMD: [1.1.2](https://www.nuget.org/packages/LinqFaster.SIMD/1.0.3)
- LinqFasterer: [2.1.0](https://www.nuget.org/packages/LinqFasterer/2.1.0)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- LinqOptimizer.CSharp: [0.7.0](https://www.nuget.org/packages/LinqOptimizer.CSharp/0.7.0)
- SpanLinq: [0.0.1](https://www.nuget.org/packages/SpanLinq/0.0.1)
- Streams.CSharp: [0.6.0](https://www.nuget.org/packages/Streams.CSharp/0.6.0)
- StructLinq.BCL: [0.27.0](https://www.nuget.org/packages/StructLinq/0.27.0)
- NetFabric.Hyperlinq: [3.0.0-beta44](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta44)
- System.Linq.Async: [5.0.0](https://www.nuget.org/packages/System.Linq.Async/5.0.0)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Catalina 10.15.7 (19H1417) [Darwin 19.6.0]
Intel Core i5-7360U CPU 2.30GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-rc.1.21458.32
  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  .NET 6 PGO : .NET 6.0.0 (6.0.21.45113), X64 RyuJIT

Job=.NET 6 PGO  EnvironmentVariables=COMPlus_ReadyToRun=0,COMPlus_TC_QuickJitForLoops=1,COMPlus_TieredPGO=1  Runtime=.NET 6.0  

```
|                  Method | Count |     Mean |   Error |  StdDev |        Ratio | RatioSD | Allocated |
|------------------------ |------ |---------:|--------:|--------:|-------------:|--------:|----------:|
|             ForeachLoop |   100 | 166.4 ms | 0.84 ms | 0.75 ms |     baseline |         |     23 KB |
|                    Linq |   100 | 166.5 ms | 1.28 ms | 1.19 ms | 1.00x slower |   0.01x |     55 KB |
|               Hyperlinq |   100 | 166.4 ms | 1.19 ms | 1.11 ms | 1.00x faster |   0.01x |     24 KB |
| Hyperlinq_ValueDelegate |   100 | 166.1 ms | 0.83 ms | 0.78 ms | 1.00x faster |   0.01x |     22 KB |