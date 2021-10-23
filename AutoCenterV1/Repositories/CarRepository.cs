using AutoCenterV1.DTO;
using AutoCenterV1.Interface;

namespace AutoCenterV1.Repositories
{
    public interface ICarRepository :
          IEntityCreator<Car, int>,
          IEntityReader<Car, int>,
          IEntityUpdater<Car, int>
    {

    }


    class CarRepository : BaseRepository<Car, int>, ICarRepository
    {
        public CarRepository(MyDbContext myDbContext) : base(myDbContext)
        {

        }
    }
}
