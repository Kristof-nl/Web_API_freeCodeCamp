using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_freeCodeCamp.Models;

namespace Web_API_freeCodeCamp.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}
