## Enumerable.Int32.EnumerableInt32Sum

### Source
[EnumerableInt32Sum.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Sum.cs)

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
|               Method |      Job |  Runtime | Count |     Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |---------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 492.3 ns | 2.24 ns | 1.75 ns |  1.00 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 443.3 ns | 1.78 ns | 1.57 ns |  0.90 | 0.0191 |     - |     - |      40 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 506.7 ns | 2.22 ns | 1.85 ns |  1.03 | 0.0191 |     - |     - |      40 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 506.0 ns | 2.11 ns | 1.76 ns |  1.03 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 493.0 ns | 2.25 ns | 1.88 ns |  1.00 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 467.9 ns | 1.25 ns | 1.04 ns |  0.95 | 0.0191 |     - |     - |      40 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 440.9 ns | 1.97 ns | 1.65 ns |  0.90 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 439.6 ns | 1.43 ns | 1.27 ns |  0.89 | 0.0191 |     - |     - |      40 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 454.9 ns | 2.06 ns | 1.72 ns |  0.92 | 0.0191 |     - |     - |      40 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 453.4 ns | 1.53 ns | 1.43 ns |  0.92 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 440.6 ns | 1.88 ns | 1.67 ns |  0.89 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 463.0 ns | 1.84 ns | 1.53 ns |  0.94 | 0.0191 |     - |     - |      40 B |
