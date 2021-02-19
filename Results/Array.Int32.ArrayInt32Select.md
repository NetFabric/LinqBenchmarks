## Array.Int32.ArrayInt32Select

### Source
[ArrayInt32Select.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Select.cs)

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
|                     ForLoop | .NET 5.0 | .NET 5.0 |   100 |  57.67 ns | 0.577 ns | 0.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |  44.31 ns | 0.304 ns | 0.284 ns |  0.77 |    0.01 |      - |     - |     - |         - |
|                        Linq | .NET 5.0 | .NET 5.0 |   100 | 653.03 ns | 1.293 ns | 1.079 ns | 11.32 |    0.10 | 0.0229 |     - |     - |      48 B |
|                  LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 281.87 ns | 1.374 ns | 1.218 ns |  4.89 |    0.05 | 0.2027 |     - |     - |     424 B |
|             LinqFaster_SIMD | .NET 5.0 | .NET 5.0 |   100 | 105.19 ns | 0.750 ns | 0.626 ns |  1.82 |    0.02 | 0.2027 |     - |     - |     424 B |
|                      LinqAF | .NET 5.0 | .NET 5.0 |   100 | 482.65 ns | 1.431 ns | 1.269 ns |  8.37 |    0.08 |      - |     - |     - |         - |
|                  StructLinq | .NET 5.0 | .NET 5.0 |   100 | 231.86 ns | 0.566 ns | 0.472 ns |  4.02 |    0.03 | 0.0153 |     - |     - |      32 B |
|        StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 164.12 ns | 0.393 ns | 0.307 ns |  2.85 |    0.03 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 5.0 | .NET 5.0 |   100 | 201.18 ns | 0.380 ns | 0.355 ns |  3.49 |    0.03 |      - |     - |     - |         - |
| Hyperlinq_IFunction_Foreach | .NET 5.0 | .NET 5.0 |   100 | 174.45 ns | 0.473 ns | 0.419 ns |  3.03 |    0.02 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 5.0 | .NET 5.0 |   100 | 188.90 ns | 1.005 ns | 0.891 ns |  3.28 |    0.04 |      - |     - |     - |         - |
|     Hyperlinq_IFunction_For | .NET 5.0 | .NET 5.0 |   100 |  87.07 ns | 0.204 ns | 0.181 ns |  1.51 |    0.01 |      - |     - |     - |         - |
|              Hyperlinq_SIMD | .NET 5.0 | .NET 5.0 |   100 | 205.10 ns | 0.726 ns | 0.644 ns |  3.56 |    0.03 |      - |     - |     - |         - |
|    Hyperlinq_IFunction_SIMD | .NET 5.0 | .NET 5.0 |   100 | 166.05 ns | 0.775 ns | 0.687 ns |  2.88 |    0.03 |      - |     - |     - |         - |
|                     ForLoop | .NET 6.0 | .NET 6.0 |   100 |  42.59 ns | 0.131 ns | 0.122 ns |  0.74 |    0.01 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |  42.52 ns | 0.121 ns | 0.113 ns |  0.74 |    0.01 |      - |     - |     - |         - |
|                        Linq | .NET 6.0 | .NET 6.0 |   100 | 636.41 ns | 3.494 ns | 2.917 ns | 11.04 |    0.08 | 0.0229 |     - |     - |      48 B |
|                  LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 232.50 ns | 0.766 ns | 0.679 ns |  4.03 |    0.04 | 0.2027 |     - |     - |     424 B |
|             LinqFaster_SIMD | .NET 6.0 | .NET 6.0 |   100 | 280.40 ns | 1.439 ns | 1.346 ns |  4.86 |    0.05 | 0.2027 |     - |     - |     424 B |
|                      LinqAF | .NET 6.0 | .NET 6.0 |   100 | 525.36 ns | 4.615 ns | 4.091 ns |  9.11 |    0.12 |      - |     - |     - |         - |
|                  StructLinq | .NET 6.0 | .NET 6.0 |   100 | 235.99 ns | 1.331 ns | 1.040 ns |  4.09 |    0.03 | 0.0153 |     - |     - |      32 B |
|        StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 165.00 ns | 0.837 ns | 0.783 ns |  2.86 |    0.03 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 6.0 | .NET 6.0 |   100 | 202.53 ns | 0.977 ns | 0.816 ns |  3.51 |    0.03 |      - |     - |     - |         - |
| Hyperlinq_IFunction_Foreach | .NET 6.0 | .NET 6.0 |   100 | 173.40 ns | 0.299 ns | 0.265 ns |  3.01 |    0.03 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 6.0 | .NET 6.0 |   100 | 191.42 ns | 0.385 ns | 0.360 ns |  3.32 |    0.03 |      - |     - |     - |         - |
|     Hyperlinq_IFunction_For | .NET 6.0 | .NET 6.0 |   100 |  86.99 ns | 0.180 ns | 0.150 ns |  1.51 |    0.01 |      - |     - |     - |         - |
|              Hyperlinq_SIMD | .NET 6.0 | .NET 6.0 |   100 | 228.73 ns | 0.525 ns | 0.465 ns |  3.97 |    0.04 |      - |     - |     - |         - |
|    Hyperlinq_IFunction_SIMD | .NET 6.0 | .NET 6.0 |   100 | 170.39 ns | 0.156 ns | 0.122 ns |  2.96 |    0.02 |      - |     - |     - |         - |
