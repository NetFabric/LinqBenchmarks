using System;
using System.Runtime.CompilerServices;

namespace NetFabric.Hyperlinq
{
    public static partial class ArrayExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<TSource>(this in ArraySegment<TSource> source, Func<TSource, bool> predicate)
            => source.All(new FunctionWrapper<TSource, bool>(predicate));

        public static bool All<TSource, TPredicate>(this in ArraySegment<TSource> source, TPredicate predicate = default)
            where TPredicate : struct, IFunction<TSource, bool>
        {
            if (source.Any())
            {
                var array = source.Array!;
                var start = source.Offset;
                var end = start + source.Count;
                for (var index = start; index < end; index++)
                {
                    var item = array[index];
                    if (!predicate.Invoke(item))
                        return false;
                }
            }
            return true;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<TSource>(this in ArraySegment<TSource> source, Func<TSource, int, bool> predicate)
            => source.AllAt(new FunctionWrapper<TSource, int, bool>(predicate));
        
        public static bool AllAt<TSource, TPredicate>(this in ArraySegment<TSource> source, TPredicate predicate = default)
            where TPredicate : struct, IFunction<TSource, int, bool>
        {
            if (source.Any())
            {
                var array = source.Array!;
                var start = source.Offset;
                var end = source.Count;
                if (start is 0)
                {
                    for (var index = 0; index < end; index++)
                    {
                        var item = array[index];
                        if (!predicate.Invoke(item, index))
                            return false;
                    }
                }
                else
                {
                    for (var index = 0; index < end; index++)
                    {
                        var item = array[index + start];
                        if (!predicate.Invoke(item, index))
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
