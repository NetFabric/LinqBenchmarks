﻿using BenchmarkDotNet.Attributes;
using JM.LinqFaster;
using NetFabric.Hyperlinq;
using StructLinq;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;

namespace LinqBenchmarks.Array.Int32
{
    public partial class ArrayInt32WhereSelectToArray: ArrayInt32BenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public int[] ForLoop()
        {
            var list = new List<int>();
            var array = source;
            for (var index = 0; index < array.Length; index++)
            {
                var item = array[index];
                if (item.IsEven())
                    list.Add(item * 2);
            }
            return list.ToArray();
        }

        [Benchmark]
        public int[] ForeachLoop()
        {
            var list = new List<int>();
            foreach (var item in source)
            {
                if (item.IsEven())
                    list.Add(item * 2);
            }
            return list.ToArray();
        }

        [Benchmark]
        public int[] Linq()
            => System.Linq.Enumerable
                .Where(source, item => item.IsEven()).Select(item => item * 2)
                .ToArray();

        [Benchmark]
        public int[] LinqFaster()
            => source
                .WhereSelectF(item => item.IsEven(), item => item * 2);

        [Benchmark]
        public int[] LinqAF()
            => global::LinqAF.ArrayExtensionMethods.Where(source, item => item.IsEven()).Select(item => item * 2).ToArray();

        [Benchmark]
        public int[] StructLinq()
            => source.ToStructEnumerable()
                .Where(item => item.IsEven())
                .Select(item => item * 2)
                .ToArray();

        [Benchmark]
        public int[] StructLinq_IFunction()
        {
            var predicate = new Int32IsEven();
            var selector = new DoubleOfInt32();
            return source.ToStructEnumerable()
                .Where(ref predicate, x => x)
                .Select(ref selector, x => x, x => x)
                .ToArray(x => x);
        }

        [Benchmark]
        public int[] Hyperlinq()
            => source.AsValueEnumerable()
                .Where(item => item.IsEven())
                .Select(item => item * 2)
                .ToArray();

        [Benchmark]
        public int[] Hyperlinq_IFunction()
            => source.AsValueEnumerable()
                .Where<Int32IsEven>()
                .Select<int, DoubleOfInt32>()
                .ToArray();

        [Benchmark]
        public int Hyperlinq_Pool()
        {
            using var array = source.AsValueEnumerable()
                .Where(item => item.IsEven())
                .Select(item => item * 2)
                .ToArray(MemoryPool<int>.Shared);
            return Count == 0 
                ? default 
                : array.Memory.Span[0];
        }

        [Benchmark]
        public int Hyperlinq_Pool_IFunction()
        {
            using var array = source.AsValueEnumerable()
                .Where(item => item.IsEven())
                .Select(item => item * 2)
                .ToArray(MemoryPool<int>.Shared);
            return Count == 0
                ? default
                : array.Memory.Span[0];
        }
    }
}
