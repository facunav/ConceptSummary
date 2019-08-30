using System;
using System.Collections.Generic;
using System.Linq;

namespace ConceptSummary.Discos
{
    public static class DiscosStub
    {
        static IQueryable<Disco> DataSource => new List<Disco>
        {
            new Disco()
            {
               Name = "Despedazados por mil partes",
               Band = "La Renga",
               EditionDate = DateTime.Now.AddYears(-23).Date,
               Genre = "Rock",
               Language = "Español"
            },
            new Disco()
            {
               Name = "Insoportablemente Vivo",
               Band = "La Renga",
               EditionDate = DateTime.Now.AddYears(-18).Date,
               Genre = "Rock",
               Language = "Español"
            },
            new Disco()
            {
               Name = "Luzbelito",
               Band = "Los Redondos",
               EditionDate = DateTime.Now.AddYears(-23).Date,
               Genre = "Rock",
               Language = "Español"
            },
            new Disco()
            {
               Name = "Madonna",
               Band = "Like a prayer",
               EditionDate = DateTime.Now.AddYears(-30).Date,
               Genre = "Pop",
               Language = "Ingles"
            },
            new Disco()
            {
               Name = "Smells like teen spirit",
               Band = "Nirvana",
               EditionDate = DateTime.Now.AddYears(-28).Date,
               Genre = "Grunge",
               Language = "Ingles"
            },
            new Disco()
            {
               Name = "Black hole sun",
               Band = "Soundgarden",
               EditionDate = DateTime.Now.AddYears(-25).Date,
               Genre = "Grunge",
               Language = "Ingles"
            },

        }.AsQueryable();

        public static IQueryable<Disco> GetAll()
        {
            return DataSource;
        }

        public static Disco GetDiscoByName(string name)
        {
            return DataSource.Where(x => x.Name.Equals(name)).Single();
        }

        public static IQueryable<Disco> GetDiscoByGenre(string genre)
        {
            return DataSource.Where(x => x.Genre.Equals(genre)).AsQueryable();
        }

        public static IQueryable<Disco> GetDiscoByBand(string band)
        {
            return DataSource.Where(x => x.Band.Equals(band)).AsQueryable();
        }
    }
}