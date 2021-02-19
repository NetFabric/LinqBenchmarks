## Array.ValueType.ArrayValueTypeSkipTakeWhere

### Source
[ArrayValueTypeSkipTakeWhere.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSkipTakeWhere.cs)

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
|               Method |      Job |  Runtime | Skip | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |----- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 |   433.8 ns |  1.64 ns |  1.28 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 | 1000 |   100 | 2,437.2 ns | 17.42 ns | 15.44 ns |  5.61 |    0.03 | 0.0153 |     - |     - |      32 B |
|                 Linq | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1,931.2 ns |  8.21 ns |  7.68 ns |  4.45 |    0.03 | 0.1183 |     - |     - |     248 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 | 1000 |   100 | 1,421.8 ns | 23.96 ns | 20.01 ns |  3.29 |    0.04 | 6.7558 |     - |     - |  14,136 B |
|               LinqAF | .NET 5.0 | .NET 5.0 | 1000 |   100 | 5,451.2 ns | 97.27 ns | 90.99 ns | 12.60 |    0.20 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   626.7 ns |  1.36 ns |  1.20 ns |  1.44 |    0.01 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   498.2 ns |  1.83 ns |  1.53 ns |  1.15 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 | 1000 |   100 |   578.5 ns |  1.46 ns |  1.22 ns |  1.33 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 | 1000 |   100 |   492.2 ns |  2.20 ns |  1.95 ns |  1.13 |    0.00 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 |   421.4 ns |  1.50 ns |  1.41 ns |  0.97 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 | 1000 |   100 | 2,689.1 ns |  7.95 ns |  7.05 ns |  6.20 |    0.03 | 0.0153 |     - |     - |      32 B |
|                 Linq | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1,946.2 ns |  7.37 ns |  6.90 ns |  4.49 |    0.02 | 0.1183 |     - |     - |     248 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 | 1000 |   100 | 1,483.6 ns | 28.10 ns | 23.46 ns |  3.41 |    0.04 | 6.7558 |     - |     - |  14,136 B |
|               LinqAF | .NET 6.0 | .NET 6.0 | 1000 |   100 | 6,324.7 ns | 27.32 ns | 24.22 ns | 14.59 |    0.07 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   627.1 ns |  1.86 ns |  1.56 ns |  1.45 |    0.01 | 0.0458 |     - |     - |      96 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   511.4 ns |  3.66 ns |  3.06 ns |  1.18 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 | 1000 |   100 |   586.3 ns |  2.06 ns |  1.72 ns |  1.35 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 | 1000 |   100 |   492.9 ns |  1.89 ns |  1.58 ns |  1.14 |    0.00 |      - |     - |     - |         - |
