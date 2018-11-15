using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationNursery.Models;

namespace WebApplicationNursery.Services
{
    public interface IUserService
    {
        void AddUser(UserDTO user);
    }
}
