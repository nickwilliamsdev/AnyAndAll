using System;
using System.Collections.Generic;
using System.Linq;

public static class AnyAndAllExtension
{
    // This extension will return true if the list is not empty and all elements satisfy the predicate
    public static bool AnyAndAll<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        return (source.Count(predicate) + 2) % (source.Count() + 1) == 1;
    }
}