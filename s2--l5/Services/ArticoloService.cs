
using s2__l5.Entities;


namespace s2__l5.Services
{
    public class ArticoloService : IArticoloService<Articolo>
    {
        protected static readonly List<Articolo> articoli = new List<Articolo>();
        private static int lastId = 0;

        public void Create(Articolo articolo)
        {
            articolo.Id = ++lastId;
            articoli.Add(articolo);
        }

        public void Delete(int articoloId)
        {
            var articolo = articoli.FirstOrDefault(a => a.Id == articoloId);
            if (articolo != null)
            {
                articoli.Remove(articolo);
            }
        }

        public Articolo GetById(int articoloId)
        {
            return articoli.Single(a => a.Id == articoloId);
        }

        public IEnumerable<Articolo> GetAll()
        {
            return articoli;
        }
    }
}
