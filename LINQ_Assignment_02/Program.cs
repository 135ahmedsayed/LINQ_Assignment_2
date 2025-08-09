using static LINQ_Assignment_02.ListGenerators;

namespace LINQ_Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            #region Q1
            //var FirstP = ProductList.First(x => x.UnitsInStock == 0);
            //Console.WriteLine(FirstP);
            #endregion

            #region Q2
            //var FirstP = ProductList.First(x => x.UnitPrice > 1000M); 
            //Console.WriteLine(FirstP); // case null is returned.
            #endregion

            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Arr.Where(x => x > 5).Skip(1).Take(1).print(); // returns 8
            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var odd = Arr.Count(x => x % 2 != 0);
            //Console.WriteLine(odd); // returns 5
            #endregion

            #region Q2
            //CustomerList.Select(x => new 
            //{
            //    CustomerID = x.CustomerID,
            //    CustomerName = x.CustomerName,
            //    OrderCount = x.Orders.Count(),
            //}).print();
            #endregion

            #region Q3
            //var Cat_P = ProductList.GroupBy(x => x.Category);
            //foreach (var item in Cat_P)
            //{
            //    int count = 0;
            //    Console.Write($"{item.Key} : ");
            //    foreach (var p in item)
            //    {
            //        count++;
            //    }
            //    Console.WriteLine(count);
            //    Console.WriteLine("------------------------------");
            //}
            #endregion

            #region Q4
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int sum = Arr.Sum();
            Console.WriteLine(sum);
            #endregion
            #endregion
            Console.ReadKey();
        }
    }
}
