namespace UniSys.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        T Create(T entity);
        List<T> GetAll(T entity);
        T GetById(int id);
        T Update(int id);
        void Delete(int id);
    }
}
