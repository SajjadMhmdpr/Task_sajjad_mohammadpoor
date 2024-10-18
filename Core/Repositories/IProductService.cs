namespace Task_sajjad_mohammadpoor;

public interface IProductService
{
    List<Product> GetAllProductWithCategory(Category category);
    Product GetMaxiMomPrice();
    int SumProductPrice();
    List<IGrouping<Category, Product>> GetGroupingByCategory();
    double Average();
}