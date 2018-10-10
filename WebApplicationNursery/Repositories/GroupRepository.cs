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

        public void Add(Group group)
        {
            nurseryContext.Add(group);
            nurseryContext.SaveChanges();
        }

        public void Edit(Group group)
        {
            nurseryContext.Update(group);
            nurseryContext.SaveChanges();
        }

        public Group GetId(long id)
        {
            return nurseryContext.Groups.ToList().FirstOrDefault(g => g.Id == id);
        }

        public List<Group> GetList()
        {
            return nurseryContext.Groups.ToList();
        }

        public List<Group> GetSearched(string name)
        {
            return nurseryContext.Groups.Where(g => g.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public List<Group> GetSearchedByTeacher(string teacher)
        {
            return nurseryContext.Groups.Where(g => g.Teacher.ToLower().Contains(teacher.ToLower())).ToList();
        }

        public void Remove(int id)
        {
            var removableGroup = nurseryContext.Groups.ToList().FirstOrDefault(g => g.Id == id);
            nurseryContext.Remove(removableGroup);
            nurseryContext.SaveChanges();
        }
    }
}
