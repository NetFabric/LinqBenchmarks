## Range.RangeToArray

### Source
[RangeToArray.cs](../LinqBenchmarks/Range/RangeToArray.cs)

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
|         ForLoop | .NET 5.0 | .NET 5.0 |     0 |   100 | 129.93 ns | 0.561 ns | 0.524 ns |  1.00 |    0.00 | 0.2027 |     - |     - |     424 B |
|            Linq | .NET 5.0 | .NET 5.0 |     0 |   100 |  84.36 ns | 0.453 ns | 0.401 ns |  0.65 |    0.00 | 0.2218 |     - |     - |     464 B |
|      LinqFaster | .NET 5.0 | .NET 5.0 |     0 |   100 |  68.39 ns | 0.647 ns | 0.573 ns |  0.53 |    0.01 | 0.2027 |     - |     - |     424 B |
| LinqFaster_SIMD | .NET 5.0 | .NET 5.0 |     0 |   100 |  35.92 ns | 0.465 ns | 0.413 ns |  0.28 |    0.00 | 0.2027 |     - |     - |     424 B |
|          LinqAF | .NET 5.0 | .NET 5.0 |     0 |   100 | 265.41 ns | 1.760 ns | 1.560 ns |  2.04 |    0.02 | 0.2027 |     - |     - |     424 B |
|      StructLinq | .NET 5.0 | .NET 5.0 |     0 |   100 | 104.10 ns | 0.477 ns | 0.422 ns |  0.80 |    0.01 | 0.2027 |     - |     - |     424 B |
|       Hyperlinq | .NET 5.0 | .NET 5.0 |     0 |   100 |  46.27 ns | 0.345 ns | 0.306 ns |  0.36 |    0.00 | 0.2027 |     - |     - |     424 B |
|         ForLoop | .NET 6.0 | .NET 6.0 |     0 |   100 |  81.91 ns | 0.655 ns | 0.580 ns |  0.63 |    0.01 | 0.2027 |     - |     - |     424 B |
|            Linq | .NET 6.0 | .NET 6.0 |     0 |   100 |  84.45 ns | 0.549 ns | 0.514 ns |  0.65 |    0.00 | 0.2218 |     - |     - |     464 B |
|      LinqFaster | .NET 6.0 | .NET 6.0 |     0 |   100 |  71.35 ns | 0.337 ns | 0.281 ns |  0.55 |    0.00 | 0.2027 |     - |     - |     424 B |
| LinqFaster_SIMD | .NET 6.0 | .NET 6.0 |     0 |   100 |  40.02 ns | 0.233 ns | 0.217 ns |  0.31 |    0.00 | 0.2027 |     - |     - |     424 B |
|          LinqAF | .NET 6.0 | .NET 6.0 |     0 |   100 | 207.63 ns | 1.121 ns | 0.993 ns |  1.60 |    0.01 | 0.2027 |     - |     - |     424 B |
|      StructLinq | .NET 6.0 | .NET 6.0 |     0 |   100 | 109.17 ns | 0.971 ns | 0.861 ns |  0.84 |    0.01 | 0.2027 |     - |     - |     424 B |
|       Hyperlinq | .NET 6.0 | .NET 6.0 |     0 |   100 |  48.95 ns | 0.474 ns | 0.420 ns |  0.38 |    0.00 | 0.2027 |     - |     - |     424 B |
