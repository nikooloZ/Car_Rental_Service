using AutoCenterV1.DTO;
using AutoCenterV1.Interface;

namespace AutoCenterV1.Repositories
{
    public interface IOrderRepository :
        IEntityCreator<Order, int>,
        IEntityReader<Order, int>
    {

    }

    class OrderRepository : BaseRepository<Order, int>, IOrderRepository
    {
        public OrderRepository(MyDbContext myDbContext) : base(myDbContext)
        {

        }
    }
}
