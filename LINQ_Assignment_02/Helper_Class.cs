using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LINQ_Assignment_02;

internal static class Helper_Class
{
    public static void print<T>(this IEnumerable<T> list)
    {
        if (list == null)
        {
            Console.WriteLine("The list is empty or null.");
            return;
        }
        if (list is string)
        {
            Console.WriteLine(list);
        }
        else
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

//Create Custom Comparer
public class CustomComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if (x == null || y == null) return false;
        return String.Concat(x.Trim().OrderBy(c => c)) ==
                   String.Concat(y.Trim().OrderBy(c => c));
    }

    public int GetHashCode([DisallowNull] string obj)
    {
        if (obj == null) return 0;
        return String.Concat(obj.Trim().OrderBy(c => c)).GetHashCode();
    }
}
