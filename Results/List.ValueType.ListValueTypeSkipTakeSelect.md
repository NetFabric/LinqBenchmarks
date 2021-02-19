## List.ValueType.ListValueTypeSkipTakeSelect

### Source
[ListValueTypeSkipTakeSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSkipTakeSelect.cs)

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
|                      Method |      Job |  Runtime | Skip | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |--------- |--------- |----- |------ |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                     ForLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 |  1.597 μs | 0.0082 μs | 0.0073 μs |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 |  6.792 μs | 0.0248 μs | 0.0219 μs |  4.25 |    0.02 | 0.0305 |     - |     - |      72 B |
|                        Linq | .NET 5.0 | .NET 5.0 | 1000 |   100 |  2.500 μs | 0.0090 μs | 0.0075 μs |  1.57 |    0.01 | 0.1183 |     - |     - |     248 B |
|                  LinqFaster | .NET 5.0 | .NET 5.0 | 1000 |   100 |  3.549 μs | 0.0410 μs | 0.0384 μs |  2.22 |    0.02 | 5.8136 |     - |     - |  12,168 B |
|                      LinqAF | .NET 5.0 | .NET 5.0 | 1000 |   100 |  9.913 μs | 0.1605 μs | 0.1423 μs |  6.21 |    0.09 |      - |     - |     - |         - |
|                  StructLinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |  1.823 μs | 0.0046 μs | 0.0041 μs |  1.14 |    0.01 | 0.0572 |     - |     - |     120 B |
|        StructLinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |  1.573 μs | 0.0056 μs | 0.0052 μs |  0.98 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 5.0 | .NET 5.0 | 1000 |   100 |  1.708 μs | 0.0043 μs | 0.0038 μs |  1.07 |    0.00 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |  1.541 μs | 0.0068 μs | 0.0063 μs |  0.96 |    0.01 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 5.0 | .NET 5.0 | 1000 |   100 |  1.684 μs | 0.0024 μs | 0.0021 μs |  1.05 |    0.00 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |  1.536 μs | 0.0067 μs | 0.0056 μs |  0.96 |    0.00 |      - |     - |     - |         - |
|                     ForLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 |  1.594 μs | 0.0045 μs | 0.0037 μs |  1.00 |    0.00 |      - |     - |     - |         - |
|                 ForeachLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 |  6.699 μs | 0.0291 μs | 0.0243 μs |  4.20 |    0.03 | 0.0305 |     - |     - |      72 B |
|                        Linq | .NET 6.0 | .NET 6.0 | 1000 |   100 |  2.460 μs | 0.0082 μs | 0.0073 μs |  1.54 |    0.01 | 0.1183 |     - |     - |     248 B |
|                  LinqFaster | .NET 6.0 | .NET 6.0 | 1000 |   100 |  3.665 μs | 0.0407 μs | 0.0381 μs |  2.30 |    0.03 | 5.8136 |     - |     - |  12,168 B |
|                      LinqAF | .NET 6.0 | .NET 6.0 | 1000 |   100 | 10.350 μs | 0.1834 μs | 0.1626 μs |  6.48 |    0.10 |      - |     - |     - |         - |
|                  StructLinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |  1.835 μs | 0.0051 μs | 0.0048 μs |  1.15 |    0.01 | 0.0572 |     - |     - |     120 B |
|        StructLinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |  1.597 μs | 0.0040 μs | 0.0035 μs |  1.00 |    0.00 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | .NET 6.0 | .NET 6.0 | 1000 |   100 |  1.722 μs | 0.0072 μs | 0.0068 μs |  1.08 |    0.01 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |  1.555 μs | 0.0032 μs | 0.0028 μs |  0.97 |    0.00 |      - |     - |     - |         - |
|               Hyperlinq_For | .NET 6.0 | .NET 6.0 | 1000 |   100 |  1.694 μs | 0.0028 μs | 0.0026 μs |  1.06 |    0.00 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |  1.530 μs | 0.0043 μs | 0.0038 μs |  0.96 |    0.00 |      - |     - |     - |         - |
