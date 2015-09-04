using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.ModelLayer;

namespace TemaXP.DBLayer
{
    public class PaintingRepository : SuperRepository
    {

        public Painting InsertPainting(Painting painting)
        {
            context.Paintings.Add(painting);

        }

        public Painting FindPainting(int id)
        {
            return context.Paintings.Find(id);
        }
    }
}
