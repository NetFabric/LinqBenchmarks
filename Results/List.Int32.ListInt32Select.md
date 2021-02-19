## List.Int32.ListInt32Select

### Source
[ListInt32Select.cs](../LinqBenchmarks/List/Int32/ListInt32Select.cs)

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
|                      Method |      Job |  Runtime | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |--------- |--------- |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop | .NET 5.0 | .NET 5.0 |   100 | 136.86 ns | 0.374 ns | 0.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 246.44 ns | 1.147 ns | 1.016 ns |  1.80 |    0.01 |      - |     - |     - |         - |
|                        Linq | .NET 5.0 | .NET 5.0 |   100 | 739.35 ns | 3.536 ns | 2.952 ns |  5.40 |    0.03 | 0.0343 |     - |     - |      72 B |
|                  LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 398.71 ns | 1.883 ns | 1.669 ns |  2.91 |    0.02 | 0.2179 |     - |     - |     456 B |
|                      LinqAF | .NET 5.0 | .NET 5.0 |   100 | 765.18 ns | 1.883 ns | 1.669 ns |  5.59 |    0.02 |      - |     - |     - |         - |
|                  StructLinq | .NET 5.0 | .NET 5.0 |   100 | 235.09 ns | 1.077 ns | 1.007 ns |  1.72 |    0.01 | 0.0153 |     - |     - |      32 B |
|        StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 165.95 ns | 0.349 ns | 0.291 ns |  1.21 |    0.00 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 5.0 | .NET 5.0 |   100 | 203.54 ns | 0.683 ns | 0.606 ns |  1.49 |    0.01 |      - |     - |     - |         - |
| Hyperlinq_IFunction_Foreach | .NET 5.0 | .NET 5.0 |   100 | 166.76 ns | 0.621 ns | 0.581 ns |  1.22 |    0.01 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 5.0 | .NET 5.0 |   100 | 219.41 ns | 0.896 ns | 0.699 ns |  1.60 |    0.01 |      - |     - |     - |         - |
|     Hyperlinq_IFunction_For | .NET 5.0 | .NET 5.0 |   100 |  88.52 ns | 0.224 ns | 0.210 ns |  0.65 |    0.00 |      - |     - |     - |         - |
|              Hyperlinq_SIMD | .NET 5.0 | .NET 5.0 |   100 | 237.35 ns | 0.602 ns | 0.563 ns |  1.73 |    0.01 |      - |     - |     - |         - |
|    Hyperlinq_SIMD_IFunction | .NET 5.0 | .NET 5.0 |   100 | 168.22 ns | 0.738 ns | 0.654 ns |  1.23 |    0.01 |      - |     - |     - |         - |
|                     ForLoop | .NET 6.0 | .NET 6.0 |   100 | 104.58 ns | 0.435 ns | 0.386 ns |  0.76 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 163.11 ns | 0.489 ns | 0.458 ns |  1.19 |    0.00 |      - |     - |     - |         - |
|                        Linq | .NET 6.0 | .NET 6.0 |   100 | 803.30 ns | 3.602 ns | 3.193 ns |  5.87 |    0.03 | 0.0343 |     - |     - |      72 B |
|                  LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 377.41 ns | 1.741 ns | 1.543 ns |  2.76 |    0.02 | 0.2179 |     - |     - |     456 B |
|                      LinqAF | .NET 6.0 | .NET 6.0 |   100 | 774.58 ns | 2.386 ns | 2.115 ns |  5.66 |    0.02 |      - |     - |     - |         - |
|                  StructLinq | .NET 6.0 | .NET 6.0 |   100 | 216.81 ns | 1.044 ns | 0.815 ns |  1.58 |    0.01 | 0.0153 |     - |     - |      32 B |
|        StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 166.43 ns | 0.712 ns | 0.666 ns |  1.22 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 6.0 | .NET 6.0 |   100 | 205.68 ns | 0.440 ns | 0.390 ns |  1.50 |    0.00 |      - |     - |     - |         - |
| Hyperlinq_IFunction_Foreach | .NET 6.0 | .NET 6.0 |   100 | 175.95 ns | 0.381 ns | 0.338 ns |  1.29 |    0.00 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 6.0 | .NET 6.0 |   100 | 219.12 ns | 0.764 ns | 0.677 ns |  1.60 |    0.01 |      - |     - |     - |         - |
|     Hyperlinq_IFunction_For | .NET 6.0 | .NET 6.0 |   100 |  88.65 ns | 0.432 ns | 0.383 ns |  0.65 |    0.00 |      - |     - |     - |         - |
|              Hyperlinq_SIMD | .NET 6.0 | .NET 6.0 |   100 | 234.72 ns | 1.174 ns | 1.098 ns |  1.71 |    0.01 |      - |     - |     - |         - |
|    Hyperlinq_SIMD_IFunction | .NET 6.0 | .NET 6.0 |   100 | 169.11 ns | 0.678 ns | 0.634 ns |  1.24 |    0.01 |      - |     - |     - |         - |
