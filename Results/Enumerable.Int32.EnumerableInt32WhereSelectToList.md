## Enumerable.Int32.EnumerableInt32WhereSelectToList

### Source
[EnumerableInt32WhereSelectToList.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelectToList.cs)

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
|               Method |      Job |  Runtime | Count |       Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |-----------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   692.1 ns | 2.26 ns | 2.11 ns |  1.00 | 0.3281 |     - |     - |     688 B |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 1,025.3 ns | 7.78 ns | 6.90 ns |  1.48 | 0.3853 |     - |     - |     808 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 1,098.6 ns | 4.14 ns | 3.23 ns |  1.59 | 0.3281 |     - |     - |     688 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 1,019.8 ns | 4.70 ns | 4.39 ns |  1.47 | 0.1831 |     - |     - |     384 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   731.9 ns | 2.19 ns | 1.94 ns |  1.06 | 0.1411 |     - |     - |     296 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 1,022.7 ns | 5.18 ns | 4.33 ns |  1.48 | 0.1411 |     - |     - |     296 B |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   812.4 ns | 3.03 ns | 2.68 ns |  1.17 | 0.1411 |     - |     - |     296 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   690.8 ns | 2.64 ns | 2.34 ns |  1.00 | 0.3281 |     - |     - |     688 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 |   974.1 ns | 2.96 ns | 2.47 ns |  1.41 | 0.3853 |     - |     - |     808 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 1,112.8 ns | 6.13 ns | 5.74 ns |  1.61 | 0.3281 |     - |     - |     688 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |   953.6 ns | 4.05 ns | 3.39 ns |  1.38 | 0.1831 |     - |     - |     384 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   821.6 ns | 3.88 ns | 3.44 ns |  1.19 | 0.1411 |     - |     - |     296 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 1,005.6 ns | 2.94 ns | 2.61 ns |  1.45 | 0.1411 |     - |     - |     296 B |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   819.3 ns | 2.66 ns | 2.22 ns |  1.18 | 0.1411 |     - |     - |     296 B |
