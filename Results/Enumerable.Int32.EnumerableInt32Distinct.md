## Enumerable.Int32.EnumerableInt32Distinct

### Source
[EnumerableInt32Distinct.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Distinct.cs)

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
|               Method |      Job |  Runtime | Count |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 1.814 μs | 0.0084 μs | 0.0074 μs |  1.00 | 2.8896 |     - |     - |   6,048 B |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 2.654 μs | 0.0167 μs | 0.0148 μs |  1.46 | 2.0638 |     - |     - |   4,320 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 3.696 μs | 0.0204 μs | 0.0181 μs |  2.04 | 2.5024 |     - |     - |   5,240 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 2.193 μs | 0.0131 μs | 0.0116 μs |  1.21 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 2.169 μs | 0.0089 μs | 0.0079 μs |  1.20 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 2.069 μs | 0.0094 μs | 0.0078 μs |  1.14 | 0.0191 |     - |     - |      40 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 1.841 μs | 0.0096 μs | 0.0090 μs |  1.02 | 2.8896 |     - |     - |   6,048 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 2.622 μs | 0.0109 μs | 0.0102 μs |  1.45 | 2.0638 |     - |     - |   4,320 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 3.623 μs | 0.0313 μs | 0.0261 μs |  2.00 | 2.5024 |     - |     - |   5,240 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 2.193 μs | 0.0080 μs | 0.0063 μs |  1.21 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 2.096 μs | 0.0174 μs | 0.0154 μs |  1.16 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 2.174 μs | 0.0178 μs | 0.0158 μs |  1.20 | 0.0191 |     - |     - |      40 B |
