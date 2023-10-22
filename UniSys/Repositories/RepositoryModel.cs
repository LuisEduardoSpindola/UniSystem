using UniSys.Areas.Identity.Data;
using UniSys.Interfaces;
using UniSys.Models;

namespace UniSys.Repositories
{
    public class RepositoryModel<T> : IDisposable, IRepositoryModel<T> where T : class
    {
        private UniSysContext _Context { get; set; }

        public RepositoryModel(UniSysContext Context)
        {
            _Context = Context;
        }

        public T Create(T entity)
        {
            _Context.Set<T>().Add(entity);
            return entity;
        }

        public List<T> GetAll(T entity)
        {
           return _Context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            var result = _Context.Set<T>().Find(id);
            return result;
        }

        public T Update(int id)
        {
            var result =  _Context.Set<T>().Update(GetById(id));
            return result.Entity;
        }

        public void Delete(int id)
        {
            var result = GetById(id);
            _Context.Set<T>().Remove(result);
        }

        public void Dispose()
        {
            _Context?.Dispose();
        }
    }
}
