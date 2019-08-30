using System;

namespace ConceptSummary.Discos
{
    public class Disco
    {
        public virtual string Name { get; set; }
        public virtual string Band { get; set; }
        public virtual DateTime EditionDate { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Language { get; set; }
    }
}
