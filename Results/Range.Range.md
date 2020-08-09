## Range.Range

### Source
[Range.cs](../LinqBenchmarks/Range/Range.cs)

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
|      Method | Start | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|     ForLoop |     0 |   100 |  36.70 ns | 0.321 ns | 0.251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
| ForeachLoop |     0 |   100 | 580.68 ns | 2.352 ns | 1.964 ns | 15.82 |    0.13 | 0.0267 |     - |     - |      56 B |
|        Linq |     0 |   100 | 547.41 ns | 3.269 ns | 2.898 ns | 14.92 |    0.12 | 0.0191 |     - |     - |      40 B |
|  LinqFaster |     0 |   100 | 143.02 ns | 1.647 ns | 1.375 ns |  3.90 |    0.04 | 0.2027 |     - |     - |     424 B |
|      LinqAF |     0 |   100 | 228.74 ns | 0.489 ns | 0.408 ns |  6.23 |    0.04 |      - |     - |     - |         - |
|  StructLinq |     0 |   100 |  43.90 ns | 0.096 ns | 0.080 ns |  1.20 |    0.01 |      - |     - |     - |         - |
|   Hyperlinq |     0 |   100 |  47.32 ns | 0.195 ns | 0.152 ns |  1.29 |    0.01 |      - |     - |     - |         - |
