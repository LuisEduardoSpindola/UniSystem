using UniSys.Models;

namespace UniSys.Interfaces
{
    public interface IRepositoryInformation : IRepositoryModel<Information>
    {
        List<Information> GetInformationBySuplies(int id);
    }
}
