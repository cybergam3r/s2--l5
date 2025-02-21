namespace s2__l5.Services
{
    public interface IArticoloService<Articolo>
    {
        void Create(Articolo articolo);
        void Delete(int id);
        Articolo GetById(int id);
        IEnumerable<Articolo> GetAll();
    }
}