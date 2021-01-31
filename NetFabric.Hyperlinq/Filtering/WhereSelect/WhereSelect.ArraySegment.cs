﻿using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NetFabric.Hyperlinq
{
    public static partial class ArrayExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector> WhereSelect<TSource, TResult, TPredicate, TSelector>(
            this in ArraySegment<TSource> source, 
            TPredicate predicate, 
            TSelector selector) 
            where TPredicate : struct, IFunction<TSource, bool>
            where TSelector : struct, IFunction<TSource, TResult>
            => new(source, predicate, selector);

        [GeneratorMapping("TSource", "TResult")]
        [StructLayout(LayoutKind.Auto)]
        public readonly partial struct ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>
            : IValueEnumerable<TResult, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator>
            where TPredicate : struct, IFunction<TSource, bool>
            where TSelector : struct, IFunction<TSource, TResult>
        {
            readonly ArraySegment<TSource> source;
            readonly TPredicate predicate;
            readonly TSelector selector;

            internal ArraySegmentWhereSelectEnumerable(in ArraySegment<TSource> source, TPredicate predicate, TSelector selector)
                => (this.source, this.predicate, this.selector) = (source, predicate, selector);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly Enumerator GetEnumerator() 
                => new(in this);
            readonly DisposableEnumerator IValueEnumerable<TResult, DisposableEnumerator>.GetEnumerator() 
                => new(in this);
            readonly IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator() 
                // ReSharper disable once HeapView.BoxingAllocation
                => new DisposableEnumerator(in this);
            readonly IEnumerator IEnumerable.GetEnumerator() 
                // ReSharper disable once HeapView.BoxingAllocation
                => new DisposableEnumerator(in this);

            [StructLayout(LayoutKind.Sequential)]
            public struct Enumerator
            {
                int index;
                readonly int end;
                readonly TSource[]? source;
                TPredicate predicate;
                TSelector selector;

                internal Enumerator(in ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector> enumerable)
                {
                    source = enumerable.source.Array;
                    predicate = enumerable.predicate;
                    selector = enumerable.selector;
                    index = enumerable.source.Offset - 1;
                    end = index + enumerable.source.Count;
                }

                public TResult Current 
                    => selector.Invoke(source![index]);

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public bool MoveNext()
                {
                    while (++index <= end)
                    {
                        if (predicate.Invoke(source![index]))
                            return true;
                    }
                    return false;
                }
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct DisposableEnumerator
                : IEnumerator<TResult>
            {
                int index;
                readonly int end;
                readonly TSource[]? source;
                TPredicate predicate;
                TSelector selector;

                internal DisposableEnumerator(in ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector> enumerable)
                {
                    source = enumerable.source.Array;
                    predicate = enumerable.predicate;
                    selector = enumerable.selector;
                    index = enumerable.source.Offset - 1;
                    end = index + enumerable.source.Count;
                }

                public TResult Current 
                    => selector.Invoke(source![index]);
                TResult IEnumerator<TResult>.Current 
                    => selector.Invoke(source![index]);
                object? IEnumerator.Current
                    // ReSharper disable once HeapView.PossibleBoxingAllocation
                    => selector.Invoke(source![index])!;

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public bool MoveNext()
                {
                    while (++index <= end)
                    {
                        if (predicate.Invoke(source![index]))
                            return true;
                    }
                    return false;
                }

                [ExcludeFromCodeCoverage]
                public readonly void Reset() 
                    => throw new NotSupportedException();

                public void Dispose() { }                
            }

            #region Aggregation

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int Count()
                => source.Count(predicate);

            #endregion
            #region Quantifier


            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool All()
                => source.All(predicate);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool All(Func<TResult, bool> predicate)
                => All(new FunctionWrapper<TResult, bool>(predicate));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool All<TPredicate2>(TPredicate2 predicate)
                where TPredicate2 : struct, IFunction<TResult, bool>
                => this.All<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TPredicate2>(predicate);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool All(Func<TResult, int, bool> predicate)
                => AllAt(new FunctionWrapper<TResult, int, bool>(predicate));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool AllAt<TPredicate2>(TPredicate2 predicate)
                where TPredicate2 : struct, IFunction<TResult, int, bool>
                => this.AllAt<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TPredicate2>(predicate);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Any()
                => source.Any(predicate);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Any(Func<TResult, bool> predicate)
                => Any(new FunctionWrapper<TResult, bool>(predicate));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Any<TPredicate2>(TPredicate2 predicate)
                where TPredicate2 : struct, IFunction<TResult, bool>
                => this.Any<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TPredicate2>(predicate);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Any(Func<TResult, int, bool> predicate)
                => AnyAt(new FunctionWrapper<TResult, int, bool>(predicate));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool AnyAt<TPredicate2>(TPredicate2 predicate)
                where TPredicate2 : struct, IFunction<TResult, int, bool>
                => this.AnyAt<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TPredicate2>(predicate);

            #endregion
            #region Filtering

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ValueEnumerableExtensions.WhereEnumerable<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, FunctionWrapper<TResult, bool>> Where(Func<TResult, bool> predicate)
                => this.Where<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult>(predicate);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ValueEnumerableExtensions.WhereEnumerable<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TPredicate2> Where<TPredicate2>(TPredicate2 predicate = default)
                where TPredicate2 : struct, IFunction<TResult, bool>
                => this.Where<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TPredicate2>(predicate);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ValueEnumerableExtensions.WhereAtEnumerable<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, FunctionWrapper<TResult, int, bool>> Where(Func<TResult, int, bool> predicate)
                => this.Where<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult>(predicate);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ValueEnumerableExtensions.WhereAtEnumerable<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TPredicate2> WhereAt<TPredicate2>(TPredicate2 predicate = default)
                where TPredicate2 : struct, IFunction<TResult, int, bool>
                => this.WhereAt<ArrayExtensions.ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TPredicate2>(predicate);

            #endregion
            #region Projection

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ArraySegmentWhereSelectEnumerable<TSource, TResult2, TPredicate, SelectorSelectorCombination<TSelector, FunctionWrapper<TResult, TResult2>, TSource, TResult, TResult2>> Select<TResult2>(Func<TResult, TResult2> selector)
                => Select<TResult2, FunctionWrapper<TResult, TResult2>>(new FunctionWrapper<TResult, TResult2>(selector));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ArraySegmentWhereSelectEnumerable<TSource, TResult2, TPredicate, SelectorSelectorCombination<TSelector, TSelector2, TSource, TResult, TResult2>> Select<TResult2, TSelector2>(TSelector2 selector = default)
                where TSelector2 : struct, IFunction<TResult, TResult2>
                => source.WhereSelect<TSource, TResult2, TPredicate, SelectorSelectorCombination<TSelector, TSelector2, TSource, TResult, TResult2>>(predicate, new SelectorSelectorCombination<TSelector, TSelector2, TSource, TResult, TResult2>(this.selector, selector));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ValueEnumerableExtensions.SelectManyEnumerable<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TSubEnumerable, TSubEnumerator, TResult2, FunctionWrapper<TResult, TSubEnumerable>> SelectMany<TSubEnumerable, TSubEnumerator, TResult2>(Func<TResult, TSubEnumerable> selector)
                where TSubEnumerable : IValueEnumerable<TResult2, TSubEnumerator>
                where TSubEnumerator : struct, IEnumerator<TResult2>
                => this.SelectMany<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TSubEnumerable, TSubEnumerator, TResult2>(selector);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ValueEnumerableExtensions.SelectManyEnumerable<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TSubEnumerable, TSubEnumerator, TResult2, TSelector2> SelectMany<TSubEnumerable, TSubEnumerator, TResult2, TSelector2>(TSelector2 selector = default)
                where TSubEnumerable : IValueEnumerable<TResult2, TSubEnumerator>
                where TSubEnumerator : struct, IEnumerator<TResult2>
                where TSelector2 : struct, IFunction<TResult, TSubEnumerable>
                => this.SelectMany<ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>, ArraySegmentWhereSelectEnumerable<TSource, TResult, TPredicate, TSelector>.DisposableEnumerator, TResult, TSubEnumerable, TSubEnumerator, TResult2, TSelector2>(selector);

            #endregion
            #region Element

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Option<TResult> ElementAt(int index)
                => source.ElementAt<TSource, TResult, TPredicate, TSelector>(index, predicate, selector);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Option<TResult> First()
                => source.First<TSource, TResult, TPredicate, TSelector>(predicate, selector);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Option<TResult> Single()
                => source.Single<TSource, TResult, TPredicate, TSelector>(predicate, selector);
            
            #endregion
            #region Conversion

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public TResult[] ToArray()
                => source.ToArray<TSource, TResult, TPredicate, TSelector>(predicate, selector);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public IMemoryOwner<TResult> ToArray(MemoryPool<TResult> memoryPool)
                => source.ToArray(predicate, selector, memoryPool);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public List<TResult> ToList()
                => source.ToList<TSource, TResult, TPredicate, TSelector>(predicate, selector);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Dictionary<TKey, TResult> ToDictionary<TKey>(Func<TResult, TKey> keySelector, IEqualityComparer<TKey>? comparer = default)
                where TKey : notnull
                => ToDictionary<TKey, FunctionWrapper<TResult, TKey>>(new FunctionWrapper<TResult, TKey>(keySelector), comparer);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Dictionary<TKey, TResult> ToDictionary<TKey, TKeySelector>(TKeySelector keySelector, IEqualityComparer<TKey>? comparer = default)
                where TKey : notnull
                where TKeySelector : struct, IFunction<TResult, TKey>
                => source.ToDictionary<TSource, TKey, TKeySelector, TResult, TPredicate, TSelector>(keySelector, comparer, predicate, selector);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Dictionary<TKey, TElement> ToDictionary<TKey, TElement>(Func<TResult, TKey> keySelector, Func<TResult, TElement> elementSelector, IEqualityComparer<TKey>? comparer = default)
                where TKey : notnull
                => ToDictionary<TKey, TElement, FunctionWrapper<TResult, TKey>, FunctionWrapper<TResult, TElement>>(new FunctionWrapper<TResult, TKey>(keySelector), new FunctionWrapper<TResult, TElement>(elementSelector), comparer);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Dictionary<TKey, TElement> ToDictionary<TKey, TElement, TKeySelector, TElementSelector>(TKeySelector keySelector, TElementSelector elementSelector, IEqualityComparer<TKey>? comparer = default)
                where TKey : notnull
                where TKeySelector : struct, IFunction<TResult, TKey>
                where TElementSelector : struct, IFunction<TResult, TElement>
                => source.ToDictionary<TSource, TKey, TElement, TKeySelector, TElementSelector, TResult, TPredicate, TSelector>(keySelector, elementSelector, comparer, predicate, selector);
            
            #endregion
        }
    }
}
