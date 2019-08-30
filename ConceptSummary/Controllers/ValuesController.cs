using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConceptSummary.Discos;
using ConceptSummary.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ConceptSummary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDiscoRepository _repository;
        private IReadOnlyList<Disco> Discos;

        public ValuesController(IDiscoRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var noPop = true;            

            var fromDate = DateTime.Now.AddYears(-31);

            Discos = _repository.GetList(new DiscosLaRengaSpecification(), fromDate);

            Specification<Disco> todos = Specification<Disco>.All;
            if (noPop)
            {
                todos = todos.And(new InglesSpecification());
            }

            Discos = _repository.GetList(todos, fromDate);

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
