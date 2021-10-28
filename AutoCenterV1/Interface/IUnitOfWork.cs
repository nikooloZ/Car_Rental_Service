using AutoCenterV1.Repositories;
using System;

namespace AutoCenterV1.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository Cars { get; }
        ICustomerRepository Customers { get; }
        IOrderRepository Orders { get; }
        int Save();
    }
}
