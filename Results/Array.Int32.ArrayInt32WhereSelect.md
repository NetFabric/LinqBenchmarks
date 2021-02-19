## Array.Int32.ArrayInt32WhereSelect

### Source
[ArrayInt32WhereSelect.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelect.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |  81.06 ns | 0.702 ns | 0.657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |  81.99 ns | 1.614 ns | 1.510 ns |  1.01 |    0.02 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 694.55 ns | 2.983 ns | 2.644 ns |  8.57 |    0.09 | 0.0496 |     - |     - |     104 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 370.11 ns | 1.081 ns | 0.959 ns |  4.56 |    0.04 | 0.3171 |     - |     - |     664 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 494.25 ns | 3.606 ns | 3.011 ns |  6.09 |    0.06 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 376.51 ns | 3.526 ns | 2.944 ns |  4.64 |    0.06 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 184.54 ns | 0.519 ns | 0.405 ns |  2.27 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 346.90 ns | 2.146 ns | 1.792 ns |  4.27 |    0.04 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 209.48 ns | 1.801 ns | 1.504 ns |  2.58 |    0.02 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |  68.14 ns | 1.398 ns | 2.005 ns |  0.85 |    0.03 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |  67.43 ns | 1.366 ns | 1.278 ns |  0.83 |    0.02 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 727.97 ns | 7.162 ns | 6.349 ns |  8.98 |    0.09 | 0.0496 |     - |     - |     104 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 386.80 ns | 3.778 ns | 2.950 ns |  4.77 |    0.04 | 0.3171 |     - |     - |     664 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 505.62 ns | 9.631 ns | 7.519 ns |  6.23 |    0.07 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 370.00 ns | 5.274 ns | 4.933 ns |  4.56 |    0.06 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 184.11 ns | 0.601 ns | 0.469 ns |  2.27 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 416.73 ns | 7.915 ns | 8.128 ns |  5.13 |    0.09 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 206.93 ns | 0.484 ns | 0.429 ns |  2.55 |    0.02 |      - |     - |     - |         - |
