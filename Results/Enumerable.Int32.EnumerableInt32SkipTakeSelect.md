## Enumerable.Int32.EnumerableInt32SkipTakeSelect

### Source
[EnumerableInt32SkipTakeSelect.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32SkipTakeSelect.cs)

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
|                      Method |      Job |  Runtime | Skip | Count |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |--------- |--------- |----- |------ |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                 ForeachLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.097 μs | 0.0109 μs | 0.0097 μs |  1.00 | 0.0191 |     - |     - |      40 B |
|                        Linq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 4.781 μs | 0.0136 μs | 0.0114 μs |  1.54 | 0.0992 |     - |     - |     208 B |
|                      LinqAF | .NET 5.0 | .NET 5.0 | 1000 |   100 | 4.632 μs | 0.0193 μs | 0.0181 μs |  1.50 | 0.0153 |     - |     - |      40 B |
|                  StructLinq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.411 μs | 0.0155 μs | 0.0137 μs |  1.10 | 0.0610 |     - |     - |     128 B |
|        StructLinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.388 μs | 0.0132 μs | 0.0103 μs |  1.09 | 0.0191 |     - |     - |      40 B |
|           Hyperlinq_Foreach | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.154 μs | 0.0064 μs | 0.0053 μs |  1.02 | 0.0191 |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 | 3.016 μs | 0.0163 μs | 0.0145 μs |  0.97 | 0.0191 |     - |     - |      40 B |
|                 ForeachLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.029 μs | 0.0153 μs | 0.0136 μs |  0.98 | 0.0191 |     - |     - |      40 B |
|                        Linq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 4.694 μs | 0.0220 μs | 0.0195 μs |  1.52 | 0.0992 |     - |     - |     208 B |
|                      LinqAF | .NET 6.0 | .NET 6.0 | 1000 |   100 | 4.472 μs | 0.0325 μs | 0.0288 μs |  1.44 | 0.0153 |     - |     - |      40 B |
|                  StructLinq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.588 μs | 0.0094 μs | 0.0083 μs |  1.16 | 0.0610 |     - |     - |     128 B |
|        StructLinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.402 μs | 0.0180 μs | 0.0160 μs |  1.10 | 0.0191 |     - |     - |      40 B |
|           Hyperlinq_Foreach | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.943 μs | 0.0194 μs | 0.0182 μs |  1.27 | 0.0153 |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 | 3.782 μs | 0.0117 μs | 0.0103 μs |  1.22 | 0.0191 |     - |     - |      40 B |
