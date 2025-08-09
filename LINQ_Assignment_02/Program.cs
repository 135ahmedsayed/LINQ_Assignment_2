using static LINQ_Assignment_02.ListGenerators;

namespace LINQ_Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            #region Q1
            var FirstP = ProductList.First(x => x.UnitsInStock == 0);
            Console.WriteLine(FirstP);
            #endregion
            #endregion
            Console.ReadKey();
        }
    }
}
