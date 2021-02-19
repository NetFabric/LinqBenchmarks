## Range.RangeSelect

### Source
[RangeSelect.cs](../LinqBenchmarks/Range/RangeSelect.cs)

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
|               Method |      Job |  Runtime | Start | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |     0 |   100 |  39.06 ns | 0.103 ns | 0.097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |     0 |   100 | 499.75 ns | 3.634 ns | 3.222 ns | 12.80 |    0.09 | 0.0267 |     - |     - |      56 B |
|                 Linq | .NET 5.0 | .NET 5.0 |     0 |   100 | 652.45 ns | 1.815 ns | 1.609 ns | 16.71 |    0.05 | 0.0420 |     - |     - |      88 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |     0 |   100 | 338.82 ns | 2.101 ns | 1.965 ns |  8.68 |    0.06 | 0.4053 |     - |     - |     848 B |
|      LinqFaster_SIMD | .NET 5.0 | .NET 5.0 |     0 |   100 | 158.32 ns | 1.004 ns | 0.939 ns |  4.05 |    0.02 | 0.4053 |     - |     - |     848 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |     0 |   100 | 471.45 ns | 2.016 ns | 1.886 ns | 12.07 |    0.05 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |     0 |   100 | 229.86 ns | 1.546 ns | 1.446 ns |  5.89 |    0.04 | 0.0114 |     - |     - |      24 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |     0 |   100 | 164.87 ns | 0.686 ns | 0.608 ns |  4.22 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |     0 |   100 | 209.24 ns | 1.012 ns | 0.897 ns |  5.36 |    0.03 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |     0 |   100 | 171.09 ns | 0.979 ns | 0.818 ns |  4.38 |    0.02 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |     0 |   100 |  37.97 ns | 0.159 ns | 0.133 ns |  0.97 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |     0 |   100 | 472.05 ns | 2.554 ns | 2.264 ns | 12.09 |    0.07 | 0.0267 |     - |     - |      56 B |
|                 Linq | .NET 6.0 | .NET 6.0 |     0 |   100 | 623.56 ns | 4.239 ns | 3.758 ns | 15.97 |    0.10 | 0.0420 |     - |     - |      88 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |     0 |   100 | 315.41 ns | 2.351 ns | 1.964 ns |  8.08 |    0.06 | 0.4053 |     - |     - |     848 B |
|      LinqFaster_SIMD | .NET 6.0 | .NET 6.0 |     0 |   100 | 345.93 ns | 1.985 ns | 1.657 ns |  8.86 |    0.04 | 0.4053 |     - |     - |     848 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |     0 |   100 | 499.35 ns | 2.382 ns | 2.228 ns | 12.79 |    0.07 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |     0 |   100 | 228.01 ns | 0.392 ns | 0.306 ns |  5.84 |    0.02 | 0.0114 |     - |     - |      24 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |     0 |   100 | 163.56 ns | 0.253 ns | 0.225 ns |  4.19 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |     0 |   100 | 208.75 ns | 0.685 ns | 0.641 ns |  5.34 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |     0 |   100 | 171.78 ns | 0.565 ns | 0.500 ns |  4.40 |    0.01 |      - |     - |     - |         - |
