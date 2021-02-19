## Enumerable.Int32.EnumerableInt32WhereSelectToArray

### Source
[EnumerableInt32WhereSelectToArray.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelectToArray.cs)

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
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   648.0 ns | 3.71 ns | 3.47 ns |  1.00 | 0.4358 |     - |     - |     912 B |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 |   991.3 ns | 3.65 ns | 3.24 ns |  1.53 | 0.3967 |     - |     - |     832 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 1,146.0 ns | 7.75 ns | 6.87 ns |  1.77 | 0.4196 |     - |     - |     880 B |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |   972.7 ns | 4.17 ns | 3.69 ns |  1.50 | 0.1678 |     - |     - |     352 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   727.1 ns | 3.70 ns | 3.46 ns |  1.12 | 0.1259 |     - |     - |     264 B |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |   980.9 ns | 4.09 ns | 3.82 ns |  1.51 | 0.1259 |     - |     - |     264 B |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   885.4 ns | 5.74 ns | 4.80 ns |  1.37 | 0.1259 |     - |     - |     264 B |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   701.7 ns | 3.78 ns | 3.35 ns |  1.08 | 0.4358 |     - |     - |     912 B |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 1,026.0 ns | 5.52 ns | 4.90 ns |  1.58 | 0.3967 |     - |     - |     832 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 1,187.3 ns | 7.74 ns | 6.47 ns |  1.83 | 0.4196 |     - |     - |     880 B |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |   942.8 ns | 2.39 ns | 2.00 ns |  1.46 | 0.1678 |     - |     - |     352 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   777.2 ns | 4.53 ns | 4.23 ns |  1.20 | 0.1259 |     - |     - |     264 B |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 1,062.6 ns | 4.34 ns | 3.62 ns |  1.64 | 0.1259 |     - |     - |     264 B |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   783.1 ns | 2.04 ns | 1.81 ns |  1.21 | 0.1259 |     - |     - |     264 B |
