## Range.RangeSelect

### Source
[RangeSelect.cs](../LinqBenchmarks/Range/RangeSelect.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- StructLinq.BCL: [0.19.1](https://www.nuget.org/packages/StructLinq.BCL/0.19.1)
- NetFabric.Hyperlinq: [3.0.0-beta24](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta24)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=macOS Catalina 10.15.6 (19G73) [Darwin 19.6.0]
Intel Core i5-7360U CPU 2.30GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.100-preview.6.20318.15
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.30506, CoreFX 5.0.20.30506), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.30506, CoreFX 5.0.20.30506), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|               Method | Start | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop |     0 |   100 |  43.71 ns | 0.147 ns | 0.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop |     0 |   100 | 515.34 ns | 2.325 ns | 1.815 ns | 11.78 |    0.04 | 0.0267 |     - |     - |      56 B |
|                 Linq |     0 |   100 | 692.07 ns | 1.233 ns | 1.093 ns | 15.83 |    0.05 | 0.0420 |     - |     - |      88 B |
|           LinqFaster |     0 |   100 | 409.92 ns | 1.674 ns | 1.566 ns |  9.38 |    0.06 | 0.4053 |     - |     - |     848 B |
|               LinqAF |     0 |   100 | 521.92 ns | 6.050 ns | 5.659 ns | 11.94 |    0.14 |      - |     - |     - |         - |
|           StructLinq |     0 |   100 | 296.79 ns | 0.405 ns | 0.378 ns |  6.79 |    0.03 |      - |     - |     - |         - |
| StructLinq_IFunction |     0 |   100 | 185.03 ns | 0.790 ns | 0.700 ns |  4.23 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq |     0 |   100 | 528.03 ns | 1.327 ns | 1.108 ns | 12.08 |    0.04 |      - |     - |     - |         - |
