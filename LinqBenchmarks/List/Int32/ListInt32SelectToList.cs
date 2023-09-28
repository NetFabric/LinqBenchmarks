﻿using System.Runtime.InteropServices;
using ListExtensions = Faslinq.ListExtensions;

namespace LinqBenchmarks.List.Int32;

public class ListInt32SelectToList: Int32ListBenchmarkBase
{
    [Benchmark(Baseline = true)]
    public List<int> ForLoop()
    {
        var list = new List<int>();
        var array = source;
        for (var index = 0; index < array.Count; index++)
        {
            var item = array[index];
            list.Add(item * 3);
        }
        return list;
    }

    [Benchmark]
    public List<int> ForeachLoop()
    {
        var list = new List<int>();
        foreach (var item in source)
        {
            list.Add(item * 3);
        }
        return list;
    }

    [Benchmark]
    public List<int> Linq()
        => System.Linq.Enumerable
            .Select(source, item => item * 3)
            .ToList();

    [Benchmark]
    public List<int> LinqFaster()
        => new(source.SelectF(item => item * 3));

    [Benchmark]
    public List<int> LinqFasterer()
        => EnumerableF.ToListF(EnumerableF.SelectF(source, item => item * 3));

    [Benchmark]
    public List<int> LinqAF()
        => global::LinqAF.ListExtensionMethods
            .Select(source, item => item * 3)
            .ToList();

#if DOTNET5_0_OR_GREATER
    [Benchmark]
    public List<int> SpanLinq()
        => CollectionsMarshal.AsSpan(source)
            .Select(item => item * 3)
            .ToList();
#endif

    [Benchmark]
    public List<int> StructLinq()
        => source.ToStructEnumerable()
            .Select(item => item * 3)
            .ToList();

    [Benchmark]
    public List<int> StructLinq_ValueDelegate()
    {
        var selector = new TripleOfInt32();
        return source.ToStructEnumerable()
            .Select(ref selector, x => x, x => x)
            .ToList();
    }

    [Benchmark]
    public List<int> Hyperlinq()
        => source.AsValueEnumerable()
            .Select(item => item * 3)
            .ToList();

    [Benchmark]
    public List<int> Hyperlinq_ValueDelegate()
        => source.AsValueEnumerable()
            .Select<int, TripleOfInt32>()
            .ToList();

    [Benchmark]
    public List<int> Hyperlinq_SIMD()
        => source.AsValueEnumerable()
            .SelectVector(item => item * 3, item => item * 3)
            .ToList();

    [Benchmark]
    public List<int> Hyperlinq_ValueDelegate_SIMD()
        => source.AsValueEnumerable()
            .SelectVector<int, int, TripleOfInt32>()
            .ToList();

    [Benchmark]
    public List<int> Faslinq()
        => ListExtensions.Select(source, item => item * 3);
}