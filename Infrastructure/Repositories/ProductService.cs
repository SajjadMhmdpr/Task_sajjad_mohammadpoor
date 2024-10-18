using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_sajjad_mohammadpoor
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProductWithCategory(Category category)
        {
            //استفاده از دستور where ساده
            return Memory.products.Where(p => p.Category == Category.Category1).ToList();
        }
        public Product GetMaxiMomPrice()
        {
            //جستوجو و استفاده از تابع ماکس در ان و سپس استخراج ان
            return Memory.products.Where(p => p.Price == Memory.products.Max(p => p.Price)).First();
        }
        public int SumProductPrice()
        {
            //استفاده از دستور جمع ساده
            return Memory.products.Sum(p => p.Price); //or task5 * products.Count()
        }
        public List<IGrouping<Category, Product>> GetGroupingByCategory()
        {
            //استفاده از دستور گروپ بای و لیست کردن ایتم های گروه بندی شده
            //سپس استخراج دیتا با حلقه تو در تو از لیست مربوطه
            return Memory.products.GroupBy(p => p.Category).ToList();
        }
        public double Average()
        {
            //استفاده از دستور ساده میانگین
            return Memory.products.Average(p => p.Price);
        }
    }
}
