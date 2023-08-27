using DAL.EF;

namespace DAL.Repos
{
    public class Repo
    {
        protected AdminContext db;
        protected Repo()
        {
            db = new AdminContext();
        }
    }
}
