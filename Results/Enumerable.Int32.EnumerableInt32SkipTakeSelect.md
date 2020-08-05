﻿## Enumerable.Int32.EnumerableInt32SkipTakeSelect

### Source
[EnumerableInt32SkipTakeSelect.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32SkipTakeSelect.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- StructLinq.BCL: [0.19.1](https://www.nuget.org/packages/StructLinq.BCL/0.19.1)
- NetFabric.Hyperlinq: [3.0.0-beta23](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta23)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7567U CPU 3.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.36411, CoreFX 5.0.20.36411), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.36411, CoreFX 5.0.20.36411), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|               Method | Skip | Count |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|          ForeachLoop | 1000 |   100 | 2.861 μs | 0.0268 μs | 0.0224 μs |  1.00 |    0.00 | 0.0191 |     - |     - |      40 B |
|                 Linq | 1000 |   100 | 4.219 μs | 0.0234 μs | 0.0207 μs |  1.48 |    0.01 | 0.0992 |     - |     - |     208 B |
|           StructLinq | 1000 |   100 | 4.298 μs | 0.0407 μs | 0.0361 μs |  1.50 |    0.02 | 0.0687 |     - |     - |     152 B |
| StructLinq_IFunction | 1000 |   100 | 3.310 μs | 0.0116 μs | 0.0097 μs |  1.16 |    0.01 | 0.0725 |     - |     - |     152 B |
|    Hyperlinq_Foreach | 1000 |   100 | 4.012 μs | 0.0286 μs | 0.0239 μs |  1.40 |    0.01 | 0.0153 |     - |     - |      40 B |
