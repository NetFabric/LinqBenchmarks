## Array.Int32.ArrayInt32Sum

### Source
[ArrayInt32Sum.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Sum.cs)

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
|               Method |      Job |  Runtime | Count |      Mean |    Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |----------:|---------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |  43.70 ns | 0.169 ns |  0.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |  59.33 ns | 1.098 ns |  1.742 ns |  1.38 |    0.04 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 443.05 ns | 7.373 ns | 10.336 ns | 10.21 |    0.27 | 0.0153 |     - |     - |      32 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 |  58.07 ns | 0.247 ns |  0.231 ns |  1.33 |    0.01 |      - |     - |     - |         - |
|      LinqFaster_SIMD | .NET 5.0 | .NET 5.0 |   100 |  11.11 ns | 0.043 ns |  0.040 ns |  0.25 |    0.00 |      - |     - |     - |         - |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 219.47 ns | 0.481 ns |  0.426 ns |  5.02 |    0.02 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |  81.54 ns | 0.319 ns |  0.266 ns |  1.87 |    0.01 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |  61.07 ns | 0.176 ns |  0.165 ns |  1.40 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |  20.17 ns | 0.107 ns |  0.094 ns |  0.46 |    0.00 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |  43.16 ns | 0.179 ns |  0.168 ns |  0.99 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |  43.10 ns | 0.149 ns |  0.124 ns |  0.99 |    0.00 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 468.73 ns | 3.725 ns |  3.302 ns | 10.73 |    0.08 | 0.0153 |     - |     - |      32 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 |  49.58 ns | 0.137 ns |  0.107 ns |  1.13 |    0.00 |      - |     - |     - |         - |
|      LinqFaster_SIMD | .NET 6.0 | .NET 6.0 |   100 |  10.55 ns | 0.050 ns |  0.041 ns |  0.24 |    0.00 |      - |     - |     - |         - |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 207.36 ns | 3.936 ns |  3.489 ns |  4.74 |    0.07 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |  83.65 ns | 1.391 ns |  1.809 ns |  1.92 |    0.04 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |  61.61 ns | 0.169 ns |  0.141 ns |  1.41 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |  15.42 ns | 0.132 ns |  0.117 ns |  0.35 |    0.00 |      - |     - |     - |         - |
