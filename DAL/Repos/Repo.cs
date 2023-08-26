using DAL.EF;

namespace DAL.Repos
{
    public class Repo
    {
        protected UserContext db;
        protected Repo()
        {
            db = new UserContext();
        }
    }
}
