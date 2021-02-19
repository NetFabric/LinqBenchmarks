## Enumerable.Int32.EnumerableInt32SkipTakeWhere

### Source
[EnumerableInt32SkipTakeWhere.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32SkipTakeWhere.cs)

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
|               Method |      Job |  Runtime | Skip | Count |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |----- |------ |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|          ForeachLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.120 μs | 0.0151 μs | 0.0134 μs |  1.00 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.782 μs | 0.0112 μs | 0.0099 μs |  1.21 | 0.0992 |     - |     - |     208 B |
|               LinqAF | .NET 5.0 | .NET 5.0 | 1000 |   100 | 4.683 μs | 0.0140 μs | 0.0110 μs |  1.50 | 0.0153 |     - |     - |      40 B |
|           StructLinq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.963 μs | 0.0151 μs | 0.0126 μs |  1.27 | 0.0610 |     - |     - |     128 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.317 μs | 0.0176 μs | 0.0165 μs |  1.06 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.241 μs | 0.0108 μs | 0.0090 μs |  1.04 | 0.0191 |     - |     - |      40 B |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.885 μs | 0.0110 μs | 0.0092 μs |  1.25 | 0.0153 |     - |     - |      40 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.084 μs | 0.0223 μs | 0.0209 μs |  0.99 | 0.0191 |     - |     - |      40 B |
|                 Linq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.715 μs | 0.0190 μs | 0.0178 μs |  1.19 | 0.0992 |     - |     - |     208 B |
|               LinqAF | .NET 6.0 | .NET 6.0 | 1000 |   100 | 4.532 μs | 0.0214 μs | 0.0190 μs |  1.45 | 0.0153 |     - |     - |      40 B |
|           StructLinq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.763 μs | 0.0103 μs | 0.0086 μs |  1.21 | 0.0610 |     - |     - |     128 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.595 μs | 0.0074 μs | 0.0058 μs |  1.15 | 0.0191 |     - |     - |      40 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.287 μs | 0.0230 μs | 0.0204 μs |  1.05 | 0.0191 |     - |     - |      40 B |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 | 4.384 μs | 0.0252 μs | 0.0223 μs |  1.41 | 0.0153 |     - |     - |      40 B |
