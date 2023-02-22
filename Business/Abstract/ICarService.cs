using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByUnitPrice(decimal min, decimal max);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetById(int carId);
    }
}
