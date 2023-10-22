using UniSys.Models;

namespace UniSys.Interfaces
{
    public interface IRepositorySuplie : IRepositoryModel<Suplie>
    {
        List<Suplie> GetSupliesByCourse(int id);
    }
}
