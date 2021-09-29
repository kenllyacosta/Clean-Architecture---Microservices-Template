using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ICreate<T> where T : class
    {
        T Create(T entity);
        bool Create(IEnumerable<T> entities);
    }
}
