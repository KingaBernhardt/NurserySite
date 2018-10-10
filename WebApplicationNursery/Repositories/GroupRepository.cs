using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationNursery.Models;

namespace WebApplicationNursery.Repositories
{
    public class GroupRepository : IGenericRepository<Group>
    {
        private NurseryContext nurseryContext;
        public GroupRepository(NurseryContext nurseryContext)
        {
            this.nurseryContext = nurseryContext;
        }

        public void Add(Group element)
        {
            throw new NotImplementedException();
        }

        public void Edit(Group element)
        {
            throw new NotImplementedException();
        }

        public Group GetId(long id)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Group> GetSearched(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
