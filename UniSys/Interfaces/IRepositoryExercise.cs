using UniSys.Models;

namespace UniSys.Interfaces
{
    public interface IRepositoryExercise : IRepositoryModel<Exercise>
    {
        List<Exercise> GetExerciseBySuplies(int id);
    }
}
