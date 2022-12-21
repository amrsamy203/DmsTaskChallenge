using DmsTaskChallenge.Domain.Entities;
using DmsTaskChallenge.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DmsTaskChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UomController : ControllerBase
    {
        #region Property
        private readonly IUomService _uomService;
        #endregion

        #region Constructor
        public UomController(IUomService uomService)
        {
            _uomService = uomService;
        }
        #endregion

        // GET: api/<ItemsController>
        [HttpGet(nameof(GetAllItem))]
        public IActionResult GetAllItem()
        {
            var result = _uomService.GetUoms();
            if (result != null) return Ok(result);
            return BadRequest("No records found");
        }

        // GET api/<ItemsController>/5
        [HttpGet(nameof(GetItem))]
        public IActionResult GetItem(int id)
        {
            var result = _uomService.GetUomById(id);
            if (result != null) return Ok(result);
            return BadRequest("No record found");
        }

        // POST api/<ItemsController>
        [HttpPost(nameof(InsertItem))]
        public IActionResult InsertItem(Uom uom)
        {
            if (uom == null) return BadRequest();
            _uomService.InsertUom(uom);
            return Ok("Data inserted");
        }

        // PUT api/<ItemsController>/5
        [HttpPut(nameof(UpdateItem))]
        public IActionResult UpdateItem(Uom uom)
        {
            _uomService.UpdateUom(uom);
            return Ok("Updation done");
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(int id)
        {
            _uomService.DeleteUom(id);
            return Ok("Data Deleted");
        }
    }
}
