using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationNursery.Repositories
{
    interface IGenericRepository<Type>
    {
        List<Type> GetList();

        void Add(Type element);

        Type GetId(long id);

        void Remove(int id);

        void Edit(Type element);

        List<Type> GetSearched(string name);
    }
}
