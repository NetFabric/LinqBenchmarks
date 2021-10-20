## List.ValueType.ListValueTypeSelect

### Source
[ListValueTypeSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSelect.cs)

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
|                   Method | Count |           Mean |         Error |         StdDev |         Median | Ratio | RatioSD | Allocated |
|------------------------- |------ |---------------:|--------------:|---------------:|---------------:|------:|--------:|----------:|
|                  ForLoop |   100 |      0.0000 ns |     0.0000 ns |      0.0000 ns |      0.0000 ns |     ? |       ? |      48 B |
|              ForeachLoop |   100 |  2,897.8495 ns | 1,278.1936 ns |  3,626.0224 ns |  1,100.0000 ns |     ? |       ? |      48 B |
|                     Linq |   100 | 13,676.5060 ns |   961.6069 ns |  2,566.7235 ns | 13,150.0000 ns |     ? |       ? |     280 B |
|               LinqFaster |   100 | 12,523.4043 ns | 1,184.6467 ns |  3,379.8637 ns | 11,050.0000 ns |     ? |       ? |   6,456 B |
|             LinqFasterer |   100 | 14,402.6316 ns | 1,068.0016 ns |  2,718.4051 ns | 13,700.0000 ns |     ? |       ? |  12,880 B |
|                   LinqAF |   100 | 14,865.0000 ns |   803.1345 ns |  2,101.6630 ns | 14,100.0000 ns |     ? |       ? |     144 B |
|            LinqOptimizer |   100 | 61,745.7447 ns | 5,313.6321 ns | 15,160.0913 ns | 54,750.0000 ns |     ? |       ? | 138,424 B |
|                  Streams |   100 | 96,348.9583 ns | 7,812.3173 ns | 22,540.3217 ns | 88,600.0000 ns |     ? |       ? |     944 B |
|               StructLinq |   100 | 17,781.2500 ns | 3,045.1484 ns |  8,785.9495 ns | 13,550.0000 ns |     ? |       ? |      40 B |
| StructLinq_ValueDelegate |   100 |  8,777.1084 ns | 1,166.1805 ns |  3,112.7717 ns |  7,700.0000 ns |     ? |       ? |      48 B |
|                Hyperlinq |   100 |  8,490.0000 ns |   719.3205 ns |  1,882.3363 ns |  7,900.0000 ns |     ? |       ? |      48 B |
|  Hyperlinq_ValueDelegate |   100 |  8,605.0633 ns |   743.1631 ns |  1,931.5796 ns |  8,000.0000 ns |     ? |       ? |      96 B |
|                  Faslinq |   100 | 16,721.0000 ns | 1,307.6763 ns |  3,855.7132 ns | 15,550.0000 ns |     ? |       ? |  16,304 B |
