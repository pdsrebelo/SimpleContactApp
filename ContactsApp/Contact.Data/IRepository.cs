using System.Collections.Generic;

namespace Contact.Data
{
    public interface IRepository<T> where T : class
    {
        // Marks an entity as new
        void Add(T entity);

        // Marks an entity as modified
        void Update(T entity);

        // Marks an entity to be removed
        void Delete(T entity);

        // Get an entity by int id
        T GetById(int id);

        // Gets all entities of type T
        IEnumerable<T> GetAll();
    }
}
