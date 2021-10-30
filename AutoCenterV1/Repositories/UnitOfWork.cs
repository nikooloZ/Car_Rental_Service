using AutoCenterV1.Interface;
using System;

namespace AutoCenterV1.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _myDbContext;

        private Lazy<CarRepository> _carRepository;
        private Lazy<CustomerRepository> _customerRepository;
        private Lazy<OrderRepository> _orderRepository;

        public UnitOfWork()
        {
            _myDbContext = new();
            _carRepository = new Lazy<CarRepository>(() => new(_myDbContext));
            _customerRepository = new Lazy<CustomerRepository>(() => new(_myDbContext));
            _orderRepository = new Lazy<OrderRepository>(() => new(_myDbContext));
        }

        public ICarRepository Cars => _carRepository.Value;
        public ICustomerRepository Customers => _customerRepository.Value;
        public IOrderRepository Orders => _orderRepository.Value;

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
