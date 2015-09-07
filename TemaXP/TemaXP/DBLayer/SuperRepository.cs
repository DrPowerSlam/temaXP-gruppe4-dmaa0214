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