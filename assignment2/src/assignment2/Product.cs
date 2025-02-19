
class Product
{
    public string Name
    {
        get; set;
    }
    public double Price
    {
        get; set;
    }
    public int Quantity
    {
        get; set;
    }
    public string Type
    {
        get; set;
    }

    // Constructor to initialize Product properties
    public Product(string Name, double Price, int Quantity, string Type)
    {
        this.Name = Name;
        this.Price = Price;
        this.Quantity = Quantity;
        this.Type = Type;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>{
            new Product ("lettuce", 10.5 , 50, "Leafy green"),
            new Product("cabbage", 20, 100, "Cruciferous"),
            new Product("pumpkin", 30 , 30, "Marrow"),
            new Product("cauliflower", 10 , 25, "Cruciferous"),
            new Product("zucchini", 20.5 , 50, "Marrow"),
            new Product ("yam", 30 , 50, "Root"),
            new Product ("spinach", 10 , 100, "Leafy green"),
            new Product("broccoli", 20.2, 75, "Cruciferous"),
            new Product("garlic", 30 , 20, "Leafy green"),
            new Product("silverbeet", 10, 50, "Marrow"),
        };

        Console.WriteLine($"1) Total number of products: {products.Count}\n");

        products.Add(new Product("Potato", 10, 50, "Root"));
        Console.WriteLine("----------------->2) Updated List");


        foreach (var Product in products)
        {
            Console.WriteLine($"{Product.Name}, {Product.Price}, {Product.Quantity}, {Product.Type}");
        }
        Console.WriteLine($"\nTotal Number of product:{products.Count}");


        var ProductType = products.Where(p => p.Type == "Leafy green").ToList();
        Console.WriteLine("\n3) Products which have Leafy green type\n");
        foreach (var product in ProductType)
        {
            Console.WriteLine($"{product.Name}");
        }

        Console.WriteLine($"\n4) Removing Garlic from list");
        products.RemoveAll(p => p.Name == "garlic");

        Console.WriteLine($"Total number of products after removing Garlic: {products.Count}");

        var cabbage = products.FirstOrDefault(p => p.Name == "cabbage");
        Console.WriteLine("\n5) Adding 50 Quantity of cabbage");
        cabbage.Quantity += 50;
        Console.WriteLine($"Final quantity of cabbage: {cabbage.Quantity}");

        var lettuce = products.FirstOrDefault(p => p.Name == "lettuce");
        var zucchini = products.FirstOrDefault(p => p.Name == "zucchini");
        var broccoli = products.FirstOrDefault(p => p.Name == "broccoli");
        double totalCost = (lettuce.Price * 1) + (zucchini.Price * 2) + (broccoli.Price * 1);
        Console.WriteLine($"\n6) Total cost for purchasing 1kg lettuce, 2kg zucchini, and 1kg broccoli: {Math.Round(totalCost)} RS");

    }
}
