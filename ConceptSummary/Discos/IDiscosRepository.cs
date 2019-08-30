using ConceptSummary.Shared;
using System;
using System.Collections.Generic;

namespace ConceptSummary.Discos
{
    public interface IDiscoRepository
    {
        Disco GetDiscoByName(string name);
        IReadOnlyList<Disco> GetList(Specification<Disco> specification, DateTime fromDate);
    }
}
