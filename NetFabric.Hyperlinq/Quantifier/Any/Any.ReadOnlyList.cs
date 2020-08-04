using System;
using System.Collections.Generic;

namespace NetFabric.Hyperlinq
{
    public static partial class ReadOnlyListExtensions
    {
        
        public static bool Any<TList, TSource>(this TList source)
            where TList : notnull, IReadOnlyList<TSource>
            => source.Count != 0;


        static bool Any<TList, TSource>(this TList source, int offset, int count)
            where TList : notnull, IReadOnlyList<TSource>
        {
            (_, var take) = Utils.SkipTake(source.Count, offset, count);
            return take != 0;
        }


        public static bool Any<TList, TSource>(this TList source, Predicate<TSource> predicate)
            where TList : notnull, IReadOnlyList<TSource>
        {
            if (predicate is null) Throw.ArgumentNullException(nameof(predicate));

            return Any<TList, TSource>(source, predicate, 0, source.Count);
        }


        static bool Any<TList, TSource>(this TList source, Predicate<TSource> predicate, int offset, int count)
            where TList : notnull, IReadOnlyList<TSource>
        {
            var end = offset + count - 1;
            for (var index = offset; index <= end; index++)
            {
                if (predicate(source[index]))
                    return true;
            }
            return false;
        }

        
        public static bool Any<TList, TSource>(this TList source, PredicateAt<TSource> predicate)
            where TList : notnull, IReadOnlyList<TSource>
        {
            if (predicate is null) Throw.ArgumentNullException(nameof(predicate));

            return Any<TList, TSource>(source, predicate, 0, source.Count);
        }


        static bool Any<TList, TSource>(this TList source, PredicateAt<TSource> predicate, int offset, int count)
            where TList : notnull, IReadOnlyList<TSource>
        {
            var end = count - 1;
            if (offset == 0)
            {
                for (var index = 0; index <= end; index++)
                {
                    if (predicate(source[index], index))
                        return true;
                }
            }
            else
            {
                for (var index = 0; index <= end; index++)
                {
                    if (predicate(source[index + offset], index))
                        return true;
                }
            }
            return false;
        }
    }
}

