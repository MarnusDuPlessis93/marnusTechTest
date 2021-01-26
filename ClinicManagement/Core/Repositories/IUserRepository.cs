using ClinicManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicManagement.Core.Repositories
{
    public interface IUserRepository
    {
        void Add(ApplicationUser applicationUser, List<int> roleIds);
    }
}