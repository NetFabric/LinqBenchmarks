﻿using BenchmarkDotNet.Attributes;
using NetFabric.Hyperlinq;
using StructLinq;
using System.Linq;
using Nessos.LinqOptimizer.CSharp;
using Nessos.Streams.CSharp;

namespace LinqBenchmarks.Enumerable.Int32
{
    public class EnumerableInt32Select: EnumerableInt32BenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public int ForeachLoop()
        {
            var sum = 0;
            foreach (var item in source)
                sum += item * 3;
            return sum;
        }

        [Benchmark]
        public int Linq()
        {
            var sum = 0;
            foreach (var item in source.Select(item => item * 3))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int LinqAF()
        {
            var sum = 0;
            foreach (var item in global::LinqAF.IEnumerableExtensionMethods.Select(source, item => item * 3))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int LinqOptimizer()
        {
            var sum = 0;
            foreach (var item in source
                .AsQueryExpr()
                .Select(item => item * 3)
                .Run())
                sum += item;
            return sum;
        }

        [Benchmark]
        public int Streams()
        {
            var sum = 0;
            foreach (var item in source
                .AsStream()
                .Select(item => item * 3)
                .ToEnumerable())
                sum += item;
            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var item in source
                .ToStructEnumerable()
                .Select(item => item * 3))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int StructLinq_ValueDelegate()
        {
            var sum = 0;
            var selector = new TripleOfInt32();
            foreach (var item in source
                .ToStructEnumerable()
                .Select(ref selector, x => x, x => x))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int Hyperlinq()
        {
            var sum = 0;
            foreach (var item in source.AsValueEnumerable().Select(item => item * 3))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int Hyperlinq_ValueDelegate()
        {
            var sum = 0;
            foreach (var item in source.AsValueEnumerable().Select<int, TripleOfInt32>())
                sum += item;
            return sum;
        }
    }
}
