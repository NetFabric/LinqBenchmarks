﻿using BenchmarkDotNet.Attributes;
using JM.LinqFaster;
using NetFabric.Hyperlinq;
using StructLinq;

namespace LinqBenchmarks.Array.ValueType
{
    public class ArrayValueTypeContains: ValueTypeArrayBenchmarkBase
    {
        FatValueType value = new FatValueType(int.MaxValue);

        [Benchmark(Baseline = true)]
        public bool ForLoop()
        {
            var array = source;
            for (var index = 0; index < array.Length; index++)
            {
                ref readonly var item = ref array[index];
                if (item == value)
                    return true;
            }
            return false;
        }

        [Benchmark]
        public bool ForeachLoop()
        {
            foreach (var item in source)
            {
                if (item == value)
                    return true;
            }
            return false;
        }

        [Benchmark]
        public bool Linq()
            => System.Linq.Enumerable.Contains(source, value);

        [Benchmark]
        public bool LinqFaster()
            => source.ContainsF(value);

        [Benchmark]
        public bool LinqAF()
            => global::LinqAF.ArrayExtensionMethods.Contains(source, value);

        [Benchmark]
        public bool StructLinq()
            => source
                .ToRefStructEnumerable()
                .Contains(value);

        [Benchmark]
        public bool StructLinq_IFunction() 
            => source
                .ToRefStructEnumerable()
                .Contains(value, x => x);

        [Benchmark]
        public bool Hyperlinq()
            => source.AsValueEnumerable()
                .Contains(value);
    }
}
