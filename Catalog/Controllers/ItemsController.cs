using Catalog.DTOs;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }

        // GET /items
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select(item => item.AsDto());

            return items;
        }

        // GET /items/id
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id) //actionresult 1den fazla tip dönmeyi sağlar.
        {
            var item = repository.GetItem(id);

            if(item is null)
            {
                return NotFound();
            }

            return item;
        }
    }
}
