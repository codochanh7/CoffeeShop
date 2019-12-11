using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(CoffeeShopContext context) : base(context)
        {
        }

        public IEnumerable<string> GetGenres()
        {
            var genres = from m in CoffeeShopContext.Menus
                         orderby m.Genre
                         select m.Genre;

            return genres.Distinct().ToList();
        }

        protected CoffeeShopContext CoffeeShopContext
        {
            get { return Context as CoffeeShopContext; }
        }
    }
}