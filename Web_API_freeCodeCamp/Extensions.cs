using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_freeCodeCamp.Dtos;
using Web_API_freeCodeCamp.Models;

namespace Web_API_freeCodeCamp
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreationDate = item.CreationDate
            };
        }
    }
}
