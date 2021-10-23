using AutoCenterV1.DTO;
using AutoCenterV1.Repositories;

namespace AutoCenterV1
{
    class Program
    {
        static void Main(string[] args)
        {
            using MyDbContext ctx = new();
            ctx.Database.EnsureCreated();
            ICarRepository repo = new CarRepository(ctx);
        }
    }
}
