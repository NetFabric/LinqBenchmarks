## List.Int32.ListInt32SkipTakeSelect

### Source
[ListInt32SkipTakeSelect.cs](../LinqBenchmarks/List/Int32/ListInt32SkipTakeSelect.cs)

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
|                      Method |      Job |  Runtime | Skip | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |--------- |--------- |----- |------ |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 |    84.27 ns |  0.325 ns |  0.271 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 | 4,500.94 ns | 32.114 ns | 26.816 ns | 53.41 |    0.40 | 0.0153 |     - |     - |      40 B |
|                        Linq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   986.17 ns |  4.455 ns |  3.949 ns | 11.70 |    0.07 | 0.0725 |     - |     - |     152 B |
|                  LinqFaster | .NET 5.0 | .NET 5.0 | 1000 |   100 |   782.27 ns |  2.710 ns |  2.403 ns |  9.28 |    0.04 | 0.6533 |     - |     - |   1,368 B |
|                      LinqAF | .NET 5.0 | .NET 5.0 | 1000 |   100 | 5,065.10 ns | 17.057 ns | 15.955 ns | 60.13 |    0.27 |      - |     - |     - |         - |
|                  StructLinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   254.44 ns |  1.260 ns |  1.117 ns |  3.02 |    0.02 | 0.0458 |     - |     - |      96 B |
|        StructLinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   167.78 ns |  0.404 ns |  0.358 ns |  1.99 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 5.0 | .NET 5.0 | 1000 |   100 |   210.34 ns |  1.211 ns |  1.074 ns |  2.50 |    0.02 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   178.88 ns |  0.701 ns |  0.622 ns |  2.12 |    0.01 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 5.0 | .NET 5.0 | 1000 |   100 |   223.09 ns |  0.973 ns |  0.863 ns |  2.65 |    0.01 |      - |     - |     - |         - |
|                     ForLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 |    84.12 ns |  0.369 ns |  0.308 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 | 4,435.76 ns | 17.981 ns | 15.939 ns | 52.62 |    0.27 | 0.0153 |     - |     - |      40 B |
|                        Linq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   942.78 ns |  6.430 ns |  5.370 ns | 11.19 |    0.07 | 0.0725 |     - |     - |     152 B |
|                  LinqFaster | .NET 6.0 | .NET 6.0 | 1000 |   100 |   778.72 ns |  4.027 ns |  3.570 ns |  9.24 |    0.06 | 0.6533 |     - |     - |   1,368 B |
|                      LinqAF | .NET 6.0 | .NET 6.0 | 1000 |   100 | 5,457.55 ns | 25.084 ns | 22.237 ns | 64.73 |    0.30 |      - |     - |     - |         - |
|                  StructLinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   255.36 ns |  0.941 ns |  0.734 ns |  3.03 |    0.01 | 0.0458 |     - |     - |      96 B |
|        StructLinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   168.40 ns |  0.823 ns |  0.729 ns |  2.00 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 6.0 | .NET 6.0 | 1000 |   100 |   208.52 ns |  1.113 ns |  0.929 ns |  2.47 |    0.02 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   188.57 ns |  0.952 ns |  0.890 ns |  2.24 |    0.01 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 6.0 | .NET 6.0 | 1000 |   100 |   224.10 ns |  1.201 ns |  1.065 ns |  2.66 |    0.01 |      - |     - |     - |         - |
