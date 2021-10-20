## Array.ValueType.ArrayValueTypeSkipTakeWhere

### Source
[ArrayValueTypeSkipTakeWhere.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSkipTakeWhere.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqFaster.SIMD: [1.1.2](https://www.nuget.org/packages/LinqFaster.SIMD/1.0.3)
- LinqFasterer: [2.1.0](https://www.nuget.org/packages/LinqFasterer/2.1.0)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- LinqOptimizer.CSharp: [0.7.0](https://www.nuget.org/packages/LinqOptimizer.CSharp/0.7.0)
- SpanLinq: [0.0.1](https://www.nuget.org/packages/SpanLinq/0.0.1)
- Streams.CSharp: [0.6.0](https://www.nuget.org/packages/Streams.CSharp/0.6.0)
- StructLinq.BCL: [0.27.0](https://www.nuget.org/packages/StructLinq/0.27.0)
- NetFabric.Hyperlinq: [3.0.0-beta48](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta48)
- System.Linq.Async: [5.0.0](https://www.nuget.org/packages/System.Linq.Async/5.0.0)
- Faslinq: [1.0.5](https://www.nuget.org/packages/Faslinq/1.0.5)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.21390
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.100-rc.2.21505.57
  [Host] : .NET Core 3.1.20 (CoreCLR 4.700.21.47003, CoreFX 4.700.21.47101), X64 RyuJIT DEBUG  [AttachedDebugger]

Toolchain=InProcessEmitToolchain  InvocationCount=1  UnrollFactor=1  

```
|                   Method | Skip | Count |            Mean |         Error |         StdDev |          Median | Ratio | RatioSD | Allocated |
|------------------------- |----- |------ |----------------:|--------------:|---------------:|----------------:|------:|--------:|----------:|
|                  ForLoop | 1000 |   100 |       0.0000 ns |     0.0000 ns |      0.0000 ns |       0.0000 ns |     ? |       ? |         - |
|                     Linq | 1000 |   100 |  13,423.0769 ns |   943.1540 ns |  2,434.5817 ns |  12,650.0000 ns |     ? |       ? |     416 B |
|               LinqFaster | 1000 |   100 |  12,600.0000 ns | 1,575.6766 ns |  4,366.1924 ns |  11,300.0000 ns |     ? |       ? |  22,656 B |
|             LinqFasterer | 1000 |   100 |  12,885.7143 ns | 1,331.7621 ns |  3,413.8154 ns |  12,600.0000 ns |     ? |       ? |   9,744 B |
|                   LinqAF | 1000 |   100 |  19,867.2840 ns | 2,538.7640 ns |  6,688.1199 ns |  17,550.0000 ns |     ? |       ? |     144 B |
|            LinqOptimizer | 1000 |   100 |  54,956.0440 ns | 2,584.2903 ns |  7,246.6269 ns |  53,100.0000 ns |     ? |       ? | 135,192 B |
|                 SpanLinq | 1000 |   100 |   8,562.5000 ns |   587.2590 ns |  1,536.7543 ns |   8,100.0000 ns |     ? |       ? |      48 B |
|                  Streams | 1000 |   100 | 147,693.6170 ns | 6,607.0118 ns | 18,850.1765 ns | 140,850.0000 ns |     ? |       ? |   1,296 B |
|               StructLinq | 1000 |   100 |  11,393.9759 ns | 1,002.0744 ns |  2,674.7395 ns |  10,700.0000 ns |     ? |       ? |      96 B |
| StructLinq_ValueDelegate | 1000 |   100 |   6,030.5195 ns |   438.2644 ns |  1,123.4391 ns |   5,650.0000 ns |     ? |       ? |      96 B |
|                Hyperlinq | 1000 |   100 |   7,037.3418 ns |   541.8157 ns |  1,408.2511 ns |   6,550.0000 ns |     ? |       ? |         - |
|  Hyperlinq_ValueDelegate | 1000 |   100 |   6,554.8780 ns |   463.8506 ns |  1,230.0660 ns |   6,150.0000 ns |     ? |       ? |      48 B |
