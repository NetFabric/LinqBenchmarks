﻿## Array.Int32.ArrayInt32Select

### Source
[ArrayInt32Select.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Select.cs)

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
|                      Method | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop |   100 |  47.68 ns | 0.791 ns | 0.661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop |   100 |  47.62 ns | 0.560 ns | 0.524 ns |  1.00 |    0.02 |      - |     - |     - |         - |
|                        Linq |   100 | 729.18 ns | 9.027 ns | 8.444 ns | 15.27 |    0.20 | 0.0229 |     - |     - |      48 B |
|                  LinqFaster |   100 | 292.28 ns | 3.254 ns | 2.540 ns |  6.14 |    0.11 | 0.2027 |     - |     - |     424 B |
|                      LinqAF |   100 | 548.70 ns | 6.428 ns | 5.367 ns | 11.51 |    0.20 |      - |     - |     - |         - |
|                  StructLinq |   100 | 252.08 ns | 5.064 ns | 4.737 ns |  5.28 |    0.11 | 0.0153 |     - |     - |      32 B |
|        StructLinq_IFunction |   100 | 176.28 ns | 1.768 ns | 1.654 ns |  3.70 |    0.07 |      - |     - |     - |         - |
|           Hyperlinq_Foreach |   100 | 209.31 ns | 2.818 ns | 2.636 ns |  4.40 |    0.07 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction |   100 | 173.56 ns | 1.917 ns | 1.793 ns |  3.64 |    0.08 |      - |     - |     - |         - |
|               Hyperlinq_For |   100 | 212.95 ns | 2.358 ns | 1.969 ns |  4.47 |    0.08 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction |   100 |  96.13 ns | 0.673 ns | 0.630 ns |  2.02 |    0.03 |      - |     - |     - |         - |