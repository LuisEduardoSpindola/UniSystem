using UniSys.Areas.Identity.Data;
using UniSys.Interfaces;
using UniSys.Models;

namespace UniSys.Repositories
{
    public class RepositoryCourse : RepositoryModel<Course>, IRepositoryCourse
    {
        public RepositoryCourse(UniSysContext Context) : base(Context)
        {
        }
    }
}
