## Array.ValueType.ArrayValueTypeWhere

### Source
[ArrayValueTypeWhere.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhere.cs)

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
|               Method |      Job |  Runtime | Count |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |--------- |------ |-----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   443.0 ns |  1.32 ns |  1.17 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   472.6 ns |  1.33 ns |  1.11 ns |  1.07 |    0.00 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 |   925.0 ns |  6.30 ns |  5.58 ns |  2.09 |    0.01 | 0.0381 |     - |     - |      80 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 1,000.0 ns | 15.37 ns | 13.62 ns |  2.26 |    0.03 | 2.9659 |     - |     - |   6,208 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 1,102.8 ns | 20.69 ns | 19.35 ns |  2.49 |    0.05 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 |   619.3 ns |  1.60 ns |  1.34 ns |  1.40 |    0.00 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   536.9 ns |  2.28 ns |  2.02 ns |  1.21 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 |   606.7 ns |  2.82 ns |  2.50 ns |  1.37 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   516.7 ns |  5.77 ns |  5.11 ns |  1.17 |    0.01 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |   428.7 ns |  0.97 ns |  0.81 ns |  0.97 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   493.5 ns |  1.23 ns |  1.03 ns |  1.11 |    0.00 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 |   902.7 ns |  2.95 ns |  2.62 ns |  2.04 |    0.01 | 0.0381 |     - |     - |      80 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 1,032.9 ns |  6.66 ns |  5.90 ns |  2.33 |    0.01 | 2.9659 |     - |     - |   6,208 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 1,105.2 ns | 18.62 ns | 17.42 ns |  2.50 |    0.04 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 |   629.0 ns |  2.91 ns |  2.58 ns |  1.42 |    0.01 | 0.0153 |     - |     - |      32 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   520.8 ns |  0.94 ns |  0.83 ns |  1.18 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 |   606.5 ns |  2.76 ns |  2.45 ns |  1.37 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   529.9 ns |  2.81 ns |  2.63 ns |  1.20 |    0.01 |      - |     - |     - |         - |
