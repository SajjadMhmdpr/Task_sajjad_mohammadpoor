namespace Task_sajjad_mohammadpoor;

public static class Memory
{
    public static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Product A", Category = Category.Category1, Price = 100
        },
        new Product { Id = 2, Name = "Product B", Category = Category.Category1, Price = 150
        },
        new Product { Id = 3, Name = "Product C", Category = Category.Category2, Price = 120
        },
        new Product { Id = 4, Name = "Product D", Category = Category.Category3, Price = 200
        },
        new Product { Id = 5, Name = "Product E", Category = Category.Category1, Price = 80 }
    };
}