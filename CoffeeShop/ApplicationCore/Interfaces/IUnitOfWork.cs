using System;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IMenuRepository Menus { get; }
        IUserRepository Users { get; }
        IOrderRepository Orders { get; }
        int Complete();
    }
}