using ClinicManagement.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicManagement.Core.Repositories
{
    public interface IRoleRepository
    {
        List<IdentityRole> GetRoles();
    }
}