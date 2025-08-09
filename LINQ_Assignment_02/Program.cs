using System.Collections.Generic;
using System.Linq;
using static LINQ_Assignment_02.ListGenerators;

namespace LINQ_Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary_english = File.ReadAllLines("dictionary_english.txt");

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
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int sum = Arr.Sum();
            //Console.WriteLine(sum);
            #endregion

            #region Q5
            //var dictionary_english = File.ReadAllLines("dictionary_english.txt");
            //var total_Char = dictionary_english.Sum(x => x.Length);
            //Console.WriteLine(total_Char); // returns 3494688
            #endregion

            #region Q6
            //var dictionary_english = File.ReadAllLines("dictionary_english.txt");
            //var Lenth_Shortest = dictionary_english.OrderBy(x => x.Length).First();
            //Console.WriteLine(Lenth_Shortest); // returns b
            #endregion

            #region Q7
            //var Lenth_Longest = dictionary_english.OrderBy(x => x.Length).Last();
            //Console.WriteLine(Lenth_Longest); // returns dichlorodiphenyltrichloroethane
            #endregion

            #region Q8
            //double Average = dictionary_english.Average(x => x.Length);
            //Console.WriteLine(Average); // returns 9.442576175563836
            #endregion

            #region Q9
            //var TotalUnitsInStock = ProductList.Where(x=>x.UnitsInStock!=0).GroupBy(x => x.Category);
            //foreach (var item in TotalUnitsInStock)
            //{
            //    Console.WriteLine($"{item.Key} : UnitsInStocks = {item.Sum(x=>x.UnitsInStock)}");
            //    Console.WriteLine("____________________");
            //}
            #endregion

            #region Q10
            //var CheapestUnitPrice = ProductList.GroupBy(x => x.Category);
            //foreach (var item in CheapestUnitPrice)
            //{
            //    Console.WriteLine($"{item.Key} : UnitPrice = {item.OrderBy(x => x.UnitPrice).First()}");
            //    Console.WriteLine("____________________");
            //}
            #endregion

            #region Q11
            //var cheapest = from P in ProductList
            //               group P by P.Category into g
            //               let minPrice = g.OrderBy(x => x.UnitPrice).FirstOrDefault()
            //               select minPrice;
            //foreach (var item in cheapest)
            //{
            //    Console.WriteLine($"{item}");
            //    Console.WriteLine("____________________");
            //}
            #endregion

            #region Q12
            //var ExpensiveUnitPrice = ProductList.GroupBy(x => x.Category);
            //foreach (var item in ExpensiveUnitPrice)
            //{
            //    Console.WriteLine($"{item.Key} ExpensiveUnitPrice : {item.OrderBy(x => x.UnitPrice).Last()}");
            //    Console.WriteLine("____________________");
            //}
            #endregion

            #region Q13
            //var Expensive = from P in ProductList
            //               group P by P.Category into g
            //               let minPrice = g.OrderBy(x => x.UnitPrice).LastOrDefault()
            //               select minPrice;
            //foreach (var item in Expensive)
            //{
            //    Console.WriteLine($"{item}");
            //    Console.WriteLine("____________________");
            //}
            #endregion

            #region Q14
            //var avr = ProductList.GroupBy(x => x.Category);
            //foreach (var item in avr)
            //{
            //    Console.WriteLine($"{item.Key} : Average UnitPrice = {item.Average(x => x.UnitPrice)}");
            //    Console.WriteLine("____________________");
            //}
            #endregion
            #endregion
            #region LINQ - Set Operators
            #region Q1
            //ProductList.DistinctBy(x=>x.Category).print(); // returns distinct categories from ProductList
            #endregion

            #region Q2
            //ProductList.Select(x => x.ProductName[0]).Union(CustomerList.Select(x => x.CustomerName[0])).print();
            #endregion

            #region Q3
            //ProductList.Select(x => x.ProductName[0]).Intersect(CustomerList.Select(x => x.CustomerName[0])).print();
            #endregion

            #region Q4
            //ProductList.Select(x => x.ProductName[0]).Except(CustomerList.Select(x => x.CustomerName[0])).print();
            #endregion

            #region Q5
            //CustomerList.Select(x => x.CustomerName[^3..]).Concat(ProductList.Select(x => x.ProductName[^3..])).Order().print();
            #endregion
            #endregion
            #region LINQ - Partitioning Operators
            #region Q1
            //CustomerList.Where(x => x.City == "Washington").SelectMany(o => o.Orders).Take(3).print(); // not Found any customer from Washington with orders.
            #endregion
            #region Q2
            //CustomerList.Where(x => x.City == "Washington").SelectMany(o => o.Orders).Take(2).print(); // not Found any customer from Washington with orders.
            #endregion
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            #region Q3
            //numbers.TakeWhile((x,i)=> x > i ).print();
            #endregion
            #region Q4
            //numbers.SkipWhile(x => x%3 != 0).print();
            #endregion
            #region Q5
            //numbers.SkipWhile((x,i) => x >= i).print();
            #endregion
            #endregion
            #region LINQ - Quantifiers
            #region Q1
            //bool R = dictionary_english.Any(x=>x.Contains("ei"));
            //Console.WriteLine(R);
            #endregion
            #region Q2
            //var p = ProductList.GroupBy(x => x.Category);
            //foreach (var item in p)
            //    if (item.Any(x => x.UnitsInStock == 0))
            //        Console.WriteLine($"{item.Key} has a product with UnitsInStock = 0");
            #endregion
            #region Q3
            //var p = ProductList.GroupBy(x => x.Category);
            //foreach (var item in p)
            //    if (item.All(x => x.UnitsInStock != 0))
            //        Console.WriteLine($"{item.Key} has a product with UnitsInStock");
            #endregion
            #endregion
            #region LINQ – Grouping Operators
            #region Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var groupedNumbers = numbers.GroupBy(x => x % 5);
            //foreach (var group in groupedNumbers)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5 : \n{string.Join("\n", group)}");
            //}
            #endregion
            #region Q2
            //var de = dictionary_english.GroupBy(x => x[0]);
            //foreach(var item in de)
            //{
            //    Console.WriteLine($"Words starting with '{item.Key}':");
            //    foreach (var word in item)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine("------------------------------");
            //}
            #endregion
            #region Q3
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };
            //var groups = Arr.GroupBy(w => w, new CustomComparer());

            //foreach (var group in groups)
            //{
            //    Console.WriteLine(string.Join("\n", group));
            //    Console.WriteLine("------------------------------");
            //}
            #endregion
            #endregion
            #region LINQ – Transformation Operators
            #region Q1
            //ProductList.Select(x => x.ProductName).print();
            #endregion
            #region Q2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //words.Select(w => new
            //{
            //    lowercase = w.ToLower(),
            //    uppercase = w.ToUpper(),
            //}).print();
            #endregion
            #region Q3
            ProductList.Select(x => new 
            {
                x.ProductName,
                Price = x.UnitPrice,
                x.UnitsInStock,
            }).print();
            #endregion
            #endregion
            Console.ReadKey();
        }
    }
}
