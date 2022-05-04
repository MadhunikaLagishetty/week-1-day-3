using Business_Layer;
using Domain_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazontablewebapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AmazonController : ControllerBase
    {
        private readonly ILogger<AmazonController> _logger;
        private readonly IAmazonCountriesBusiness _amazonCountriesBusiness;

        public AmazonController(ILogger<AmazonController> logger, IAmazonCountriesBusiness amazonCountriesBusiness)
        {
            _logger = logger;
            _amazonCountriesBusiness = amazonCountriesBusiness;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json", Type = typeof(IEnumerable<AmazonCountries>))]
        [Route("get-all")]
        public async Task<ActionResult<IEnumerable<AmazonCountries>>> GetAll()
        {
            try
            {
                var resp = await _amazonCountriesBusiness.GetAllAmazonCountries();

                if (resp == null || resp.Count == 0)
                {
                    return StatusCode(404, "No Data available.");
                }
                return Ok(resp);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

       

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("insert-amazoncountries")]
        public async Task<ActionResult> Insertamazoncountries([FromBody] AmazonCountries amazoncountries)
        {
            try
            {
                await _amazonCountriesBusiness.InsertAmazonCountry(amazoncountries);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("delete-amazoncountries")]
        public async Task<ActionResult> DeleteAmazonCountry(int id)
        {
            try
            {
                await _amazonCountriesBusiness.DeleteAmazonCountry(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}