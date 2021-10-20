## Array.Int32.ArrayInt32Contains

### Source
[ArrayInt32Contains.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Contains.cs)

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
|                   Method | Count |       Mean |      Error |     StdDev |     Median |         Ratio | RatioSD | Allocated |
|------------------------- |------ |-----------:|-----------:|-----------:|-----------:|--------------:|--------:|----------:|
|                  ForLoop |   100 |   863.7 ns |   127.8 ns |   358.2 ns |   800.0 ns |      baseline |         |         - |
|              ForeachLoop |   100 | 1,463.9 ns |   396.9 ns | 1,151.6 ns |   900.0 ns |  2.16x slower |   1.97x |         - |
|                     Linq |   100 | 7,017.2 ns | 2,412.7 ns | 7,075.9 ns | 3,100.0 ns |  9.87x slower |   9.51x |         - |
|               LinqFaster |   100 |   808.5 ns |   121.8 ns |   347.5 ns |   800.0 ns |  1.16x slower |   0.83x |         - |
|          LinqFaster_SIMD |   100 |   704.5 ns |   119.7 ns |   351.0 ns |   650.0 ns |  1.04x slower |   1.03x |         - |
|             LinqFasterer |   100 | 2,245.3 ns |   780.0 ns | 2,237.9 ns | 1,300.0 ns |  2.68x slower |   2.37x |         - |
|                   LinqAF |   100 | 3,000.0 ns |   987.4 ns | 2,880.2 ns | 1,400.0 ns |  3.81x slower |   3.48x |         - |
|               StructLinq |   100 | 6,107.8 ns |   611.1 ns | 1,631.0 ns | 5,950.0 ns |  8.48x slower |   5.14x |      32 B |
| StructLinq_ValueDelegate |   100 | 3,964.3 ns | 1,419.3 ns | 4,140.1 ns | 1,900.0 ns |  5.35x slower |   5.40x |         - |
|                Hyperlinq |   100 | 8,994.8 ns | 2,071.7 ns | 6,010.3 ns | 6,200.0 ns | 12.59x slower |   9.99x |      32 B |
|           Hyperlinq_SIMD |   100 | 4,711.3 ns | 1,872.9 ns | 5,433.6 ns | 2,000.0 ns |  6.63x slower |   8.06x |         - |
|                  Faslinq |   100 | 2,354.3 ns |   310.7 ns |   886.4 ns | 1,900.0 ns |  3.56x slower |   3.64x |      64 B |
