﻿using BenchmarkDotNet.Attributes;
using NetFabric.Hyperlinq;
using StructLinq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBenchmarks.Array.Int32
{
    public class ArrayInt32SkipTakeWhere: ArrayInt32SkipTakeBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public int ForLoop()
        {
            var sum = 0;
            var end = Skip + Count;
            for (var index = Skip; index < end; index++)
            {
                var item = source[index];
                if (item.IsEven())
                    sum += item;
            }
            return sum;
        }

        [Benchmark]
        public int ForeachLoop()
        {
            using var enumerator = ((IEnumerable<int>)source).GetEnumerator();
            for (var index = 0; index < Skip; index++)
                _ = enumerator.MoveNext();
            var sum = 0;
            for (var index = 0; index < Count; index++)
            {
                var item = enumerator.Current;
                if (item.IsEven())
                    sum += item;
            }
            return sum;
        }

        [Benchmark]
        public int Linq()
        {
            var sum = 0;
            foreach (var item in Enumerable.Skip(source, Skip).Take(Count).Where(item => item.IsEven()))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int LinqFaster()
        {
            var items = JM.LinqFaster.LinqFaster.WhereF(source.AsSpan().Slice(Skip, Count), item => item.IsEven());
            var sum = 0;
            for (var index = 0; index < items.Length; index++)
                sum += items[index];
            return sum;
        }

        //[Benchmark]
        //public int StructLinq()
        //{
        //    var sum = 0;
        //    foreach (var item in source.ToStructEnumerable().Where(item => item.IsEven(), x => x))
        //        sum += item;
        //    return sum;
        //}

        //[Benchmark]
        //public int StructLinq_IFunction()
        //{
        //    var sum = 0;
        //    var predicate = new IsEvenFunction();
        //    foreach (var item in source.ToStructEnumerable().Where(ref predicate, x => x))
        //        sum += item;
        //    return sum;
        //}

        [Benchmark]
        public int Hyperlinq()
        {
            var sum = 0;
            foreach (var item in ArrayExtensions.Skip(source, Skip).Take(Count).Where(item => item.IsEven()))
                sum += item;
            return sum;
        }
    }
}