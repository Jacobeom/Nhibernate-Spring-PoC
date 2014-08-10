using NHibernate;
using Poc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Repository
{
    public interface IBasicRepository<T> where T : BaseEntity
    {
      
        T Load(int id);
        T Get(int id);
        ICollection<T> Get(ICollection<int> ids);
        IList<T> FindAllPaged(int pageSize, int firstResult, string orderBy, bool asc);
        IList<T> FindAll();
        long GetAllCount();
        T Save(T persistObject);
        T Update(T persistObject);
        T ForceUpdate(T persistObject);
        T SaveOrUpdate(T persistObject);
        void Delete(T persistObject);
        void DeleteById(int id);
        void Flush();
        void Lock(T persistObject);
    }
}