﻿using System.Runtime.InteropServices;
// ReSharper disable ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
// ReSharper disable LoopCanBeConvertedToQuery

namespace LinqBenchmarks.List.ValueType;

public class ListValueTypeWhere: ValueTypeListBenchmarkBase
{
    Func<IEnumerable<FatValueType>> linqOptimizerQuery;

    protected override void Setup()
    {
        base.Setup();

        linqOptimizerQuery = source
            .AsQueryExpr()
            .Where(item => item.IsEven())
            .Compile();
    }

    [Benchmark(Baseline = true)]
    public FatValueType ForLoop()
    {
        var sum = default(FatValueType);
        for (var index = 0; index < source.Count; index++)
        {
            var item = source[index];
            if (item.IsEven())
                sum += item;
        }
        return sum;
    }

#pragma warning disable HLQ010 // Consider using a 'for' loop instead.
    [Benchmark]
    public FatValueType ForeachLoop()
    {
        var sum = default(FatValueType);
        foreach (var item in source)
        {
            if (item.IsEven())
                sum += item;
        }
        return sum;
    }
#pragma warning restore HLQ010 // Consider using a 'for' loop instead.

    [Benchmark]
    public FatValueType Linq()
    {
        var items = System.Linq.Enumerable.Where(source, item => item.IsEven());
        var sum = default(FatValueType);
        foreach (var item in items)
            sum += item;
        return sum;
    }

    [Benchmark]
    public FatValueType LinqFaster()
    {
        var items = source.WhereF(item => item.IsEven());
        var sum = default(FatValueType);
        foreach (var item in items)
            sum += item;
        return sum;
    }

    [Benchmark]
    public FatValueType LinqFasterer()
    {
        var items = EnumerableF.WhereF(source, item => item.IsEven());
        var sum = default(FatValueType);
        foreach (var item in items)
            sum += item;
        return sum;
    }

    [Benchmark]
    public FatValueType LinqAF()
    {
        var items = global::LinqAF.ListExtensionMethods.Where(source, item => item.IsEven());
        var sum = default(FatValueType);
        foreach (var item in items)
            sum += item;
        return sum;
    }

    [Benchmark]
    public FatValueType LinqOptimizer()
    {
        var items = linqOptimizerQuery.Invoke();
        var sum = default(FatValueType);
        foreach (var item in items)
            sum += item;
        return sum;
    }

    [Benchmark]
    public FatValueType SpanLinq()
    {
        var items = CollectionsMarshal.AsSpan(source)
            .Where(item => item.IsEven());
        var sum = default(FatValueType);
        foreach (var item in items)
            sum += item;
        return sum;
    }

    [Benchmark]
    public FatValueType Streams()
    {
        var items = source
            .AsStream()
            .Where(item => item.IsEven())
            .ToEnumerable();
        var sum = default(FatValueType);
        foreach (var item in items)
            sum += item;
        return sum;
    }

    [Benchmark]
    public FatValueType StructLinq()
    {
        var items = source
            .ToRefStructEnumerable()
            .Where((in FatValueType item) => item.IsEven());
        var sum = default(FatValueType);
        foreach (ref readonly var item in items)
            sum += item;
        return sum;
    }

    [Benchmark]
    public FatValueType StructLinq_ValueDelegate()
    {
        var predicate = new FatValueTypeIsEven();
        var items = source
            .ToRefStructEnumerable()
            .Where(ref predicate, x => x);
        var sum = default(FatValueType);
        foreach (ref readonly var item in items)
            sum += item;
        return sum;
    }

    [Benchmark]
    public FatValueType Hyperlinq()
    {
        var items = source.AsValueEnumerable()
            .Where(item => item.IsEven());
        var sum = default(FatValueType);
        foreach (var item in items)
            sum += item;
        return sum;
    }

    [Benchmark]
    public FatValueType Hyperlinq_ValueDelegate()
    {
        var arraySegmentWhereEnumerable = source.AsValueEnumerable()
            .Where<FatValueTypeIsEven>();
        var sum = default(FatValueType);
        foreach (var item in arraySegmentWhereEnumerable)
            sum += item;
        return sum;
    }
}