using AutoCenterV1.Interface;

namespace AutoCenterV1.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _myDbContext;
        private readonly CarRepository _carRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly OrderRepository _orderRepository;

        public UnitOfWork(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
            _carRepository = new(_myDbContext);
            _customerRepository = new(_myDbContext);
            _orderRepository = new(_myDbContext);
        }

        public ICarRepository Cars => _carRepository;
        public ICustomerRepository Customers => _customerRepository;
        public IOrderRepository Orders => _orderRepository;

        public int Save()
        {
            return _myDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _myDbContext.Dispose();
        }

    }
}
