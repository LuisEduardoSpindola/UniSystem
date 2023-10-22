using Microsoft.EntityFrameworkCore;
using UniSys.Areas.Identity.Data;
using UniSys.Interfaces;
using UniSys.Models;

namespace UniSys.Repositories
{
    public class RepositoryExercise : RepositoryModel<Exercise>, IRepositoryExercise
    {
        private UniSysContext _Context;

        public RepositoryExercise(UniSysContext Context) : base(Context)
        {
        }

        public List<Exercise> GetExerciseBySuplies(int id)
        {
            return _Context.Exercise.Where(suplie => suplie.id == id).ToList();
        }
    }
}
