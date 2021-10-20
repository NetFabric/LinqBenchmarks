## Array.ValueType.ArrayValueTypeContains

### Source
[ArrayValueTypeContains.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeContains.cs)

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
|                   Method | Count |     Mean |     Error |    StdDev |   Median |        Ratio | RatioSD | Allocated |
|------------------------- |------ |---------:|----------:|----------:|---------:|-------------:|--------:|----------:|
|                  ForLoop |   100 | 2.451 μs | 0.1587 μs | 0.4425 μs | 2.400 μs |     baseline |         |         - |
|              ForeachLoop |   100 | 3.314 μs | 0.3237 μs | 0.9340 μs | 2.950 μs | 1.36x slower |   0.38x |         - |
|                     Linq |   100 | 3.768 μs | 0.5268 μs | 1.5200 μs | 3.350 μs | 1.52x slower |   0.64x |         - |
|               LinqFaster |   100 | 1.738 μs | 0.2166 μs | 0.6215 μs | 1.400 μs | 1.54x faster |   0.51x |         - |
|             LinqFasterer |   100 | 1.769 μs | 0.2470 μs | 0.7165 μs | 1.400 μs | 1.64x faster |   0.55x |         - |
|                   LinqAF |   100 | 2.671 μs | 0.3880 μs | 1.1132 μs | 2.700 μs | 1.08x slower |   0.45x |         - |
|               StructLinq |   100 | 6.274 μs | 1.0558 μs | 2.9605 μs | 6.050 μs | 2.58x slower |   1.14x |      32 B |
| StructLinq_ValueDelegate |   100 | 3.293 μs | 0.5682 μs | 1.5839 μs | 3.250 μs | 1.38x slower |   0.70x |         - |
|                Hyperlinq |   100 | 7.455 μs | 1.7264 μs | 5.0085 μs | 6.300 μs | 3.30x slower |   2.28x |      32 B |
|                  Faslinq |   100 | 4.179 μs | 0.5154 μs | 1.5195 μs | 4.000 μs | 1.82x slower |   0.82x |      64 B |
