namespace Task_sajjad_mohammadpoor;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public int Price { get; set; }
}
public enum Category
{
    Category1,
    Category2,
    Category3,
}