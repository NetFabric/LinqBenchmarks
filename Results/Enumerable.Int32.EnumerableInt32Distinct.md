﻿## Enumerable.Int32.EnumerableInt32Distinct

### Source
[EnumerableInt32Distinct.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Distinct.cs)

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
|               Method | Count |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|          ForeachLoop |   100 | 2.044 μs | 0.0175 μs | 0.0155 μs |  1.00 |    0.00 | 2.8877 |     - |     - |    6048 B |
|                 Linq |   100 | 3.033 μs | 0.0323 μs | 0.0302 μs |  1.48 |    0.02 | 2.0638 |     - |     - |    4320 B |
|               LinqAF |   100 | 4.356 μs | 0.0248 μs | 0.0220 μs |  2.13 |    0.02 | 2.5024 |     - |     - |    5240 B |
|           StructLinq |   100 | 2.441 μs | 0.0105 μs | 0.0093 μs |  1.19 |    0.01 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction |   100 | 2.425 μs | 0.0118 μs | 0.0092 μs |  1.19 |    0.01 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq |   100 | 2.281 μs | 0.0185 μs | 0.0144 μs |  1.12 |    0.01 | 0.0191 |     - |     - |      40 B |