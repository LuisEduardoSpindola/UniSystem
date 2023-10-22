using Microsoft.EntityFrameworkCore;
using UniSys.Areas.Identity.Data;
using UniSys.Interfaces;
using UniSys.Models;

namespace UniSys.Repositories
{
    public class RepositoryInformatio : RepositoryModel<Information>, IRepositoryInformation
    {
        private UniSysContext _Context;

        public RepositoryInformatio(UniSysContext Context) : base(Context)
        {
        }

        public List<Information> GetInformationBySuplies(int id)
        {
            return _Context.Information.Where(suplie => suplie.id == id).ToList();
        }
    }
}
