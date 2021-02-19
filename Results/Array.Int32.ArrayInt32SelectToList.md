## Array.Int32.ArrayInt32SelectToList

### Source
[ArrayInt32SelectToList.cs](../LinqBenchmarks/Array/Int32/ArrayInt32SelectToList.cs)

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
|                   Method |      Job |  Runtime | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |--------- |--------- |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                  ForLoop | .NET 5.0 | .NET 5.0 |   100 | 304.72 ns | 5.847 ns | 5.742 ns |  1.00 |    0.00 | 0.5660 |     - |     - |   1,184 B |
|              ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 325.40 ns | 1.492 ns | 1.396 ns |  1.07 |    0.02 | 0.5660 |     - |     - |   1,184 B |
|                     Linq | .NET 5.0 | .NET 5.0 |   100 | 306.21 ns | 1.162 ns | 1.087 ns |  1.01 |    0.02 | 0.2408 |     - |     - |     504 B |
|               LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 264.48 ns | 1.847 ns | 1.542 ns |  0.87 |    0.02 | 0.4206 |     - |     - |     880 B |
|          LinqFaster_SIMD | .NET 5.0 | .NET 5.0 |   100 | 109.64 ns | 0.787 ns | 0.736 ns |  0.36 |    0.01 | 0.4207 |     - |     - |     880 B |
|                   LinqAF | .NET 5.0 | .NET 5.0 |   100 | 872.42 ns | 3.525 ns | 3.297 ns |  2.86 |    0.05 | 0.5655 |     - |     - |   1,184 B |
|               StructLinq | .NET 5.0 | .NET 5.0 |   100 | 243.53 ns | 1.269 ns | 1.125 ns |  0.80 |    0.02 | 0.2484 |     - |     - |     520 B |
|     StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 130.05 ns | 0.579 ns | 0.541 ns |  0.43 |    0.01 | 0.2370 |     - |     - |     496 B |
|                Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 227.77 ns | 0.646 ns | 0.573 ns |  0.75 |    0.01 | 0.2179 |     - |     - |     456 B |
|      Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 143.21 ns | 0.893 ns | 0.697 ns |  0.47 |    0.01 | 0.2179 |     - |     - |     456 B |
|           Hyperlinq_SIMD | .NET 5.0 | .NET 5.0 |   100 |  87.93 ns | 1.185 ns | 1.108 ns |  0.29 |    0.01 | 0.2180 |     - |     - |     456 B |
| Hyperlinq_IFunction_SIMD | .NET 5.0 | .NET 5.0 |   100 |  56.46 ns | 0.332 ns | 0.294 ns |  0.19 |    0.00 | 0.2180 |     - |     - |     456 B |
|                  ForLoop | .NET 6.0 | .NET 6.0 |   100 | 313.28 ns | 3.022 ns | 2.679 ns |  1.03 |    0.02 | 0.5660 |     - |     - |   1,184 B |
|              ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 313.20 ns | 2.014 ns | 1.884 ns |  1.03 |    0.02 | 0.5660 |     - |     - |   1,184 B |
|                     Linq | .NET 6.0 | .NET 6.0 |   100 | 297.20 ns | 2.293 ns | 1.790 ns |  0.97 |    0.02 | 0.2408 |     - |     - |     504 B |
|               LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 269.36 ns | 1.365 ns | 1.276 ns |  0.88 |    0.02 | 0.4206 |     - |     - |     880 B |
|          LinqFaster_SIMD | .NET 6.0 | .NET 6.0 |   100 | 292.85 ns | 1.758 ns | 1.372 ns |  0.96 |    0.02 | 0.4206 |     - |     - |     880 B |
|                   LinqAF | .NET 6.0 | .NET 6.0 |   100 | 919.21 ns | 6.084 ns | 5.394 ns |  3.01 |    0.07 | 0.5655 |     - |     - |   1,184 B |
|               StructLinq | .NET 6.0 | .NET 6.0 |   100 | 259.36 ns | 1.788 ns | 1.585 ns |  0.85 |    0.02 | 0.2484 |     - |     - |     520 B |
|     StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 138.21 ns | 0.809 ns | 0.757 ns |  0.45 |    0.01 | 0.2370 |     - |     - |     496 B |
|                Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 236.73 ns | 1.304 ns | 1.220 ns |  0.78 |    0.02 | 0.2179 |     - |     - |     456 B |
|      Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 148.26 ns | 0.922 ns | 0.817 ns |  0.49 |    0.01 | 0.2179 |     - |     - |     456 B |
|           Hyperlinq_SIMD | .NET 6.0 | .NET 6.0 |   100 | 263.83 ns | 1.609 ns | 1.505 ns |  0.87 |    0.02 | 0.2179 |     - |     - |     456 B |
| Hyperlinq_IFunction_SIMD | .NET 6.0 | .NET 6.0 |   100 | 148.58 ns | 0.754 ns | 0.668 ns |  0.49 |    0.01 | 0.2179 |     - |     - |     456 B |
