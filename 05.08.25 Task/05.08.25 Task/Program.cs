using _05._08._25_Task.Models;

namespace _05._08._25_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {


           Phone phone = new Phone("Apple", "iPhone 14", 999.99, 1099.99, 10, 6);
            Product product = new Product("Samsung", "Galaxy S21", 799.99, 899.99, 5);
            product.PrintInfo();
            phone.PrintInfo();

        }
    }
}
