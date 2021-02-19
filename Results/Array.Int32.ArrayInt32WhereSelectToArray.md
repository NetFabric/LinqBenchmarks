## Array.Int32.ArrayInt32WhereSelectToArray

### Source
[ArrayInt32WhereSelectToArray.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelectToArray.cs)

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
|               Method |      Job |  Runtime | Count |     Mean |   Error |  StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |---------:|--------:|--------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 | 235.0 ns | 3.51 ns | 3.28 ns |  1.00 |    0.00 | 0.4244 |     - |     - |     888 B |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 266.5 ns | 1.72 ns | 1.60 ns |  1.13 |    0.02 | 0.4244 |     - |     - |     888 B |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 537.7 ns | 5.07 ns | 4.23 ns |  2.29 |    0.04 | 0.3786 |     - |     - |     792 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 392.0 ns | 1.07 ns | 0.94 ns |  1.67 |    0.02 | 0.3171 |     - |     - |     664 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 658.5 ns | 6.57 ns | 5.49 ns |  2.80 |    0.03 | 0.4091 |     - |     - |     856 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 530.6 ns | 8.06 ns | 7.14 ns |  2.26 |    0.05 | 0.1602 |     - |     - |     336 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 303.0 ns | 1.68 ns | 1.49 ns |  1.29 |    0.02 | 0.1144 |     - |     - |     240 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 571.3 ns | 3.51 ns | 2.93 ns |  2.43 |    0.04 | 0.1144 |     - |     - |     240 B |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 345.3 ns | 3.39 ns | 2.83 ns |  1.47 |    0.03 | 0.1144 |     - |     - |     240 B |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 | 271.8 ns | 2.34 ns | 1.82 ns |  1.16 |    0.02 | 0.4244 |     - |     - |     888 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 278.1 ns | 2.02 ns | 1.79 ns |  1.18 |    0.02 | 0.4244 |     - |     - |     888 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 523.4 ns | 8.94 ns | 7.46 ns |  2.23 |    0.04 | 0.3786 |     - |     - |     792 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 391.8 ns | 1.62 ns | 1.35 ns |  1.67 |    0.03 | 0.3171 |     - |     - |     664 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 741.2 ns | 5.04 ns | 4.72 ns |  3.15 |    0.04 | 0.4091 |     - |     - |     856 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 548.6 ns | 7.35 ns | 6.88 ns |  2.33 |    0.05 | 0.1602 |     - |     - |     336 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 299.1 ns | 1.30 ns | 1.21 ns |  1.27 |    0.02 | 0.1144 |     - |     - |     240 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 561.8 ns | 3.51 ns | 2.93 ns |  2.39 |    0.03 | 0.1144 |     - |     - |     240 B |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 356.0 ns | 1.62 ns | 1.44 ns |  1.51 |    0.02 | 0.1144 |     - |     - |     240 B |
