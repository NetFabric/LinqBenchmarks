## Range.Range

### Source
[Range.cs](../LinqBenchmarks/Range/Range.cs)

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
|          Method |      Job |  Runtime | Start | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------- |--------- |--------- |------ |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|         ForLoop | .NET 5.0 | .NET 5.0 |     0 |   100 |  33.69 ns | 0.124 ns | 0.116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|     ForeachLoop | .NET 5.0 | .NET 5.0 |     0 |   100 | 498.67 ns | 1.630 ns | 1.445 ns | 14.80 |    0.07 | 0.0267 |     - |     - |      56 B |
|            Linq | .NET 5.0 | .NET 5.0 |     0 |   100 | 422.68 ns | 1.849 ns | 1.639 ns | 12.54 |    0.08 | 0.0191 |     - |     - |      40 B |
|      LinqFaster | .NET 5.0 | .NET 5.0 |     0 |   100 | 124.19 ns | 0.809 ns | 0.717 ns |  3.69 |    0.03 | 0.2027 |     - |     - |     424 B |
| LinqFaster_SIMD | .NET 5.0 | .NET 5.0 |     0 |   100 |  96.27 ns | 0.784 ns | 0.695 ns |  2.86 |    0.02 | 0.2027 |     - |     - |     424 B |
|          LinqAF | .NET 5.0 | .NET 5.0 |     0 |   100 | 221.01 ns | 0.484 ns | 0.404 ns |  6.56 |    0.03 |      - |     - |     - |         - |
|      StructLinq | .NET 5.0 | .NET 5.0 |     0 |   100 |  34.18 ns | 0.103 ns | 0.096 ns |  1.01 |    0.00 |      - |     - |     - |         - |
|       Hyperlinq | .NET 5.0 | .NET 5.0 |     0 |   100 |  43.84 ns | 0.118 ns | 0.099 ns |  1.30 |    0.00 |      - |     - |     - |         - |
|         ForLoop | .NET 6.0 | .NET 6.0 |     0 |   100 |  33.69 ns | 0.252 ns | 0.223 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|     ForeachLoop | .NET 6.0 | .NET 6.0 |     0 |   100 | 444.54 ns | 2.021 ns | 1.792 ns | 13.19 |    0.08 | 0.0267 |     - |     - |      56 B |
|            Linq | .NET 6.0 | .NET 6.0 |     0 |   100 | 394.15 ns | 0.726 ns | 0.567 ns | 11.69 |    0.05 | 0.0191 |     - |     - |      40 B |
|      LinqFaster | .NET 6.0 | .NET 6.0 |     0 |   100 | 126.15 ns | 0.955 ns | 0.893 ns |  3.74 |    0.03 | 0.2027 |     - |     - |     424 B |
| LinqFaster_SIMD | .NET 6.0 | .NET 6.0 |     0 |   100 |  86.77 ns | 0.527 ns | 0.467 ns |  2.58 |    0.02 | 0.2027 |     - |     - |     424 B |
|          LinqAF | .NET 6.0 | .NET 6.0 |     0 |   100 | 161.46 ns | 0.477 ns | 0.423 ns |  4.79 |    0.02 |      - |     - |     - |         - |
|      StructLinq | .NET 6.0 | .NET 6.0 |     0 |   100 |  34.15 ns | 0.301 ns | 0.266 ns |  1.01 |    0.01 |      - |     - |     - |         - |
|       Hyperlinq | .NET 6.0 | .NET 6.0 |     0 |   100 |  44.64 ns | 0.108 ns | 0.096 ns |  1.32 |    0.01 |      - |     - |     - |         - |
