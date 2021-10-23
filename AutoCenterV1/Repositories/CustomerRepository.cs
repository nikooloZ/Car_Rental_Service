using AutoCenterV1.DTO;
using AutoCenterV1.Interface;

namespace AutoCenterV1.Repositories
{
    public interface ICustomerRepository :
      IEntityCreator<Customer, int>,
      IEntityReader<Customer, int>,
      IEntityUpdater<Customer, int>
    {

    }


    class CustomerRepository : BaseRepository<Customer, int>, ICustomerRepository
    {
        public CustomerRepository(MyDbContext myDbContext) : base(myDbContext)
        {

        }
    }
}
