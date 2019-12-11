using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(CoffeeShopContext context) : base(context)
        {
        }

        public IEnumerable<string> GetUsers()
        {
            var UserNvs = from m in CoffeeShopContext.Orders
                          orderby m.UserNv
                          select m.UserNv;

            return UserNvs.Distinct().ToList();
        }

        protected CoffeeShopContext CoffeeShopContext
        {
            get { return Context as CoffeeShopContext; }
        }
    }
}