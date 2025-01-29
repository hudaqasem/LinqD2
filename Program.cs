using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using static Linq_EFDay01.ListGenerators;

namespace Linq_EFDay01
{
    internal class Program
    {
        static void Main()
        {
            #region Restriction Operators
            //var OutOfStock = ProductList.Where((P) => P.UnitsInStock == 0);
            //foreach (var Unit in OutOfStock) 
            //    Console.WriteLine(Unit);

            //var CostInStock = ProductList.Where((P) => P.UnitsInStock != 0 && P.UnitPrice > 3.00M);
            //foreach (var Unit in CostInStock)
            //    Console.WriteLine(Unit);

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };
            ////"five": idx = 5, length = 4 
            //var Shorter = Arr.Where((name,idx) => name.Length < idx);
            //foreach (var item in Shorter) 
            //    Console.WriteLine(item);

            #endregion

            #region Element Operators
            //var FirstProduct = ProductList.First((P) => P.UnitsInStock == 0);
            //Console.WriteLine(FirstProduct?.ProductName??"Not Found ");

            //var FirstPrice = ProductList.FirstOrDefault((P) => P.UnitPrice > 1000);
            //Console.WriteLine(FirstPrice);

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //// 5 >> 9 skip , 8
            //var SecondGreater = Arr.Where((X) => X > 5)
            //    .Skip(1);
            //foreach (var x in SecondGreater)
            //    Console.WriteLine(x);

            //Console.WriteLine(SecondGreater.First()); 
            #endregion

            #region Aggregate Operators

            #region 1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Odd = Arr.Count((X) => X % 2 == 1);
            //Console.WriteLine(Odd); 
            #endregion

            #region 2
            //var CustomerOrder = CustomerList.Select((C) => new
            //{
            //    CustomerName  = C.Name,
            //    CustomerOrders = C.Orders.Count()
            //});
            //foreach (var item in CustomerOrder)
            //    Console.WriteLine(item);

            #endregion

            #region 3
            //list of categories and how many products each has
            //var Category = ProductList.Select((P) => new
            //{
            //    CategoryName = P.Category,
            //    CategoryCnt = P.Category.Count()
            //});

            //foreach (var item in Category)
            //    Console.WriteLine(item);

            // to avoid reducion grouping the categories
            //var Category = ProductList.GroupBy((C) => C.Category) // retunt IEnumerable
            //    .Select((P) => new
            //    {
            //        CategoryName = P.Key,
            //        CategoryCnt = P.Count()
            //    });
            //foreach (var item in Category)
            //    Console.WriteLine(item);

            #endregion

            #region 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Total = Arr.Sum();
            //Console.WriteLine(Total); 
            #endregion

            #region 5
            //try
            //{
            //    StreamReader SR = new StreamReader(@"F:\DEPI\EF\Linq_Of_Day2\Task\dictionary_english.txt");
            //    string[] Dict = SR.ReadToEnd().Split();//Dict = { "AB", "CD", "E", "F" };

            //    var TotalChar = Dict.Sum(x => x.Length);
            //    Console.WriteLine(TotalChar); // 6 


            //    string[] Dict2 = File.ReadAllLines(@"F:\DEPI\EF\Linq_Of_Day2\Task\dictionary_english.txt");
            //    var TotalChar2 = Dict2.Sum(x => x.Length); //Dict2 = { "AB", "CD", "E", "F" };
            //    Console.WriteLine(TotalChar2); //6 

            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File Not Found");
            //}


            #endregion

            #region 6
            ////Get the total units in stock for each product category
            //var TotalUnits = ProductList.GroupBy((C) => C.Category)
            //    .Select((P) => new
            //    {
            //        CategoryName = P.Key,
            //        TotalInStock = P.Sum((X) => X.UnitsInStock)
            //    });
            //foreach (var Unit in TotalUnits)
            //    Console.WriteLine(Unit); 
            #endregion

            #region 7

            //try
            //{
            //    StreamReader SR = new StreamReader(@"F:\DEPI\EF\Linq_Of_Day2\Task\dictionary_english.txt");
            //    string[] Dict = SR.ReadToEnd().Split(new[] { ' ', '\t', '\n' }); //to ignore spaces (empty string)

            //    var ShortestWordLen1 = Dict.Min(x => x.Length);
            //    Console.WriteLine(ShortestWordLen1); // 1


            //    string[] Dict2 = File.ReadAllLines(@"F:\DEPI\EF\Linq_Of_Day2\Task\dictionary_english.txt");
            //    var ShortestWordLen2 = Dict2.Min(x => x.Length); 
            //    Console.WriteLine(ShortestWordLen2); //1 

            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File Not Found");
            //}


            #endregion

            #region 8
            //Get the cheapest price among each category's products
            //var MinPrice = ProductList.GroupBy((C) => C.Category)
            //    .Select((P) => new
            //    {
            //        CategoryName = P.Key,
            //        MinPrice = P.Min((X) => X.UnitPrice)
            //    });
            //foreach (var Unit in MinPrice)
            //    Console.WriteLine(Unit);

