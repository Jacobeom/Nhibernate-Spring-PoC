using Poc.Model;
using Poc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Service
{
    public interface IBasicService<T> where T : BaseEntity
    {
       
        T NewInstance(T persistentObject);

        T ModifyInstance(T persistentObject);
        T SaveOrUpdate(T persistentObject);

        IList<T> GetAll();
        T GetInstance(int id);

        long GetAllCount();

        ICollection<T> GetInstances(ICollection<int> ids);

        IList<T> GetAllPaged(int pageSize, int firstResult, string orderBy, bool asc);

        void DeleteInstance(T persistentObject);

        void Delete(int id);
    }
}
