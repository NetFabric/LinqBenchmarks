## Enumerable.Int32.EnumerableInt32WhereSelectToArray

### Source
[EnumerableInt32WhereSelectToArray.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelectToArray.cs)

### References:
- Cistern.ValueLinq: [0.1.14](https://www.nuget.org/packages/Cistern.ValueLinq/0.1.14)
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


```
|                                Method |      Job |  Runtime | Count |       Mean |       Error |      StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |--------- |--------- |------ |-----------:|------------:|------------:|------:|--------:|-------:|------:|------:|----------:|
|                    ValueLinq_Standard | .NET 5.0 | .NET 5.0 |   100 | 1,050.5 ns |    19.44 ns |    23.14 ns |  1.49 |    0.04 | 0.1259 |     - |     - |     264 B |
|                       ValueLinq_Stack | .NET 5.0 | .NET 5.0 |   100 | 1,035.6 ns |    13.52 ns |    11.99 ns |  1.46 |    0.02 | 0.1259 |     - |     - |     264 B |
|             ValueLinq_SharedPool_Push | .NET 5.0 | .NET 5.0 |   100 | 1,318.0 ns |     6.84 ns |     5.34 ns |  1.86 |    0.02 | 0.1259 |     - |     - |     264 B |
|             ValueLinq_SharedPool_Pull | .NET 5.0 | .NET 5.0 |   100 | 1,214.6 ns |    10.35 ns |     9.68 ns |  1.72 |    0.02 | 0.1259 |     - |     - |     264 B |
|        ValueLinq_ValueLambda_Standard | .NET 5.0 | .NET 5.0 |   100 |   795.5 ns |     9.57 ns |     8.00 ns |  1.12 |    0.01 | 0.1259 |     - |     - |     264 B |
|           ValueLinq_ValueLambda_Stack | .NET 5.0 | .NET 5.0 |   100 |   750.9 ns |     4.13 ns |     3.66 ns |  1.06 |    0.01 | 0.1259 |     - |     - |     264 B |
| ValueLinq_ValueLambda_SharedPool_Push | .NET 5.0 | .NET 5.0 |   100 | 1,025.3 ns |     4.08 ns |     3.40 ns |  1.45 |    0.01 | 0.1259 |     - |     - |     264 B |
| ValueLinq_ValueLambda_SharedPool_Pull | .NET 5.0 | .NET 5.0 |   100 |   957.3 ns |    16.71 ns |    13.95 ns |  1.35 |    0.02 | 0.1259 |     - |     - |     264 B |
|                           ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   706.5 ns |     5.15 ns |     4.82 ns |  1.00 |    0.00 | 0.4358 |     - |     - |     912 B |
|                                  Linq | .NET 5.0 | .NET 5.0 |   100 | 1,117.1 ns |    10.32 ns |     9.66 ns |  1.58 |    0.02 | 0.3967 |     - |     - |     832 B |
|                                LinqAF | .NET 5.0 | .NET 5.0 |   100 | 9,486.5 ns | 1,154.71 ns | 3,331.59 ns | 14.56 |    5.32 |      - |     - |     - |     880 B |
|                            StructLinq | .NET 5.0 | .NET 5.0 |   100 |   995.6 ns |    14.85 ns |    12.40 ns |  1.41 |    0.02 | 0.1678 |     - |     - |     352 B |
|                  StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   764.2 ns |     5.46 ns |     4.56 ns |  1.08 |    0.01 | 0.1259 |     - |     - |     264 B |
|                             Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 1,105.3 ns |     6.99 ns |     6.20 ns |  1.56 |    0.01 | 0.1259 |     - |     - |     264 B |
|                   Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   857.5 ns |    17.21 ns |    16.90 ns |  1.22 |    0.03 | 0.1259 |     - |     - |     264 B |
|                    ValueLinq_Standard | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|                       ValueLinq_Stack | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|             ValueLinq_SharedPool_Push | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|             ValueLinq_SharedPool_Pull | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|        ValueLinq_ValueLambda_Standard | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|           ValueLinq_ValueLambda_Stack | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
| ValueLinq_ValueLambda_SharedPool_Push | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
| ValueLinq_ValueLambda_SharedPool_Pull | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|                           ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|                                  Linq | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|                                LinqAF | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|                            StructLinq | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|                  StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|                             Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |
|                   Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |         NA |          NA |          NA |     ? |       ? |      - |     - |     - |         - |

Benchmarks with issues:
  EnumerableInt32WhereSelectToArray.ValueLinq_Standard: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.ValueLinq_Stack: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.ValueLinq_SharedPool_Push: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.ValueLinq_SharedPool_Pull: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.ValueLinq_ValueLambda_Standard: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.ValueLinq_ValueLambda_Stack: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.ValueLinq_ValueLambda_SharedPool_Push: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.ValueLinq_ValueLambda_SharedPool_Pull: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.ForeachLoop: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.Linq: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.LinqAF: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.StructLinq: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.StructLinq_IFunction: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.Hyperlinq: .NET 6.0(Runtime=.NET 6.0) [Count=100]
  EnumerableInt32WhereSelectToArray.Hyperlinq_IFunction: .NET 6.0(Runtime=.NET 6.0) [Count=100]
