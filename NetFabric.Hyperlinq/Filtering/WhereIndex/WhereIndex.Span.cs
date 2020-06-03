﻿using System;
using System.Runtime.CompilerServices;

namespace NetFabric.Hyperlinq
{
    public static partial class Array
    {
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SpanWhereIndexEnumerable<TSource> Where<TSource>(this Span<TSource> source, PredicateAt<TSource> predicate)
            => Where((ReadOnlySpan<TSource>)source, predicate);
    }
}

