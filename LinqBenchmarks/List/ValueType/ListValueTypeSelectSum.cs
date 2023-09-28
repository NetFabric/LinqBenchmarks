﻿using ListExtensions = Faslinq.ListExtensions;

namespace LinqBenchmarks.List.ValueType;

public class ListValueTypeSelectSum: ValueTypeListBenchmarkBase
{
    [Benchmark(Baseline = true)]
    public int ForLoop()
    {
        var sum = 0;
        for (var index = 0; index < source.Count; index++)
            sum += source[index].Value0;
        return sum;
    }

#pragma warning disable HLQ010 // Consider using a 'for' loop instead.
    [Benchmark]
    public int ForeachLoop()
    {
        var sum = 0;
        foreach (var item in source)
            sum += item.Value0;
        return sum;
    }
#pragma warning restore HLQ010 // Consider using a 'for' loop instead.

    [Benchmark]
    public int Linq()
        => System.Linq.Enumerable.Sum(source, item => item.Value0);

    [Benchmark]
    public int LinqFaster()
        => source.SumF(item => item.Value0);

    [Benchmark]
    public int LinqFasterer()
        => EnumerableF.SumF(source, item => item.Value0);

    [Benchmark]
    public int LinqAF()
        => global::LinqAF.ListExtensionMethods.Sum(source, item => item.Value0);

    [Benchmark]
    public int StructLinq()
        => source.ToRefStructEnumerable()
            .Sum((in FatValueType item) => item.Value0);

    [Benchmark]
    public int StructLinq_ValueDelegate()
    {
        var selector = new Value0Selector();
        return source
            .ToRefStructEnumerable()
            .Sum(ref selector, x => x, x => x);
    }

    [Benchmark]
    public int Hyperlinq()
        => source.AsValueEnumerable()
            .Select(item => item.Value0)
            .Sum();

    [Benchmark]
    public int Hyperlinq_ValueDelegate()
        => source.AsValueEnumerable()
            .Select<int, Value0Selector>()
            .Sum();

    [Benchmark]
    public int Faslinq()
        => ListExtensions.Select(source, item => item.Value0 * 3)
            .Sum();
}