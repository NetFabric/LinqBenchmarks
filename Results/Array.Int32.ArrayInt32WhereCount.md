## Array.Int32.ArrayInt32WhereCount

### Source
[ArrayInt32WhereCount.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereCount.cs)

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
|               Method |      Job |  Runtime | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |  66.27 ns | 0.318 ns | 0.266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |  66.72 ns | 0.679 ns | 0.602 ns |  1.01 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 668.64 ns | 2.807 ns | 2.344 ns | 10.09 |    0.06 | 0.0153 |     - |     - |      32 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 236.90 ns | 1.090 ns | 0.910 ns |  3.58 |    0.02 |      - |     - |     - |         - |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 258.65 ns | 1.959 ns | 1.832 ns |  3.90 |    0.03 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 232.37 ns | 1.015 ns | 0.900 ns |  3.51 |    0.02 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |  84.58 ns | 0.459 ns | 0.407 ns |  1.28 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 169.30 ns | 2.251 ns | 1.879 ns |  2.55 |    0.03 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |  76.68 ns | 0.221 ns | 0.207 ns |  1.16 |    0.01 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |  66.68 ns | 0.759 ns | 0.634 ns |  1.01 |    0.01 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |  66.29 ns | 0.302 ns | 0.268 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 690.36 ns | 3.561 ns | 3.331 ns | 10.42 |    0.06 | 0.0153 |     - |     - |      32 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 235.09 ns | 1.071 ns | 1.002 ns |  3.55 |    0.02 |      - |     - |     - |         - |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 248.46 ns | 2.347 ns | 1.832 ns |  3.75 |    0.03 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 266.11 ns | 1.691 ns | 1.499 ns |  4.02 |    0.02 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |  86.53 ns | 0.319 ns | 0.283 ns |  1.31 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 191.03 ns | 0.294 ns | 0.246 ns |  2.88 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |  71.73 ns | 0.353 ns | 0.330 ns |  1.08 |    0.01 |      - |     - |     - |         - |
