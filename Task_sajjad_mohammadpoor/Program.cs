//use .net6
using Task_sajjad_mohammadpoor;

IProductService _productService = new ProductService();

//استفاده از دستور where ساده
var task1 = _productService.GetAllProductWithCategory(Category.Category1);
Console.WriteLine("Task 1 : ");
task1.ForEach(p => Console.WriteLine(p.Name));
Console.Write("--------------------------------------------------");

//جستوجو و استفاده از تابع ماکس در ان و سپس استخراج ان
var task2 = _productService.GetMaxiMomPrice();
Console.WriteLine("\nTask 2 : ");
Console.WriteLine(task2.Name);
Console.Write("--------------------------------------------------");

//استفاده از دستور جمع ساده
var task3 = _productService.SumProductPrice(); //or task5 * products.Count()
Console.WriteLine("\nTask 3 : ");
Console.WriteLine(task3);
Console.Write("--------------------------------------------------");

//استفاده از دستور گروپ بای و لیست کردن ایتم های گروه بندی شده
//سپس استخراج دیتا با حلقه تو در تو از لیست مربوطه
var task4 = _productService.GetGroupingByCategory();
Console.WriteLine("\nTask 4 : ");
foreach (var i in task4) 
{
    Console.WriteLine('\n'+i.Key.ToString()+" :");
    i.ToList().ForEach(pp => Console.Write(pp.Name+" , "));
    Console.WriteLine();
}
Console.Write("--------------------------------------------------");

//استفاده از دستور ساده میانگین
var task5 = _productService.Average();
Console.WriteLine("\nTask 5 : ");
Console.WriteLine(task5); 
Console.Write("--------------------------------------------------");


