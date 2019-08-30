using ConceptSummary.Shared;
using System;
using System.Linq.Expressions;

namespace ConceptSummary.Discos
{
    public sealed class DiscosLaRengaSpecification : Specification<Disco>
    {
        public override Expression<Func<Disco, bool>> ToExpression()
        {
            return disco => disco.Band.Equals("La Renga");
        }
    }

    public sealed class DiscosLosRedondosSpecification : Specification<Disco>
    {
        public override Expression<Func<Disco, bool>> ToExpression()
        {
            return disco => disco.Band.Equals("Los Redondos");
        }
    }

    public sealed class DiscosGrungeSpecification : Specification<Disco>
    {
        public override Expression<Func<Disco, bool>> ToExpression()
        {
            return disco => disco.Genre.Equals("Grunge");
        }
    }

    public sealed class DiscosRockSpecification : Specification<Disco>
    {
        public override Expression<Func<Disco, bool>> ToExpression()
        {
            return disco => disco.Genre.Equals("Rock");
        }
    }

    public sealed class DiscosPopSpecification : Specification<Disco>
    {
        public override Expression<Func<Disco, bool>> ToExpression()
        {
            return disco => disco.Genre.Equals("Pop");
        }
    }

    public sealed class InglesSpecification : Specification<Disco>
    {
        public override Expression<Func<Disco, bool>> ToExpression()
        {
            return disco => disco.Language.Equals("Ingles");            
        }
    }

    public sealed class EspañolSpecification : Specification<Disco>
    {
        public override Expression<Func<Disco, bool>> ToExpression()
        {
            return disco => disco.Language.Equals("Español");
        }
    }
}
