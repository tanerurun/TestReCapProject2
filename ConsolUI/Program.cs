using Business.Concete;
using DataAccess.Concrete.EntityFramework;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());
        foreach (var item in carManager.GetAll())
        {
            Console.WriteLine(item.ModelYear);
        }
        Console.WriteLine("Hello, World!");
    }
}