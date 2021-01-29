﻿## Enumerable.Int32.EnumerableInt32SkipTakeSelect

### Source
[EnumerableInt32SkipTakeSelect.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32SkipTakeSelect.cs)

### References:
- Cistern.ValueLinq: [0.0.11](https://www.nuget.org/packages/Cistern.ValueLinq/0.0.11)
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- StructLinq.BCL: [0.25.3](https://www.nuget.org/packages/StructLinq.BCL/0.25.3)
- NetFabric.Hyperlinq: [3.0.0-beta28](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta28)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7567U CPU 3.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.200-preview.20614.14
  [Host]        : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|                      Method | Skip | Count |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----- |------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                 ForeachLoop | 1000 |   100 | 3.300 μs | 0.0273 μs | 0.0228 μs |  1.00 |    0.00 | 0.0191 |     - |     - |      40 B |
|                        Linq | 1000 |   100 | 4.814 μs | 0.0268 μs | 0.0251 μs |  1.46 |    0.01 | 0.0992 |     - |     - |     208 B |
|                      LinqAF | 1000 |   100 | 4.993 μs | 0.0338 μs | 0.0300 μs |  1.51 |    0.01 | 0.0153 |     - |     - |      40 B |
|                  StructLinq | 1000 |   100 | 4.207 μs | 0.0167 μs | 0.0156 μs |  1.28 |    0.01 | 0.0610 |     - |     - |     128 B |
|        StructLinq_IFunction | 1000 |   100 | 3.757 μs | 0.0158 μs | 0.0147 μs |  1.14 |    0.01 | 0.0191 |     - |     - |      40 B |
|           Hyperlinq_Foreach | 1000 |   100 | 3.832 μs | 0.0208 μs | 0.0174 μs |  1.16 |    0.01 | 0.0153 |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction | 1000 |   100 | 4.110 μs | 0.0467 μs | 0.0390 μs |  1.25 |    0.02 | 0.0153 |     - |     - |      40 B |