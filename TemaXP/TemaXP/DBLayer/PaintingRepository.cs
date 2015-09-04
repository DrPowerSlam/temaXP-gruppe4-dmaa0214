using System.Collections.Generic;
using System.Linq;
using TemaXP.ModelLayer;

namespace TemaXP.DBLayer
{
    public class PaintingRepository : SuperRepository
    {
        public void InsertPainting(Painting painting)
        {
            context.Paintings.Add(painting);
            Save();
        }

        public Painting FindPainting(int id)
        {
            return context.Paintings.Find(id);
        }

        public void DeletePainting(int id)
        {
            context.Paintings.Remove(FindPainting(id));
            Save();
        }

        public List<Painting> GetAllPaintings()
        {
            return context.Paintings.ToList();
        }
    }
}