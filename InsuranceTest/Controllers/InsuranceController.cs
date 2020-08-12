using System.Collections.Generic;
using InsuranceTest.Models;
using InsuranceTest.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceTest.Controllers
{
    [Route("api/Insurance")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly IDataRepository<Insurance> _dataRepository;

        public InsuranceController(IDataRepository<Insurance> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Insurance
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Insurance> insurances = _dataRepository.GetAll();
            return Ok(insurances);
        }

        // GET: api/Insurance/5
        [HttpGet("{id}", Name = "GetInsurance")]
        public IActionResult Get(int id)
        {
            Insurance insurance = _dataRepository.Get(id);

            if (insurance == null)
            {
                return NotFound("The insurance record couldn't be found.");
            }

            return Ok(insurance);
        }

        // POST: api/Insurance
        [HttpPost]
        public IActionResult Post([FromBody] Insurance insurance)
        {
            if (insurance == null)
            {
                return BadRequest("Insurance is null.");
            }

            _dataRepository.Add(insurance);
            return CreatedAtRoute(
                  "Get",
                  new { Id = insurance.id },
                  insurance);
        }

        // PUT: api/Insurance/3
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Insurance insurance)
        {
            if (insurance == null)
            {
                return BadRequest("insurance is null.");
            }

            Insurance insuranceToUpdate = _dataRepository.Get(id);
            if (insuranceToUpdate == null)
            {
                return NotFound("The Insurance record couldn't be found.");
            }

            _dataRepository.Update(insuranceToUpdate, insurance);
            return NoContent();
        }

        // DELETE: api/Insurance/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Insurance insurance = _dataRepository.Get(id);
            if (insurance == null)
            {
                return NotFound("The Insurance record couldn't be found.");
            }

            _dataRepository.Delete(insurance);
            return NoContent();
        }
    }
}