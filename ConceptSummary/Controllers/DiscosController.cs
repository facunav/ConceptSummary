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
    public class DiscosController : ControllerBase
    {
        private readonly IDiscoRepository repository;
        private IReadOnlyList<Disco> Discos;

        public DiscosController(IDiscoRepository repository)
        {
            this.repository = repository;
        }

        // GET api/discos
        [HttpGet]
        public ActionResult<IEnumerable<Disco>> Get()
        {
            
            var noPop = true;            

            var fromDate = DateTime.Now.AddYears(-31);

            Discos = repository.GetList(new DiscosLaRengaSpecification(), fromDate);

            Specification<Disco> todos = Specification<Disco>.All;
            if (noPop)
            {
                todos = todos.And(new InglesSpecification());
            }

            return repository.GetList(todos, fromDate).ToList();

        }

        // POST api/discos
        [HttpPost]
        public void Post(Disco disco)
        {

            // El Specification tambien se puede usar para hacer validacionoes y no solo filtrar un IEnumerable

            if (!new EspañolSpecification().IsSatisfiedBy(disco))
            {
                throw new Exception("El disco no es de idioma español");
            }

        }


        // GET api/discos/5
        [HttpGet("{id}")]
        public ActionResult<Disco> Get(int id)
        {
            throw new NotImplementedException();
        }



        // PUT api/discos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Disco value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/discos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
