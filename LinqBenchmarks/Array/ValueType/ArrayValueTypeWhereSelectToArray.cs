﻿using BenchmarkDotNet.Attributes;
using JM.LinqFaster;
using NetFabric.Hyperlinq;
using StructLinq;
using System.Collections.Generic;
using System.Linq;
using LinqFasterer;
using Nessos.LinqOptimizer.CSharp;
using Nessos.Streams.CSharp;

namespace LinqBenchmarks.Array.ValueType
{
    public partial class ArrayValueTypeWhereSelectToArray: ValueTypeArrayBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public FatValueType[] ForLoop()
        {
            var list = new List<FatValueType>();
            var array = source;
            for (var index = 0; index < array.Length; index++)
            {
                ref readonly var item = ref array[index];
                if (item.IsEven())
                    list.Add(item * 3);
            }
            return list.ToArray();
        }

        [Benchmark]
        public FatValueType[] ForeachLoop()
        {
            var list = new List<FatValueType>();
            foreach (var item in source)
            {
                if (item.IsEven())
                    list.Add(item * 3);
            }
            return list.ToArray();
        }

        [Benchmark]
        public FatValueType[] Linq()
            => System.Linq.Enumerable
                .Where(source, item => item.IsEven())
                .Select(item => item * 3)
                .ToArray();

        [Benchmark]
        public FatValueType[] LinqFaster()
            => source
                .WhereSelectF(item => item.IsEven(), item => item * 3);

        [Benchmark]
        public FatValueType[] LinqFasterer()
            => EnumerableF.ToArrayF(
                EnumerableF.SelectF(
                    EnumerableF.WhereF(source, item => item.IsEven()), 
                    item => item * 3)
            );

        [Benchmark]
        public FatValueType[] LinqAF()
            => global::LinqAF.ArrayExtensionMethods.Where(source, item => item.IsEven()).Select(item => item * 3).ToArray();

        [Benchmark]
        public FatValueType[] LinqOptimizer()
            => source
                .AsQueryExpr()
                .Where(item => item.IsEven())
                .Select(item => item * 3)
                .ToArray()
                .Run();

        [Benchmark]
        public FatValueType[] Streams()
            => source
                .AsStream()
                .Where(item => item.IsEven())
                .Select(item => item * 3)
                .ToArray();

        [Benchmark]
        public FatValueType[] StructLinq()
            => source
                .ToRefStructEnumerable()
                .Where((in FatValueType item) => item.IsEven())
                .Select((in FatValueType item) => item * 3)
                .ToArray();

        [Benchmark]
        public FatValueType[] StructLinq_ValueDelegate()
        {
            var predicate = new FatValueTypeIsEven();
            var selector = new TripleOfFatValueType();
            return source.ToRefStructEnumerable()
                .Where(ref predicate, x => x)
                .Select(ref selector, x => x, x => x)
                .ToArray(x=> x);
        }

        [Benchmark]
        public FatValueType[] Hyperlinq()
            => source.AsValueEnumerable()
                .Where(item => item.IsEven())
                .Select(item => item * 3)
                .ToArray();

        [Benchmark]
        public FatValueType[] Hyperlinq_ValueDelegate()
            => source.AsValueEnumerable()
                .Where<FatValueTypeIsEven>()
                .Select<FatValueType, TripleOfFatValueType>()
                .ToArray();
    }
}
