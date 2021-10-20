## Array.Int32.ArrayInt32WhereSelect

### Source
[ArrayInt32WhereSelect.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelect.cs)

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
|                   Method | Count |      Mean |     Error |    StdDev |    Median |         Ratio | RatioSD | Allocated |
|------------------------- |------ |----------:|----------:|----------:|----------:|--------------:|--------:|----------:|
|                  ForLoop |   100 |  2.427 μs | 0.1257 μs | 0.3626 μs |  2.400 μs |      baseline |         |         - |
|              ForeachLoop |   100 |  2.472 μs | 0.1457 μs | 0.4157 μs |  2.400 μs |  1.03x slower |   0.21x |         - |
|                     Linq |   100 |  8.928 μs | 1.0518 μs | 3.0010 μs |  7.700 μs |  3.72x slower |   1.29x |     848 B |
|               LinqFaster |   100 |  7.776 μs | 0.6222 μs | 1.8050 μs |  7.300 μs |  3.27x slower |   0.91x |     664 B |
|             LinqFasterer |   100 |  9.300 μs | 0.5929 μs | 1.7011 μs |  9.200 μs |  3.92x slower |   1.00x |     864 B |
|                   LinqAF |   100 |  7.676 μs | 0.6789 μs | 1.7767 μs |  7.100 μs |  3.26x slower |   0.93x |         - |
|            LinqOptimizer |   100 | 46.199 μs | 2.9914 μs | 8.4374 μs | 45.000 μs | 19.42x slower |   4.60x |   9,168 B |
|                 SpanLinq |   100 |  7.685 μs | 0.2622 μs | 0.7395 μs |  7.500 μs |  3.22x slower |   0.52x |         - |
|                  Streams |   100 | 12.262 μs | 1.0163 μs | 2.7477 μs | 11.500 μs |  5.16x slower |   1.27x |     736 B |
|               StructLinq |   100 | 12.516 μs | 1.7858 μs | 5.2093 μs | 10.550 μs |  5.29x slower |   2.30x |      64 B |
| StructLinq_ValueDelegate |   100 |  5.166 μs | 0.3313 μs | 0.8670 μs |  4.850 μs |  2.19x slower |   0.48x |         - |
|                Hyperlinq |   100 |  5.244 μs | 0.3547 μs | 0.9156 μs |  5.000 μs |  2.23x slower |   0.46x |         - |
|  Hyperlinq_ValueDelegate |   100 |  4.408 μs | 0.4754 μs | 1.2186 μs |  4.100 μs |  1.88x slower |   0.58x |         - |
|                  Faslinq |   100 |  6.644 μs | 0.8206 μs | 2.3278 μs |  5.700 μs |  2.79x slower |   1.07x |     424 B |
