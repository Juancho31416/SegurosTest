using System.Collections.Generic;
using InsuranceTest.Models;
using InsuranceTest.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceTest.Controllers
{
    [Route("api/UserInsurance")]
    [ApiController]
    public class UserInsuranceController : ControllerBase
    {
        private readonly IDataRepository<UserInsurance> _dataRepository;

        public UserInsuranceController(IDataRepository<UserInsurance> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/UserInsurance
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<UserInsurance> UserInsurances = _dataRepository.GetAll();
            return Ok(UserInsurances);
        }

        // GET: api/UserInsurance/5
        [HttpGet("{id}", Name = "GetUsIn")]
        public IActionResult Get(long id)
        {
            UserInsurance UserInsurance = _dataRepository.Get(id);

            if (UserInsurance == null)
            {
                return NotFound("The UserInsurance record couldn't be found.");
            }

            return Ok(UserInsurance);
        }

        // POST: api/UserInsurance
        [HttpPost]
        public IActionResult Post([FromBody] UserInsurance UserInsurance)
        {
            if (UserInsurance == null)
            {
                return BadRequest("UserInsurance is null.");
            }

            _dataRepository.Add(UserInsurance);
            return CreatedAtRoute(
                  "Get",
                  new { Id = UserInsurance.id },
                  UserInsurance);
        }

        // PUT: api/UserInsurance/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] UserInsurance UserInsurance)
        {
            if (UserInsurance == null)
            {
                return BadRequest("UserInsurance is null.");
            }

            UserInsurance UserInsuranceToUpdate = _dataRepository.Get(id);
            if (UserInsuranceToUpdate == null)
            {
                return NotFound("The UserInsurance record couldn't be found.");
            }

            _dataRepository.Update(UserInsuranceToUpdate, UserInsurance);
            return NoContent();
        }

        // DELETE: api/UserInsurance/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            UserInsurance UserInsurance = _dataRepository.Get(id);
            if (UserInsurance == null)
            {
                return NotFound("The UserInsurance record couldn't be found.");
            }

            _dataRepository.Delete(UserInsurance);
            return NoContent();
        }
    }
}