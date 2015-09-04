using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaXP.DBLayer
{
    public class SuperRepository
    {
        protected DBContext context;

        protected SuperRepository()
        {
            context = new DBContext();
        }

        protected void Save()
        {
            context.SaveChanges();
        }
    }
}
