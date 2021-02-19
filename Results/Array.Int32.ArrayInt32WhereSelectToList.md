## Array.Int32.ArrayInt32WhereSelectToList

### Source
[ArrayInt32WhereSelectToList.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelectToList.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqFaster.SIMD: [1.1.2](https://www.nuget.org/packages/LinqFaster.SIMD/1.0.3)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- StructLinq.BCL: [0.25.3](https://www.nuget.org/packages/StructLinq.BCL/0.25.3)
- NetFabric.Hyperlinq: [3.0.0-beta38](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta38)

### Results:
``` ini

BenchmarkDotNet=v0.12.1.1514-nightly, OS=Windows 10.0.19042.804 (20H2/October2020Update)
Intel Core i7-7567U CPU 3.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.1.21103.13
  [Host]   : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT
  .NET 5.0 : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT
  .NET 6.0 : .NET 6.0.0 (6.0.21.10212), X64 RyuJIT


```
|               Method |      Job |  Runtime | Count |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |---------:|---------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 | 242.5 ns |  1.23 ns |  1.02 ns | 242.8 ns |  1.00 |    0.00 | 0.3095 |     - |     - |     648 B |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 243.3 ns |  2.01 ns |  1.78 ns | 242.9 ns |  1.00 |    0.01 | 0.3095 |     - |     - |     648 B |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 483.6 ns |  8.50 ns |  7.53 ns | 479.9 ns |  2.00 |    0.03 | 0.3595 |     - |     - |     752 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 422.3 ns |  1.60 ns |  1.42 ns | 421.9 ns |  1.74 |    0.01 | 0.4473 |     - |     - |     936 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 686.2 ns |  5.82 ns |  5.16 ns | 683.7 ns |  2.83 |    0.02 | 0.3090 |     - |     - |     648 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 530.6 ns |  9.86 ns | 17.53 ns | 524.3 ns |  2.22 |    0.10 | 0.1755 |     - |     - |     368 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 305.5 ns |  1.20 ns |  1.00 ns | 305.4 ns |  1.26 |    0.00 | 0.1297 |     - |     - |     272 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 604.8 ns |  2.78 ns |  2.17 ns | 604.5 ns |  2.49 |    0.01 | 0.1297 |     - |     - |     272 B |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 365.7 ns |  1.64 ns |  1.54 ns | 365.4 ns |  1.51 |    0.01 | 0.1297 |     - |     - |     272 B |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 | 249.8 ns |  1.21 ns |  1.08 ns | 249.6 ns |  1.03 |    0.01 | 0.3095 |     - |     - |     648 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 246.5 ns |  1.28 ns |  1.13 ns | 246.7 ns |  1.02 |    0.00 | 0.3095 |     - |     - |     648 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 479.7 ns |  4.20 ns |  3.73 ns | 478.8 ns |  1.98 |    0.02 | 0.3595 |     - |     - |     752 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 363.6 ns |  1.51 ns |  1.41 ns | 363.2 ns |  1.50 |    0.01 | 0.4473 |     - |     - |     936 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 693.0 ns |  3.88 ns |  3.63 ns | 692.8 ns |  2.86 |    0.02 | 0.3090 |     - |     - |     648 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 553.6 ns |  3.95 ns |  3.50 ns | 552.1 ns |  2.28 |    0.02 | 0.1755 |     - |     - |     368 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 311.3 ns |  1.20 ns |  1.07 ns | 311.5 ns |  1.28 |    0.01 | 0.1297 |     - |     - |     272 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 613.6 ns | 12.21 ns | 22.93 ns | 601.8 ns |  2.54 |    0.11 | 0.1297 |     - |     - |     272 B |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 370.9 ns |  3.08 ns |  2.73 ns | 370.8 ns |  1.53 |    0.01 | 0.1297 |     - |     - |     272 B |
