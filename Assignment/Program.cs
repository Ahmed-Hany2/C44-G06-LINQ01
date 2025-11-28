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
        }
}
}
