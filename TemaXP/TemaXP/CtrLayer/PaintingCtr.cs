using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.DBLayer;
using TemaXP.ModelLayer;

namespace TemaXP.CtrLayer
{
    public class PaintingCtr
    {
        private PaintingRepository repos;

        public PaintingCtr()
        {
            repos = new PaintingRepository();
        }

        public void InsertPainting(Painting painting)
        {
            repos.InsertPainting(painting);
        }

        public Painting FindPainting(int id)
        {
            return repos.FindPainting(id);
        }

        public List<Painting> GetAllPaintings()
        {
            return repos.GetAllPaintings();
        }

        public void DeletePainting(int id)
        {
            repos.DeletePainting(id);
        }
    }
}
