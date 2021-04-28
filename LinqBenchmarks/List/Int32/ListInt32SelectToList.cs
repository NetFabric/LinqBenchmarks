﻿using BenchmarkDotNet.Attributes;
using JM.LinqFaster;
using JM.LinqFaster.SIMD;
using NetFabric.Hyperlinq;
using StructLinq;
using System.Collections.Generic;
using System.Linq;
using Nessos.LinqOptimizer.CSharp;
using Nessos.Streams.CSharp;

namespace LinqBenchmarks.List.Int32
{
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
        public List<int> LinqAF()
            => global::LinqAF.ListExtensionMethods
                .Select(source, item => item * 3)
                .ToList();

        [Benchmark]
        public List<int> LinqOptimizer()
            => source.AsQueryExpr()
                .Select(item => item * 3)
                .ToList()
                .Run();

        [Benchmark]
        public List<int> Streams()
            => source.AsStream()
                .Select(item => item * 3)
                .ToList();

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
    }
}
