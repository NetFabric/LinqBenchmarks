﻿using BenchmarkDotNet.Attributes;
using NetFabric.Hyperlinq;
using StructLinq;
using System.Linq;

namespace LinqBenchmarks.List.Int32
{
    public partial class ListInt32Sum: Int32ListBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public int ForLoop()
        {
            var sum = 0;
            for (var index = 0; index < source.Count; index++)
            {
                var item = source[index];
                sum += item;
            }
            return sum;
        }

#pragma warning disable HLQ010 // Consider using a 'for' loop instead.
        [Benchmark]
        public int ForeachLoop()
        {
            var sum = 0;
            foreach (var item in source)
            {
                sum += item;
            }
            return sum;
        }
#pragma warning restore HLQ010 // Consider using a 'for' loop instead.

        [Benchmark]
        public int Linq()
            => System.Linq.Enumerable
                .Sum(source);

        [Benchmark]
        public int LinqFaster()
            => source
                .Sum();

        [Benchmark]
        public int LinqAF()
            => global::LinqAF.ListExtensionMethods.Sum(source);

        [Benchmark]
        public int StructLinq()
            => source.ToStructEnumerable()
                .Sum();

        [Benchmark]
        public int StructLinq_IFunction()
            => source.ToStructEnumerable()
                .Sum(x=>x);

        [Benchmark]
        public int Hyperlinq()
            => source.AsValueEnumerable()
                .Sum();

        [Benchmark]
        public int Hyperlinq_IFunction()
            => source.AsValueEnumerable()
                .Sum();
    }
}
