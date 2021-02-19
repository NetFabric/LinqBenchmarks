## List.ValueType.ListValueTypeSelect

### Source
[ListValueTypeSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSelect.cs)

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
|                      Method |      Job |  Runtime | Count |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |--------- |--------- |------ |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                     ForLoop | .NET 5.0 | .NET 5.0 |   100 | 1.594 μs | 0.0052 μs | 0.0046 μs |  1.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 5.0 | .NET 5.0 |   100 | 1.773 μs | 0.0062 μs | 0.0055 μs |  1.11 |      - |     - |     - |         - |
|                        Linq | .NET 5.0 | .NET 5.0 |   100 | 2.470 μs | 0.0083 μs | 0.0078 μs |  1.55 | 0.0648 |     - |     - |     136 B |
|                  LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 2.342 μs | 0.0080 μs | 0.0071 μs |  1.47 | 1.9379 |     - |     - |   4,056 B |
|                      LinqAF | .NET 5.0 | .NET 5.0 |   100 | 3.112 μs | 0.0163 μs | 0.0144 μs |  1.95 |      - |     - |     - |         - |
|                  StructLinq | .NET 5.0 | .NET 5.0 |   100 | 1.777 μs | 0.0068 μs | 0.0060 μs |  1.12 | 0.0191 |     - |     - |      40 B |
|        StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 | 1.564 μs | 0.0089 μs | 0.0084 μs |  0.98 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 5.0 | .NET 5.0 |   100 | 1.697 μs | 0.0019 μs | 0.0016 μs |  1.06 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 5.0 | .NET 5.0 |   100 | 1.542 μs | 0.0048 μs | 0.0043 μs |  0.97 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 5.0 | .NET 5.0 |   100 | 1.695 μs | 0.0041 μs | 0.0034 μs |  1.06 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | .NET 5.0 | .NET 5.0 |   100 | 1.555 μs | 0.0052 μs | 0.0049 μs |  0.98 |      - |     - |     - |         - |
|                     ForLoop | .NET 6.0 | .NET 6.0 |   100 | 1.595 μs | 0.0076 μs | 0.0067 μs |  1.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 6.0 | .NET 6.0 |   100 | 1.799 μs | 0.0045 μs | 0.0042 μs |  1.13 |      - |     - |     - |         - |
|                        Linq | .NET 6.0 | .NET 6.0 |   100 | 2.446 μs | 0.0125 μs | 0.0105 μs |  1.53 | 0.0648 |     - |     - |     136 B |
|                  LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 2.417 μs | 0.0122 μs | 0.0102 μs |  1.52 | 1.9379 |     - |     - |   4,056 B |
|                      LinqAF | .NET 6.0 | .NET 6.0 |   100 | 2.912 μs | 0.0111 μs | 0.0098 μs |  1.83 |      - |     - |     - |         - |
|                  StructLinq | .NET 6.0 | .NET 6.0 |   100 | 1.830 μs | 0.0051 μs | 0.0045 μs |  1.15 | 0.0191 |     - |     - |      40 B |
|        StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 | 1.563 μs | 0.0062 μs | 0.0058 μs |  0.98 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 6.0 | .NET 6.0 |   100 | 1.690 μs | 0.0054 μs | 0.0045 μs |  1.06 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 6.0 | .NET 6.0 |   100 | 1.552 μs | 0.0071 μs | 0.0066 μs |  0.97 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 6.0 | .NET 6.0 |   100 | 1.703 μs | 0.0047 μs | 0.0041 μs |  1.07 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | .NET 6.0 | .NET 6.0 |   100 | 1.552 μs | 0.0044 μs | 0.0039 μs |  0.97 |      - |     - |     - |         - |
