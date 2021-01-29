﻿## Enumerable.Int32.EnumerableInt32Select

### Source
[EnumerableInt32Select.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Select.cs)

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
|                      Method | Count |       Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |-----------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|                 ForeachLoop |   100 |   538.3 ns | 1.57 ns | 1.40 ns |  1.00 | 0.0191 |     - |     - |      40 B |
|                        Linq |   100 | 1,128.5 ns | 4.26 ns | 3.78 ns |  2.10 | 0.0458 |     - |     - |      96 B |
|                      LinqAF |   100 |   868.2 ns | 2.34 ns | 2.08 ns |  1.61 | 0.0191 |     - |     - |      40 B |
|                  StructLinq |   100 |   639.2 ns | 2.79 ns | 2.61 ns |  1.19 | 0.0305 |     - |     - |      64 B |
|        StructLinq_IFunction |   100 |   495.6 ns | 4.48 ns | 3.97 ns |  0.92 | 0.0191 |     - |     - |      40 B |
|           Hyperlinq_Foreach |   100 |   674.0 ns | 3.57 ns | 3.16 ns |  1.25 | 0.0191 |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction |   100 |   519.6 ns | 1.74 ns | 1.45 ns |  0.97 | 0.0191 |     - |     - |      40 B |