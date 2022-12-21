using DmsTaskChallenge.Domain.Entities;
using DmsTaskChallenge.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DmsTaskChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        #region Property
        private readonly IItemService _itemService;
        #endregion

        #region Constructor
        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }
        #endregion

        // GET: api/<ItemsController>
        [HttpGet(nameof(GetAllItem))]
        public IActionResult GetAllItem()
        {
            var result = _itemService.GetItems();
            if(result != null) return Ok(result);
            return BadRequest("No records found");
        }

        // GET api/<ItemsController>/5
        [HttpGet(nameof(GetItem))]
        public IActionResult GetItem(int id)
        {
            var result = _itemService.GetItem(id);
            if (result != null) return Ok(result);
            return BadRequest("No record found");
        }

        // POST api/<ItemsController>
        [HttpPost(nameof(InsertItem))]
        public IActionResult InsertItem(Item item)
        {
            if(item == null) return BadRequest();
            _itemService.InsertItem(item);
            return Ok("Data inserted");
        }

        // PUT api/<ItemsController>/5
        [HttpPut(nameof(UpdateItem))]
        public IActionResult UpdateItem(Item item)
        {
            _itemService.UpdateItem(item);
            return Ok("Updation done");
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(int id)
        {
            _itemService.DeleteItem(id);
            return Ok("Data Deleted");
        }
    }
}
