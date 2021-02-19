## Range.RangeSelectToList

### Source
[RangeSelectToList.cs](../LinqBenchmarks/Range/RangeSelectToList.cs)

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
|                  ForLoop | .NET 5.0 | .NET 5.0 |     0 |   100 | 281.81 ns | 3.938 ns | 3.491 ns |  1.00 |    0.00 | 0.5660 |     - |     - |   1,184 B |
|              ForeachLoop | .NET 5.0 | .NET 5.0 |     0 |   100 | 745.39 ns | 3.482 ns | 2.718 ns |  2.65 |    0.03 | 0.5922 |     - |     - |   1,240 B |
|                     Linq | .NET 5.0 | .NET 5.0 |     0 |   100 | 322.84 ns | 1.409 ns | 1.177 ns |  1.15 |    0.01 | 0.2599 |     - |     - |     544 B |
|               LinqFaster | .NET 5.0 | .NET 5.0 |     0 |   100 | 333.47 ns | 2.546 ns | 2.382 ns |  1.18 |    0.02 | 0.6232 |     - |     - |   1,304 B |
|                   LinqAF | .NET 5.0 | .NET 5.0 |     0 |   100 | 782.17 ns | 2.956 ns | 2.469 ns |  2.78 |    0.04 | 0.5655 |     - |     - |   1,184 B |
|               StructLinq | .NET 5.0 | .NET 5.0 |     0 |   100 | 238.89 ns | 1.243 ns | 1.102 ns |  0.85 |    0.01 | 0.2446 |     - |     - |     512 B |
|     StructLinq_IFunction | .NET 5.0 | .NET 5.0 |     0 |   100 | 108.32 ns | 0.649 ns | 0.607 ns |  0.38 |    0.01 | 0.2180 |     - |     - |     456 B |
|                Hyperlinq | .NET 5.0 | .NET 5.0 |     0 |   100 | 225.18 ns | 1.160 ns | 0.968 ns |  0.80 |    0.01 | 0.2179 |     - |     - |     456 B |
|      Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |     0 |   100 | 150.33 ns | 0.955 ns | 0.745 ns |  0.53 |    0.01 | 0.2179 |     - |     - |     456 B |
|           Hyperlinq_SIMD | .NET 5.0 | .NET 5.0 |     0 |   100 | 106.13 ns | 0.599 ns | 0.500 ns |  0.38 |    0.00 | 0.2180 |     - |     - |     456 B |
| Hyperlinq_IFunction_SIMD | .NET 5.0 | .NET 5.0 |     0 |   100 |  71.95 ns | 0.563 ns | 0.499 ns |  0.26 |    0.00 | 0.2180 |     - |     - |     456 B |
|                  ForLoop | .NET 6.0 | .NET 6.0 |     0 |   100 | 293.61 ns | 1.925 ns | 1.706 ns |  1.04 |    0.01 | 0.5660 |     - |     - |   1,184 B |
|              ForeachLoop | .NET 6.0 | .NET 6.0 |     0 |   100 | 698.80 ns | 2.919 ns | 2.587 ns |  2.48 |    0.03 | 0.5922 |     - |     - |   1,240 B |
|                     Linq | .NET 6.0 | .NET 6.0 |     0 |   100 | 312.41 ns | 1.063 ns | 0.994 ns |  1.11 |    0.01 | 0.2599 |     - |     - |     544 B |
|               LinqFaster | .NET 6.0 | .NET 6.0 |     0 |   100 | 320.02 ns | 1.670 ns | 1.395 ns |  1.14 |    0.01 | 0.6232 |     - |     - |   1,304 B |
|                   LinqAF | .NET 6.0 | .NET 6.0 |     0 |   100 | 822.00 ns | 5.938 ns | 5.264 ns |  2.92 |    0.05 | 0.5655 |     - |     - |   1,184 B |
|               StructLinq | .NET 6.0 | .NET 6.0 |     0 |   100 | 245.06 ns | 1.611 ns | 1.428 ns |  0.87 |    0.01 | 0.2446 |     - |     - |     512 B |
|     StructLinq_IFunction | .NET 6.0 | .NET 6.0 |     0 |   100 | 108.38 ns | 0.488 ns | 0.408 ns |  0.39 |    0.01 | 0.2180 |     - |     - |     456 B |
|                Hyperlinq | .NET 6.0 | .NET 6.0 |     0 |   100 | 269.37 ns | 0.936 ns | 0.781 ns |  0.96 |    0.01 | 0.2179 |     - |     - |     456 B |
|      Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |     0 |   100 | 155.18 ns | 0.607 ns | 0.506 ns |  0.55 |    0.01 | 0.2179 |     - |     - |     456 B |
|           Hyperlinq_SIMD | .NET 6.0 | .NET 6.0 |     0 |   100 | 287.51 ns | 0.870 ns | 0.771 ns |  1.02 |    0.01 | 0.2179 |     - |     - |     456 B |
| Hyperlinq_IFunction_SIMD | .NET 6.0 | .NET 6.0 |     0 |   100 | 170.53 ns | 0.549 ns | 0.514 ns |  0.61 |    0.01 | 0.2179 |     - |     - |     456 B |
