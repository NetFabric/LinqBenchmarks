﻿using System;
using System.Collections.Generic;

namespace NetFabric.Hyperlinq
{
    public static partial class ListExtensions
    {
        public static int Count<TSource>(this List<TSource> source)
            => source.Count;

        public static ReadOnlyList.SelectReadOnlyList<List<TSource>, TSource, TResult> Select<TSource, TResult>(
            this List<TSource> source,
            Func<TSource, TResult> selector) 
            => ReadOnlyList.Select<List<TSource>, TSource, TResult>(source, selector);

        public static ReadOnlyList.WhereReadOnlyList<List<TSource>, TSource> Where<TSource>(
            this List<TSource> source, 
            Func<TSource, bool> predicate) 
            => ReadOnlyList.Where<List<TSource>, TSource>(source, predicate);

        public static TSource First<TSource>(this List<TSource> source) 
            => ReadOnlyList.First<List<TSource>, TSource>(source);

        public static TSource FirstOrDefault<TSource>(this List<TSource> source) 
            => ReadOnlyList.FirstOrDefault<List<TSource>, TSource>(source);

        public static TSource Single<TSource>(this List<TSource> source) 
            => ReadOnlyList.Single<List<TSource>, TSource>(source);

        public static TSource SingleOrDefault<TSource>(this List<TSource> source) 
            => ReadOnlyList.SingleOrDefault<List<TSource>, TSource>(source);
    }
}
