using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationNursery.Models;

namespace WebApplicationNursery.Repositories
{
    public class UserRepository : IGenericRepository<User>
    {
        private NurseryContext nurseryContext;
        public UserRepository(NurseryContext nurseryContext)
        {
            this.nurseryContext = nurseryContext;
        }

        public void Add(User element)
        {
            throw new NotImplementedException();
        }

        public void Edit(User element)
        {
            throw new NotImplementedException();
        }

        public User GetId(long id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetList()
        {
            throw new NotImplementedException();
        }

        public List<User> GetSearched(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
