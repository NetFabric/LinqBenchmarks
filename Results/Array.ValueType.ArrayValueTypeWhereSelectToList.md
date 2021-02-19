## Array.ValueType.ArrayValueTypeWhereSelectToList

### Source
[ArrayValueTypeWhereSelectToList.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelectToList.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   847.2 ns |  7.67 ns |  6.80 ns |  1.00 |    0.00 | 2.4433 |     - |     - |      5 KB |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   895.2 ns | 11.17 ns |  9.90 ns |  1.06 |    0.02 | 2.4433 |     - |     - |      5 KB |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 1,255.6 ns | 12.03 ns | 11.25 ns |  1.48 |    0.02 | 2.5234 |     - |     - |      5 KB |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 1,221.4 ns | 10.21 ns |  7.97 ns |  1.44 |    0.02 | 4.0264 |     - |     - |      8 KB |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 2,139.4 ns | 34.56 ns | 32.33 ns |  2.53 |    0.05 | 2.4414 |     - |     - |      5 KB |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 1,303.1 ns | 14.56 ns | 11.36 ns |  1.54 |    0.02 | 1.1044 |     - |     - |      2 KB |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   912.3 ns |  6.48 ns |  5.75 ns |  1.08 |    0.01 | 1.0586 |     - |     - |      2 KB |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 1,143.2 ns |  6.86 ns |  6.08 ns |  1.35 |    0.01 | 1.0586 |     - |     - |      2 KB |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   903.0 ns |  4.45 ns |  3.95 ns |  1.07 |    0.01 | 1.0586 |     - |     - |      2 KB |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |   895.7 ns | 10.69 ns | 10.00 ns |  1.06 |    0.02 | 2.4433 |     - |     - |      5 KB |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   955.2 ns |  5.77 ns |  5.40 ns |  1.13 |    0.01 | 2.4433 |     - |     - |      5 KB |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 1,295.5 ns | 10.48 ns |  9.29 ns |  1.53 |    0.01 | 2.5234 |     - |     - |      5 KB |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 1,303.2 ns |  8.95 ns |  8.37 ns |  1.54 |    0.01 | 4.0264 |     - |     - |      8 KB |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 2,129.3 ns | 27.03 ns | 22.57 ns |  2.51 |    0.03 | 2.4414 |     - |     - |      5 KB |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 1,254.1 ns | 11.48 ns | 10.17 ns |  1.48 |    0.02 | 1.1044 |     - |     - |      2 KB |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   916.6 ns |  3.87 ns |  3.23 ns |  1.08 |    0.01 | 1.0586 |     - |     - |      2 KB |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 1,153.7 ns |  6.98 ns |  6.19 ns |  1.36 |    0.01 | 1.0586 |     - |     - |      2 KB |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   921.9 ns |  6.56 ns |  5.81 ns |  1.09 |    0.01 | 1.0586 |     - |     - |      2 KB |
