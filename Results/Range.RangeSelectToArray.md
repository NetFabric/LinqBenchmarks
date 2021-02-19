## Range.RangeSelectToArray

### Source
[RangeSelectToArray.cs](../LinqBenchmarks/Range/RangeSelectToArray.cs)

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
|                   Method |      Job |  Runtime | Start | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |--------- |--------- |------ |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                  ForLoop | .NET 5.0 | .NET 5.0 |     0 |   100 |  84.51 ns | 0.816 ns | 0.682 ns |  1.00 |    0.00 | 0.2027 |     - |     - |     424 B |
|                     Linq | .NET 5.0 | .NET 5.0 |     0 |   100 | 226.74 ns | 1.751 ns | 1.552 ns |  2.68 |    0.04 | 0.2446 |     - |     - |     512 B |
|               LinqFaster | .NET 5.0 | .NET 5.0 |     0 |   100 | 265.13 ns | 1.104 ns | 1.033 ns |  3.14 |    0.03 | 0.4053 |     - |     - |     848 B |
|          LinqFaster_SIMD | .NET 5.0 | .NET 5.0 |     0 |   100 | 100.88 ns | 0.601 ns | 0.533 ns |  1.19 |    0.01 | 0.4054 |     - |     - |     848 B |
|                   LinqAF | .NET 5.0 | .NET 5.0 |     0 |   100 | 817.13 ns | 3.430 ns | 3.041 ns |  9.67 |    0.10 | 0.7534 |     - |     - |   1,576 B |
|               StructLinq | .NET 5.0 | .NET 5.0 |     0 |   100 | 256.28 ns | 1.272 ns | 1.190 ns |  3.03 |    0.04 | 0.2294 |     - |     - |     480 B |
|     StructLinq_IFunction | .NET 5.0 | .NET 5.0 |     0 |   100 |  92.99 ns | 0.335 ns | 0.262 ns |  1.10 |    0.01 | 0.2027 |     - |     - |     424 B |
|                Hyperlinq | .NET 5.0 | .NET 5.0 |     0 |   100 | 206.39 ns | 0.606 ns | 0.506 ns |  2.44 |    0.02 | 0.2027 |     - |     - |     424 B |
|      Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |     0 |   100 | 114.44 ns | 0.733 ns | 0.612 ns |  1.35 |    0.01 | 0.2027 |     - |     - |     424 B |
|           Hyperlinq_SIMD | .NET 5.0 | .NET 5.0 |     0 |   100 |  94.80 ns | 0.458 ns | 0.383 ns |  1.12 |    0.01 | 0.2027 |     - |     - |     424 B |
| Hyperlinq_IFunction_SIMD | .NET 5.0 | .NET 5.0 |     0 |   100 |  63.97 ns | 0.414 ns | 0.367 ns |  0.76 |    0.01 | 0.2027 |     - |     - |     424 B |
|                  ForLoop | .NET 6.0 | .NET 6.0 |     0 |   100 |  88.43 ns | 0.731 ns | 0.611 ns |  1.05 |    0.01 | 0.2027 |     - |     - |     424 B |
|                     Linq | .NET 6.0 | .NET 6.0 |     0 |   100 | 222.19 ns | 1.352 ns | 1.198 ns |  2.63 |    0.02 | 0.2446 |     - |     - |     512 B |
|               LinqFaster | .NET 6.0 | .NET 6.0 |     0 |   100 | 288.72 ns | 2.305 ns | 2.156 ns |  3.42 |    0.04 | 0.4053 |     - |     - |     848 B |
|          LinqFaster_SIMD | .NET 6.0 | .NET 6.0 |     0 |   100 | 280.98 ns | 1.422 ns | 1.110 ns |  3.32 |    0.03 | 0.4053 |     - |     - |     848 B |
|                   LinqAF | .NET 6.0 | .NET 6.0 |     0 |   100 | 802.67 ns | 3.746 ns | 3.128 ns |  9.50 |    0.09 | 0.7534 |     - |     - |   1,576 B |
|               StructLinq | .NET 6.0 | .NET 6.0 |     0 |   100 | 211.09 ns | 1.733 ns | 1.536 ns |  2.50 |    0.03 | 0.2294 |     - |     - |     480 B |
|     StructLinq_IFunction | .NET 6.0 | .NET 6.0 |     0 |   100 |  97.60 ns | 0.472 ns | 0.418 ns |  1.15 |    0.01 | 0.2027 |     - |     - |     424 B |
|                Hyperlinq | .NET 6.0 | .NET 6.0 |     0 |   100 | 232.24 ns | 1.419 ns | 1.185 ns |  2.75 |    0.03 | 0.2027 |     - |     - |     424 B |
|      Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |     0 |   100 | 143.62 ns | 0.620 ns | 0.518 ns |  1.70 |    0.02 | 0.2027 |     - |     - |     424 B |
|           Hyperlinq_SIMD | .NET 6.0 | .NET 6.0 |     0 |   100 | 272.16 ns | 1.766 ns | 1.565 ns |  3.22 |    0.04 | 0.2027 |     - |     - |     424 B |
| Hyperlinq_IFunction_SIMD | .NET 6.0 | .NET 6.0 |     0 |   100 | 158.66 ns | 0.478 ns | 0.424 ns |  1.88 |    0.02 | 0.2027 |     - |     - |     424 B |