            //var Mn = ProductList.Min((C) => C.UnitPrice);
            //Console.WriteLine(Mn);
            #endregion

            #region 9
            //Get the products with the cheapest price in each category (Use Let)

            //var CheapestProducts = ProductList.GroupBy((P) => P.Category)
            //    .Select((Gp) => new
            //    {
            //        Category = Gp.Key,
            //        Products = Gp
            //            .Where((P) => P.UnitPrice == Gp.Min((P) => P.UnitPrice))

            //    });


            //foreach (var category in CheapestProducts)
            //{
            //    Console.WriteLine($"{category.Category} : ");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine($" {product.ProductName}: {product.UnitPrice}");
            //    }
            //}

            //var CheapestProducts = from p in ProductList
            //                       group p by p.Category into g
            //                       let minPrice = g.Min(p => p.UnitPrice)
            //                       select new
            //                       {
            //                           Category = g.Key,
            //                           Products = g.Where(p => p.UnitPrice == minPrice)
            //                       };

            //foreach (var category in CheapestProducts)
            //{
            //    Console.WriteLine($"{category.Category} : ");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine($" {product.ProductName}: {product.UnitPrice}");
            //    }
            //}



            #endregion

            #region 10
            //try
            //{
            //    string[] Dict2 = File.ReadAllLines(@"F:\DEPI\EF\Linq_Of_Day2\Task\dictionary_english.txt");
            //    var LongestWordLen2 = Dict2.Max(x => x.Length);
            //    Console.WriteLine(LongestWordLen2); 

            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File Not Found");
            //}

            #endregion

            #region 11
            ////11. Get the most expensive price among each category's products. 
            //var MaxPrice = ProductList.GroupBy((C) => C.Category)
            //    .Select((P) => new
            //    {
            //        CategoryName = P.Key,
            //        MaxPrice = P.Max((X) => X.UnitPrice)
            //    });
            //foreach (var item in MaxPrice)
            //    Console.WriteLine(item);

            //var Mx = ProductList.Max((C) => C.UnitPrice);
            //Console.WriteLine(Mx);

            #endregion

            #region 12
            //// Get the products with the most expensive price in each category.
            //var MaxPrice2 = ProductList.GroupBy((C) => C.Category)
            //    .Select((Gp) => new
            //    {
            //        CategoryName = Gp.Key,
            //        pruduct = Gp.Where((P) => P.UnitPrice == Gp.Max((C) => C.UnitPrice))

            //    });
            //foreach(var cat in MaxPrice2)
            //{
            //    Console.WriteLine($"{cat.CategoryName} : ");
            //    foreach (var product in cat.pruduct)
            //    {
            //        Console.WriteLine($"{product.ProductName} : {product.UnitPrice} ");
            //    }
            //} 
            #endregion

            #region 13
            //try
            //{
            //    string[] Dict = File.ReadAllLines(@"F:\DEPI\EF\Linq_Of_Day2\Task\dictionary_english.txt");
            //    var AvgWordLen = Dict.Average(x => x.Length);
            //    Console.WriteLine(AvgWordLen);

            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File Not Found");
            //} 
            #endregion

            #region 14
            //var AvgPrice = ProductList.GroupBy((C) => C.Category)
            //    .Select((P) => new
            //    {
            //        CategoryName = P.Key,
            //        MaxPrice = P.Average((X) => X.UnitPrice)
            //    });
            //foreach (var item in AvgPrice)
            //    Console.WriteLine(item);


            #endregion

            #endregion

            #region Ordering Operators 

            #region 1
            //var Sort = ProductList.OrderBy((p) => p.ProductName);
            //foreach (var item in Sort) 
            //    Console.WriteLine(item); 
            #endregion

            #region 2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Sort = Arr.OrderBy(x => x , StringComparer.InvariantCultureIgnoreCase);
            //foreach (var item in Sort)
            //    Console.WriteLine(item); 
            #endregion

            #region 3
            ////Sort a list of products by units in stock from highest to lowest

            //var SortDesc = ProductList.OrderByDescending((P) => P.UnitsInStock);
            //foreach (var P in SortDesc)
            //    Console.WriteLine(P); 
            #endregion

            #region 4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Sort = Arr.OrderBy((S) => S.Length)
            //    .ThenBy((S) => S);
            //foreach (var S in Sort)
            //    Console.WriteLine(S);
            #endregion

            #region 5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Sort = words.OrderBy((S) => S.Length)
            //    .ThenBy(x => x, StringComparer.InvariantCultureIgnoreCase);
            //foreach (var item in Sort)
            //    Console.WriteLine(item);
            #endregion

            #region 6
            //// Sort a list of products, first by category,
            //// and then by unit price, from highest to lowest.

