using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Return a sequence of just the names of a list of products
            List<Product> products = new List<Product>
{
    new Product { ProductID = 1, ProductName = "Apple", Category = "Fruits", UnitPrice = 3.5m, UnitsInStock = 10 },
    new Product { ProductID = 2, ProductName = "Banana", Category = "Fruits", UnitPrice = 2.0m, UnitsInStock = 0 },
    new Product { ProductID = 3, ProductName = "Orange", Category = "Fruits", UnitPrice = 4.0m, UnitsInStock = 5 },
    new Product { ProductID = 4, ProductName = "Milk", Category = "Dairy", UnitPrice = 15m, UnitsInStock = 20 },
    new Product { ProductID = 5, ProductName = "Cheese", Category = "Dairy", UnitPrice = 25m, UnitsInStock = 0 },
    new Product { ProductID = 6, ProductName = "Bread", Category = "Bakery", UnitPrice = 8m, UnitsInStock = 30 },
    new Product { ProductID = 7, ProductName = "Butter", Category = "Dairy", UnitPrice = 18m, UnitsInStock = 12 },
    new Product { ProductID = 8, ProductName = "Tomato", Category = "Vegetables", UnitPrice = 6m, UnitsInStock = 50 },
    new Product { ProductID = 9, ProductName = "Cucumber", Category = "Vegetables", UnitPrice = 5m, UnitsInStock = 0 },
    new Product { ProductID = 10, ProductName = "Chicken", Category = "Meat", UnitPrice = 70m, UnitsInStock = 7 }
};
            var productNames = products.Select(p => p.ProductName);



            // 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var result =
                words.Select(w => new
                {
                    Upper = w.ToUpper(),
                    Lower = w.ToLower()
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Upper} - {item.Lower}");
            }

            // 3- Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs =
                from a in numbersA
                from b in numbersB
                where a < b
                select new { A = a, B = b };

            //4. Select all orders where the order total is less than 500.00.
            List<Order> orders = new List<Order>
{
    new Order { OrderID = 1, Customer = "Ahmed",   OrderDate = new DateTime(1996, 5, 12), Total = 450.00m },
    new Order { OrderID = 2, Customer = "Hany",    OrderDate = new DateTime(1998, 1, 20), Total = 1200.00m },
    new Order { OrderID = 3, Customer = "Omar",    OrderDate = new DateTime(1999, 3, 15), Total = 300.00m },
    new Order { OrderID = 4, Customer = "Mona",    OrderDate = new DateTime(2000, 7, 8),  Total = 499.99m },
    new Order { OrderID = 5, Customer = "Sara",    OrderDate = new DateTime(1997, 2, 3),  Total = 800.00m },
    new Order { OrderID = 6, Customer = "Ali",     OrderDate = new DateTime(1998, 11, 11),Total = 50.00m },
    new Order { OrderID = 7, Customer = "Nour",    OrderDate = new DateTime(1995, 9, 28), Total = 2000.00m },
    new Order { OrderID = 8, Customer = "Mostafa", OrderDate = new DateTime(1999, 12, 1), Total = 230.00m }
};
            var smallOrders = orders.Where(o => o.Total < 500);


            // 5- Determine if the value of int in an array match their position in the array.

            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var matches = Arr.Select((value, index) => new
            {
                Index = index,
                Value = value,
                Match = value == index
            });

            #region LINQ - Restriction Operators><
            // 1. Find all products that are out of stock.
            var outOfStock = products.Where(p => p.UnitsInStock == 0);



            #endregion
        }
    }
}
