## Enumerable.Int32.EnumerableInt32Select

### Source
[EnumerableInt32Select.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Select.cs)

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
|                      Method |      Job |  Runtime | Count |       Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |--------- |--------- |------ |-----------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|                 ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   420.4 ns | 2.27 ns | 2.01 ns |  1.00 | 0.0191 |     - |     - |      40 B |
|                        Linq | .NET 5.0 | .NET 5.0 |   100 | 1,005.4 ns | 3.60 ns | 3.19 ns |  2.39 | 0.0458 |     - |     - |      96 B |
|                      LinqAF | .NET 5.0 | .NET 5.0 |   100 |   853.6 ns | 3.39 ns | 3.00 ns |  2.03 | 0.0191 |     - |     - |      40 B |
|                  StructLinq | .NET 5.0 | .NET 5.0 |   100 |   616.5 ns | 1.56 ns | 1.22 ns |  1.47 | 0.0305 |     - |     - |      64 B |
|        StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   448.7 ns | 1.65 ns | 1.46 ns |  1.07 | 0.0191 |     - |     - |      40 B |
|           Hyperlinq_Foreach | .NET 5.0 | .NET 5.0 |   100 |   626.4 ns | 2.08 ns | 1.63 ns |  1.49 | 0.0191 |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction | .NET 5.0 | .NET 5.0 |   100 |   470.2 ns | 1.40 ns | 1.17 ns |  1.12 | 0.0191 |     - |     - |      40 B |
|                 ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   436.9 ns | 1.14 ns | 0.95 ns |  1.04 | 0.0191 |     - |     - |      40 B |
|                        Linq | .NET 6.0 | .NET 6.0 |   100 | 1,039.4 ns | 4.15 ns | 3.46 ns |  2.47 | 0.0458 |     - |     - |      96 B |
|                      LinqAF | .NET 6.0 | .NET 6.0 |   100 |   811.2 ns | 2.35 ns | 2.08 ns |  1.93 | 0.0191 |     - |     - |      40 B |
|                  StructLinq | .NET 6.0 | .NET 6.0 |   100 |   613.4 ns | 1.92 ns | 1.71 ns |  1.46 | 0.0305 |     - |     - |      64 B |
|        StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   442.5 ns | 2.72 ns | 2.41 ns |  1.05 | 0.0191 |     - |     - |      40 B |
|           Hyperlinq_Foreach | .NET 6.0 | .NET 6.0 |   100 |   631.5 ns | 4.61 ns | 3.85 ns |  1.50 | 0.0191 |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction | .NET 6.0 | .NET 6.0 |   100 |   492.3 ns | 2.45 ns | 2.17 ns |  1.17 | 0.0191 |     - |     - |      40 B |
