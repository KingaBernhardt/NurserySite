using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationNursery.Repositories;
using WebApplicationNursery.ViewModels;

namespace WebApplicationNursery.Services
{
    public class GroupService
    {
        private GroupRepository groupRepository;

        public GroupService(GroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
        }
    }
}
