## List.ValueType.ListValueTypeWhere

### Source
[ListValueTypeWhere.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhere.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqFaster.SIMD: [1.1.2](https://www.nuget.org/packages/LinqFaster.SIMD/1.0.3)
- LinqFasterer: [2.1.0](https://www.nuget.org/packages/LinqFasterer/2.1.0)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- LinqOptimizer.CSharp: [0.7.0](https://www.nuget.org/packages/LinqOptimizer.CSharp/0.7.0)
- SpanLinq: [0.0.1](https://www.nuget.org/packages/SpanLinq/0.0.1)
- Streams.CSharp: [0.6.0](https://www.nuget.org/packages/Streams.CSharp/0.6.0)
- StructLinq.BCL: [0.27.0](https://www.nuget.org/packages/StructLinq/0.27.0)
- NetFabric.Hyperlinq: [3.0.0-beta48](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta48)
- System.Linq.Async: [5.0.0](https://www.nuget.org/packages/System.Linq.Async/5.0.0)
- Faslinq: [1.0.5](https://www.nuget.org/packages/Faslinq/1.0.5)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.21390
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.100-rc.2.21505.57
  [Host] : .NET Core 3.1.20 (CoreCLR 4.700.21.47003, CoreFX 4.700.21.47101), X64 RyuJIT DEBUG  [AttachedDebugger]

Toolchain=InProcessEmitToolchain  InvocationCount=1  UnrollFactor=1  

```
|                   Method | Count |      Mean |     Error |     StdDev |    Median |         Ratio | RatioSD | Allocated |
|------------------------- |------ |----------:|----------:|-----------:|----------:|--------------:|--------:|----------:|
|                  ForLoop |   100 |  5.243 μs | 0.4182 μs |  1.2266 μs |  4.900 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  6.033 μs | 0.2350 μs |  0.6628 μs |  5.900 μs |  1.22x slower |   0.29x |      48 B |
|                     Linq |   100 | 12.421 μs | 0.8437 μs |  2.4611 μs | 11.700 μs |  2.50x slower |   0.77x |     280 B |
|               LinqFaster |   100 | 11.396 μs | 0.6849 μs |  1.9761 μs | 10.900 μs |  2.29x slower |   0.62x |   8,136 B |
|             LinqFasterer |   100 | 13.288 μs | 0.8411 μs |  2.4534 μs | 13.250 μs |  2.66x slower |   0.74x |  10,080 B |
|                   LinqAF |   100 | 12.467 μs | 1.2318 μs |  3.2665 μs | 11.200 μs |  2.56x slower |   1.05x |      48 B |
|            LinqOptimizer |   100 | 67.088 μs | 5.0606 μs | 14.9212 μs | 63.350 μs | 13.52x slower |   4.41x | 135,480 B |
|                  Streams |   100 | 52.964 μs | 2.9866 μs |  8.5690 μs | 50.300 μs | 10.68x slower |   2.83x |     944 B |
|               StructLinq |   100 | 12.806 μs | 1.0084 μs |  2.9417 μs | 12.050 μs |  2.57x slower |   0.79x |     136 B |
| StructLinq_ValueDelegate |   100 |  6.066 μs | 0.3221 μs |  0.9292 μs |  5.850 μs |  1.22x slower |   0.34x |      48 B |
|                Hyperlinq |   100 |  8.133 μs | 0.4984 μs |  1.4380 μs |  7.600 μs |  1.64x slower |   0.49x |      48 B |
|  Hyperlinq_ValueDelegate |   100 |  7.271 μs | 0.4419 μs |  1.2821 μs |  6.800 μs |  1.47x slower |   0.42x |      48 B |
|                  Faslinq |   100 | 13.139 μs | 1.4036 μs |  4.0943 μs | 11.800 μs |  2.68x slower |   1.13x |   8,184 B |
