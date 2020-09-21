using System.Collections.Generic;

namespace OA.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetExpertizyList();
        T GetExpertizy(int id);
        void Create(T tbExpertizy);
        void Update(T tbExpertizy);
        void Delete(int id);
    }
}
