using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationNursery.Models;
using WebApplicationNursery.Repositories;
using WebApplicationNursery.ViewModels;

namespace WebApplicationNursery.Services
{
    public class UserService : IUserService
    {
        private UserRepository userRepository;
        private GroupRepository groupRepository;

        public UserService(UserRepository userRepository, GroupRepository groupRepository)
        {
            this.userRepository = userRepository;
            this.groupRepository = groupRepository;
        }

        public void AddUser(UserDTO user)
        {
            userRepository.Add(user);
        }

        public UserGroupsViewModel GetViewModel()
        {
            return new UserGroupsViewModel
            {
                User = userRepository.GetList().First(),
                Groups = groupRepository.GetList()
            };
        }
    }
}
