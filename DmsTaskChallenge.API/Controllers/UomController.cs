using AutoMapper;
using DmsTaskChallenge.Domain.DTOs;
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
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public UomController(IUomService uomService, IMapper mapper)
        {
            _uomService = uomService;
            _mapper = mapper;
        }
        #endregion

        // GET: api/<UomsController>
        [HttpGet(nameof(GetAllUom))]
        public IActionResult GetAllUom()
        {
            var result = _uomService.GetUoms();
            if (result != null) return Ok(result);
            return BadRequest("No records found");
        }

        // GET api/<UomsController>/5
        [HttpGet(nameof(GetUom))]
        public IActionResult GetUom(int id)
        {
            var result = _uomService.GetUomById(id);
            if (result != null) return Ok(result);
            return BadRequest("No record found");
        }

        // POST api/<UomsController>
        [HttpPost(nameof(InsertUom))]
        public IActionResult InsertUom(UomRequestDTO uomRequestDTO)
        {
            if (uomRequestDTO == null) return BadRequest();
            _uomService.InsertUom(uomRequestDTO);
            return Ok("Data inserted");
        }

        // PUT api/<UomsController>/5
        [HttpPut(nameof(UpdateUom))]
        public IActionResult UpdateUom(Uom uom)
        {
            _uomService.UpdateUom(uom);
            return Ok("Updation done");
        }

        // DELETE api/<UomsController>/5
        [HttpDelete(nameof(DeleteUom))]
        public IActionResult DeleteUom(int id)
        {
            _uomService.DeleteUom(id);
            return Ok("Data Deleted");
        }
    }
}
