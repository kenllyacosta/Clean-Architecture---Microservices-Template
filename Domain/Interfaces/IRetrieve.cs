using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IRetrieve<T> where T : class
    {
        IEnumerable<T> Retrieve(Expression<Func<T, bool>> predicate);
        T RetrieveFirstOrDefault(Expression<Func<T, bool>> predicate);
    }
}
