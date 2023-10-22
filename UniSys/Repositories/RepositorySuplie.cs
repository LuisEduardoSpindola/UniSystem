using Microsoft.EntityFrameworkCore;
using UniSys.Areas.Identity.Data;
using UniSys.Interfaces;
using UniSys.Models;

namespace UniSys.Repositories
{
    public class RepositorySuplie : RepositoryModel<Suplie>, IRepositorySuplie
    {
        private UniSysContext _Context { get; set; }

        public RepositorySuplie(UniSysContext Context) : base(Context)
        {
        }

        public List<Suplie> GetSupliesByCourse(int id)
        {
            return _Context.Suplie.Where(suplie => suplie.id == id).ToList();
        }
    }
}
