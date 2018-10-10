using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Add(User user)
        {
            nurseryContext.Add(user);
            nurseryContext.SaveChanges();
        }

        public void Edit(User user)
        {
            nurseryContext.Update(user);
            nurseryContext.SaveChanges();
        }

        public User GetId(long id)
        {
            return nurseryContext.Users.ToList().FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetList()
        {
            return nurseryContext.Users.ToList();
        }

        public List<User> GetSearched(string name)
        {
            return nurseryContext.Users.Where(u => u.FirstName.ToLower().Contains(name.ToLower())).Where(t => t.LastName.ToLower().Contains(name.ToLower())).ToList();
        }

        public void Remove(int id)
        {
            var removableUser = nurseryContext.Users.ToList().FirstOrDefault(u => u.Id == id);
            nurseryContext.Users.Remove(removableUser);
            nurseryContext.SaveChanges();
        }
    }
}
