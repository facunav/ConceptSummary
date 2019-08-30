using ConceptSummary.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConceptSummary.Discos
{
    public class DiscoRepository : IDiscoRepository
    {
        public Disco GetDiscoByName(string name)
        {
            return DiscosStub.GetDiscoByName(name);
        }

        public IReadOnlyList<Disco> GetList(Specification<Disco> specification, DateTime fromDate)
        {
            return DiscosStub.GetAll()
                .Where(specification.ToExpression())
                .Where(x => x.EditionDate >= fromDate)
                .ToList();
        }
    }
}
