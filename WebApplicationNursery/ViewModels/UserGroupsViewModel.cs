using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationNursery.Models;

namespace WebApplicationNursery.ViewModels
{
    public class UserGroupsViewModel
    {
        public List<Group> Groups { get; set; }
        public User User { get; set; }
    }
}
