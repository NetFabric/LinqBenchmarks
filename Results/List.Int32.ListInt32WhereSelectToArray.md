## List.Int32.ListInt32WhereSelectToArray

### Source
[ListInt32WhereSelectToArray.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelectToArray.cs)

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
|                   Method | Count |      Mean |     Error |    StdDev |    Median |        Ratio | RatioSD | Allocated |
|------------------------- |------ |----------:|----------:|----------:|----------:|-------------:|--------:|----------:|
|                  ForLoop |   100 |  9.068 μs | 0.8264 μs |  2.331 μs |  8.200 μs |     baseline |         |     888 B |
|              ForeachLoop |   100 |  9.114 μs | 0.5889 μs |  1.690 μs |  8.500 μs | 1.06x slower |   0.30x |     888 B |
|                     Linq |   100 | 20.253 μs | 4.9871 μs | 13.736 μs | 15.200 μs | 2.22x slower |   1.24x |     840 B |
|               LinqFaster |   100 |  7.762 μs | 0.4986 μs |  1.398 μs |  7.550 μs | 1.21x faster |   0.38x |     888 B |
|             LinqFasterer |   100 |  8.500 μs | 0.4337 μs |  1.223 μs |  8.300 μs | 1.09x faster |   0.31x |     904 B |
|                   LinqAF |   100 | 16.922 μs | 1.7207 μs |  4.853 μs | 15.000 μs | 1.92x slower |   0.56x |     856 B |
|            LinqOptimizer |   100 | 43.530 μs | 2.6130 μs |  7.455 μs | 41.900 μs | 5.08x slower |   1.53x |   9,176 B |
|                  Streams |   100 | 25.148 μs | 2.7808 μs |  7.979 μs | 21.850 μs | 2.89x slower |   0.95x |   1,400 B |
|               StructLinq |   100 | 20.795 μs | 2.5889 μs |  7.344 μs | 18.200 μs | 2.34x slower |   0.75x |     904 B |
| StructLinq_ValueDelegate |   100 | 17.447 μs | 1.9620 μs |  5.692 μs | 15.450 μs | 2.02x slower |   0.71x |     808 B |
|                Hyperlinq |   100 | 17.735 μs | 1.4326 μs |  3.774 μs | 17.200 μs | 2.08x slower |   0.62x |     632 B |
|  Hyperlinq_ValueDelegate |   100 | 17.662 μs | 1.5497 μs |  4.421 μs | 16.150 μs | 2.03x slower |   0.61x |     776 B |
|                  Faslinq |   100 |  8.050 μs | 0.4237 μs |  1.181 μs |  7.950 μs | 1.15x faster |   0.31x |     888 B |
