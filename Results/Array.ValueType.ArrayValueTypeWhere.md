﻿## Array.ValueType.ArrayValueTypeWhere

### Source
[ArrayValueTypeWhere.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhere.cs)

### References:
- Cistern.ValueLinq: [0.1.14](https://www.nuget.org/packages/Cistern.ValueLinq/0.1.14)
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- StructLinq.BCL: [0.25.3](https://www.nuget.org/packages/StructLinq.BCL/0.25.3)
- NetFabric.Hyperlinq: [3.0.0-beta32](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta32)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7567U CPU 3.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.200-preview.20614.14
  [Host]        : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|               Method | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop |   100 |   410.0 ns |  0.81 ns |  0.76 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |   100 |   448.7 ns |  0.60 ns |  0.53 ns |  1.09 |    0.00 |      - |     - |     - |         - |
|                 Linq |   100 |   858.6 ns |  3.42 ns |  3.03 ns |  2.09 |    0.01 | 0.0381 |     - |     - |      80 B |
|           LinqFaster |   100 |   940.9 ns |  4.66 ns |  3.89 ns |  2.29 |    0.01 | 2.8896 |     - |     - |    6048 B |
|               LinqAF |   100 | 1,035.6 ns | 19.76 ns | 20.30 ns |  2.53 |    0.05 |      - |     - |     - |         - |
|           StructLinq |   100 |   590.4 ns |  1.26 ns |  1.12 ns |  1.44 |    0.00 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction |   100 |   488.1 ns |  0.86 ns |  0.72 ns |  1.19 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |   100 |   526.1 ns |  1.02 ns |  0.90 ns |  1.28 |    0.00 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |   100 |   466.6 ns |  0.61 ns |  0.51 ns |  1.14 |    0.00 |      - |     - |     - |         - |