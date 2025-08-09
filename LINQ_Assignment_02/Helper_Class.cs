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
