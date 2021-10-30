using AutoCenterV1.Interface;
using AutoCenterV1.Repositories;

namespace AutoCenterV1
{
    class Program
    {
        static void Main(string[] args)
        {
            using MyDbContext ctx = new();
            IUnitOfWork unitOfWork = new UnitOfWork();
            var cars = unitOfWork.Cars.GetAll();
            //ctx.Database.EnsureCreated();
        }
    }
}
