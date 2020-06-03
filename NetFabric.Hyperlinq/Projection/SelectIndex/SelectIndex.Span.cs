﻿using System;
using System.Runtime.CompilerServices;

namespace NetFabric.Hyperlinq
{
    public static partial class Array
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SpanSelectIndexEnumerable<TSource, TResult> Select<TSource, TResult>(this Span<TSource> source, SelectorAt<TSource, TResult> selector)
            => Select((ReadOnlySpan<TSource>)source, selector);
    }
}

