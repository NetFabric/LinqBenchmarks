﻿using BenchmarkDotNet.Attributes;
using NetFabric.Hyperlinq;
using StructLinq;
using System.Linq;
using Nessos.LinqOptimizer.CSharp;
using Nessos.Streams.CSharp;

namespace LinqBenchmarks.ImmutableArray.Int32
{
    public class ImmutableArrayInt32Where: ImmutableArrayInt32BenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public int ForLoop()
        {
            var sum = 0;
            var array = source;
            for (var index = 0; index < array.Length; index++)
            {
                var item = array[index];
                if (item.IsEven())
                    sum += item;
            }
            return sum;
        }

        [Benchmark]
        public int ForeachLoop()
        {
            var sum = 0;
            foreach (var item in source)
            {
                if (item.IsEven())
                    sum += item;
            }
            return sum;
        }

        [Benchmark]
        public int Linq()
        {
            var sum = 0;
            foreach (var item in source.Where(item => item.IsEven()))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int LinqOptimizer()
        {
            var sum = 0;
            foreach (var item in source
                .AsQueryExpr()
                .Where(item => item.IsEven())
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
                .Where(item => item.IsEven())
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
                .Where(item => item.IsEven()))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int StructLinq_ValueDelegate()
        {
            var sum = 0;
            var predicate = new Int32IsEven();
            foreach (var item in source
                .ToStructEnumerable()
                .Where(ref predicate, x => x))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int Hyperlinq()
        {
            var sum = 0;
            foreach (var item in source.AsValueEnumerable()
                .Where(item => item.IsEven()))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int Hyperlinq_ValueDelegate()
        {
            var sum = 0;
            foreach (var item in source.AsValueEnumerable()
                .Where<Int32IsEven>())
                sum += item;
            return sum;
        }
    }
}
