## Array.ValueType.ArrayValueTypeWhereSelect

### Source
[ArrayValueTypeWhereSelect.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelect.cs)

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
|              ForLoop | .NET 5.0 | .NET 5.0 |   100 |   830.7 ns |  1.28 ns |  1.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 5.0 | .NET 5.0 |   100 |   878.4 ns |  3.22 ns |  2.86 ns |  1.06 |    0.00 |      - |     - |     - |         - |
|                 Linq | .NET 5.0 | .NET 5.0 |   100 | 1,432.9 ns |  3.79 ns |  3.16 ns |  1.73 |    0.00 | 0.0801 |     - |     - |     168 B |
|           LinqFaster | .NET 5.0 | .NET 5.0 |   100 | 1,469.8 ns |  9.46 ns |  8.39 ns |  1.77 |    0.01 | 2.9659 |     - |     - |   6,208 B |
|               LinqAF | .NET 5.0 | .NET 5.0 |   100 | 2,029.5 ns | 16.57 ns | 15.50 ns |  2.44 |    0.02 |      - |     - |     - |         - |
|           StructLinq | .NET 5.0 | .NET 5.0 |   100 | 1,205.6 ns |  6.68 ns |  6.25 ns |  1.45 |    0.01 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   939.5 ns |  1.66 ns |  1.55 ns |  1.13 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 5.0 | .NET 5.0 |   100 | 1,111.6 ns |  5.25 ns |  4.91 ns |  1.34 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 5.0 | .NET 5.0 |   100 |   926.6 ns |  2.28 ns |  1.90 ns |  1.12 |    0.00 |      - |     - |     - |         - |
|              ForLoop | .NET 6.0 | .NET 6.0 |   100 |   840.8 ns |  2.23 ns |  1.86 ns |  1.01 |    0.00 |      - |     - |     - |         - |
|          ForeachLoop | .NET 6.0 | .NET 6.0 |   100 |   898.2 ns |  1.87 ns |  1.66 ns |  1.08 |    0.00 |      - |     - |     - |         - |
|                 Linq | .NET 6.0 | .NET 6.0 |   100 | 1,416.4 ns |  3.26 ns |  2.89 ns |  1.70 |    0.00 | 0.0801 |     - |     - |     168 B |
|           LinqFaster | .NET 6.0 | .NET 6.0 |   100 | 1,485.4 ns |  6.26 ns |  5.23 ns |  1.79 |    0.00 | 2.9659 |     - |     - |   6,208 B |
|               LinqAF | .NET 6.0 | .NET 6.0 |   100 | 1,936.6 ns | 23.50 ns | 19.62 ns |  2.33 |    0.02 |      - |     - |     - |         - |
|           StructLinq | .NET 6.0 | .NET 6.0 |   100 | 1,203.2 ns |  3.56 ns |  3.16 ns |  1.45 |    0.00 | 0.0305 |     - |     - |      64 B |
| StructLinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   956.7 ns |  2.06 ns |  1.72 ns |  1.15 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq | .NET 6.0 | .NET 6.0 |   100 | 1,115.1 ns | 10.05 ns |  8.91 ns |  1.34 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | .NET 6.0 | .NET 6.0 |   100 |   929.1 ns |  1.50 ns |  1.33 ns |  1.12 |    0.00 |      - |     - |     - |         - |
