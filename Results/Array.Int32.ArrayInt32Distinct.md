## Array.Int32.ArrayInt32Distinct

### Source
[ArrayInt32Distinct.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Distinct.cs)

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
|               Method |      Job |  Runtime | Duplicates | Count |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |----------- |------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |          4 |   100 | 3.090 μs | 0.0142 μs | 0.0118 μs |  1.00 |    0.00 | 2.8687 |     - |     - |   6,008 B |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |          4 |   100 | 3.067 μs | 0.0350 μs | 0.0327 μs |  0.99 |    0.01 | 2.8687 |     - |     - |   6,008 B |
|                 Linq | .NET 5.0 | .NET 5.0 |          4 |   100 | 6.653 μs | 0.0208 μs | 0.0185 μs |  2.15 |    0.01 | 2.0599 |     - |     - |   4,312 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |          4 |   100 | 7.986 μs | 0.0297 μs | 0.0278 μs |  2.58 |    0.01 | 5.9204 |     - |     - |  12,400 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |          4 |   100 | 3.719 μs | 0.0107 μs | 0.0100 μs |  1.20 |    0.01 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |          4 |   100 | 3.445 μs | 0.0127 μs | 0.0099 μs |  1.12 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |          4 |   100 | 3.831 μs | 0.0241 μs | 0.0226 μs |  1.24 |    0.01 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |          4 |   100 | 3.080 μs | 0.0209 μs | 0.0195 μs |  1.00 |    0.01 | 2.8687 |     - |     - |   6,008 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |          4 |   100 | 3.088 μs | 0.0228 μs | 0.0178 μs |  1.00 |    0.01 | 2.8687 |     - |     - |   6,008 B |
|                 Linq | .NET 6.0 | .NET 6.0 |          4 |   100 | 6.516 μs | 0.0208 μs | 0.0174 μs |  2.11 |    0.01 | 2.0599 |     - |     - |   4,312 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |          4 |   100 | 7.914 μs | 0.0437 μs | 0.0341 μs |  2.56 |    0.02 | 5.9204 |     - |     - |  12,400 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |          4 |   100 | 3.412 μs | 0.0089 μs | 0.0074 μs |  1.10 |    0.01 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |          4 |   100 | 3.435 μs | 0.0076 μs | 0.0067 μs |  1.11 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |          4 |   100 | 3.815 μs | 0.0409 μs | 0.0383 μs |  1.23 |    0.01 |      - |     - |     - |         - |
