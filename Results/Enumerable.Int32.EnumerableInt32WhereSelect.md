﻿## Enumerable.Int32.EnumerableInt32WhereSelect

### Source
[EnumerableInt32WhereSelect.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelect.cs)

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
|               Method | Count |       Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-----------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|          ForeachLoop |   100 |   544.6 ns | 2.09 ns | 1.85 ns |  1.00 | 0.0191 |     - |     - |      40 B |
|                 Linq |   100 | 1,144.8 ns | 6.35 ns | 4.96 ns |  2.10 | 0.0763 |     - |     - |     160 B |
|               LinqAF |   100 |   936.0 ns | 4.60 ns | 4.08 ns |  1.72 | 0.0191 |     - |     - |      40 B |
|           StructLinq |   100 |   847.9 ns | 4.90 ns | 4.09 ns |  1.56 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction |   100 |   641.2 ns | 2.33 ns | 2.07 ns |  1.18 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq |   100 |   912.7 ns | 5.36 ns | 5.02 ns |  1.68 | 0.0191 |     - |     - |      40 B |
|  Hyperlinq_IFunction |   100 |   630.5 ns | 5.17 ns | 4.58 ns |  1.16 | 0.0191 |     - |     - |      40 B |