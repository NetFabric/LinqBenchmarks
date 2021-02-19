## Range.RangeToList

### Source
[RangeToList.cs](../LinqBenchmarks/Range/RangeToList.cs)

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
|      Method |      Job |  Runtime | Start | Count |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |--------- |--------- |------ |------ |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|     ForLoop | .NET 5.0 | .NET 5.0 |     0 |   100 | 281.59 ns | 1.829 ns | 1.621 ns |  1.00 |    0.00 | 0.5660 |     - |     - |   1,184 B |
| ForeachLoop | .NET 5.0 | .NET 5.0 |     0 |   100 | 788.32 ns | 7.252 ns | 6.429 ns |  2.80 |    0.02 | 0.5922 |     - |     - |   1,240 B |
|        Linq | .NET 5.0 | .NET 5.0 |     0 |   100 | 207.81 ns | 0.864 ns | 0.721 ns |  0.74 |    0.01 | 0.2370 |     - |     - |     496 B |
|  LinqFaster | .NET 5.0 | .NET 5.0 |     0 |   100 | 120.25 ns | 0.760 ns | 0.711 ns |  0.43 |    0.00 | 0.4206 |     - |     - |     880 B |
|      LinqAF | .NET 5.0 | .NET 5.0 |     0 |   100 | 347.10 ns | 1.451 ns | 1.286 ns |  1.23 |    0.01 | 0.2179 |     - |     - |     456 B |
|  StructLinq | .NET 5.0 | .NET 5.0 |     0 |   100 |  88.73 ns | 0.648 ns | 0.574 ns |  0.32 |    0.00 | 0.2180 |     - |     - |     456 B |
|   Hyperlinq | .NET 5.0 | .NET 5.0 |     0 |   100 |  52.79 ns | 0.475 ns | 0.421 ns |  0.19 |    0.00 | 0.2180 |     - |     - |     456 B |
|     ForLoop | .NET 6.0 | .NET 6.0 |     0 |   100 | 288.45 ns | 2.790 ns | 2.473 ns |  1.02 |    0.01 | 0.5660 |     - |     - |   1,184 B |
| ForeachLoop | .NET 6.0 | .NET 6.0 |     0 |   100 | 766.46 ns | 5.610 ns | 4.684 ns |  2.72 |    0.02 | 0.5922 |     - |     - |   1,240 B |
|        Linq | .NET 6.0 | .NET 6.0 |     0 |   100 | 209.37 ns | 1.444 ns | 1.280 ns |  0.74 |    0.01 | 0.2370 |     - |     - |     496 B |
|  LinqFaster | .NET 6.0 | .NET 6.0 |     0 |   100 | 124.40 ns | 1.611 ns | 1.428 ns |  0.44 |    0.00 | 0.4206 |     - |     - |     880 B |
|      LinqAF | .NET 6.0 | .NET 6.0 |     0 |   100 | 262.30 ns | 0.878 ns | 0.779 ns |  0.93 |    0.01 | 0.2179 |     - |     - |     456 B |
|  StructLinq | .NET 6.0 | .NET 6.0 |     0 |   100 |  95.24 ns | 1.066 ns | 0.997 ns |  0.34 |    0.00 | 0.2180 |     - |     - |     456 B |
|   Hyperlinq | .NET 6.0 | .NET 6.0 |     0 |   100 |  57.17 ns | 0.673 ns | 0.562 ns |  0.20 |    0.00 | 0.2180 |     - |     - |     456 B |