            //var Sort = ProductList.OrderBy((C) => C.Category)
            //    .ThenBy((P) => P.UnitPrice);
            //foreach (var item in Sort)
            //    Console.WriteLine(item); 
            #endregion

            #region 7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Sort = Arr.OrderBy((S) => S.Length)
            //    .ThenByDescending(x => x, StringComparer.InvariantCultureIgnoreCase);
            //foreach (var item in Sort)
            //    Console.WriteLine(item); 
            #endregion

            #region 8
            ////whose second letter is 'i' that is reversed 
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };
            //var Result = Arr.Where((P) => P[1] == 'i').Reverse();
            //foreach (var P in Result) 
            //    Console.WriteLine(P); 
            #endregion


            #endregion

            #region Transformation Operators

            #region 1
            //var ProductNames = ProductList.Select((P) => P.ProductName);
            //foreach (var Product in ProductNames)
            //    Console.WriteLine(Product); 
            #endregion

            #region 2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Versions = words.Select((S) => new
            //{
            //    Upper = S.ToUpper(),
            //    Lower = S.ToLower()
            //});
            //foreach (var word in Versions)
            //    Console.WriteLine(word); 
            #endregion

            #region 3
            //var productProperties = ProductList .Select(p => new
            //{
            //    Name = p.ProductName,
            //    Category = p.Category,
            //    Price = p.UnitPrice,    
            //    Stock = p.UnitsInStock
            //});

            //foreach (var product in productProperties)
            //    Console.WriteLine(product); 
            #endregion

            #region 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Match = Arr.Select((num, idx) => new
            //{
            //    Number = num,
            //    InPlace = (idx == num)

            //});

            //Console.WriteLine("Number: In-place?");
            //foreach (var x in Match)
            //    Console.WriteLine($"{x.Number} : {x.InPlace}");

            #endregion

            #region 5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var Less = from A in numbersA
            //           from B in numbersB
            //           where A < B
            //           select new
            //           {
            //               NumA = A,
            //               NumB = B
            //           };

            //foreach (var item in Less)
            //    Console.WriteLine($"{item.NumA} is less than {item.NumB}"); 
            #endregion

            #region 6 & 7
            //nested structure
            //var Order = CustomerList.SelectMany((o) => o.Orders)
            //    .Where((t) => t.Total < 500.00);
            //foreach (var o in Order)
            //    Console.WriteLine(o);

            //var OrderDate = CustomerList.SelectMany((o) => o.Orders)
            //    .Where((d) => d.OrderDate.Year >= 1998 );
            //foreach (var date in OrderDate)
            //    Console.WriteLine(date);

            #endregion

            #endregion

            #region Partitioning Operators 

            // take,skip,takelast , skiplast, take/skipWile

            #region 1 & 2
            // Get the first 3 orders from customers in Washington 
            //var Order = CustomerList.Where((c) => c.Country == "Washington")
            //    .SelectMany((o) => o.Orders).Take(3);

            //foreach (var o in Order)
            //    Console.WriteLine(o);

            //var Order2 = CustomerList.Where((c) => c.Country == "Washington")
            //    .SelectMany((o) => o.Orders).Skip(2);

            //foreach (var o in Order2)
            //    Console.WriteLine(o);

            #endregion

            #region 3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Nums = numbers.TakeWhile((num, idx) => num >= idx);
            //foreach ( var i in Nums)
            //    Console.WriteLine(i); 
            #endregion

            #region 4 & 5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Nums = numbers.SkipWhile((n) => n % 3 != 0);
            //foreach (var n in Nums)
            //    Console.WriteLine(n);

            //var Nums2 = numbers.SkipWhile((n,idx) => n <= idx);
            //foreach (var n in Nums2)
            //    Console.WriteLine(n);


            #endregion


            #endregion

            #region Quantifiers 
            #region 1
            //try
            //{
            //    string[] Dict = File.ReadAllLines(@"F:\DEPI\EF\Linq_Of_Day2\Task\dictionary_english.txt");

            //    if (Dict.Any((d) => d.Contains("ei")))
            //    {
            //        var Res = Dict.Where((d) => d.Contains("ei"));
            //        foreach (var item in Res)
            //            Console.WriteLine(item);
            //    }
            //    else
            //    {
            //        Console.WriteLine("ei is not found in the file");
            //    }

            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File Not Found");
            //} 
            #endregion

            #region 2

            //var OutOfStock = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0))
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g
            //    });

            //foreach (var cat in OutOfStock)
            //{
            //    Console.WriteLine($"{cat.Category} : ");
            //    foreach (var product in cat.Products)
            //        Console.WriteLine($"{product.ProductName}");
            //} 
            #endregion

            #region 3
            //var InStock = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock != 0))
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g
            //    });

            //foreach (var cat in InStock)
            //{
            //    Console.WriteLine($"{cat.Category} : ");
            //    foreach (var product in cat.Products)
            //        Console.WriteLine($"{product.ProductName}");
            //} 
            #endregion

            #endregion






        }

    }
    
}
