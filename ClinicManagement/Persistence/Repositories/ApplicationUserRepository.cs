using System;
using System.Collections.Generic;
using System.Linq;
using ClinicManagement.Core.Dto;
using ClinicManagement.Core.Models;
using ClinicManagement.Core.Repositories;
using ClinicManagement.Core.ViewModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ClinicManagement.Persistence.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<UserViewModel> GetUsers()
        {
            return (from user in _context.Users
                    from userRole in user.Roles
                    join role in _context.Roles
                        on userRole.RoleId equals role.Id
                    select new UserViewModel()
                    {
                        Id = user.Id,
                        Email = user.Email,
                        Role = role.Name,
                        IsActive = user.IsActive
                    }).ToList();
        }

        public ApplicationUser GetUser(string id)
        {
            return _context.Users.Find(id);
        }

        public string CreateUser(ApplicationUser applicationUser, List<string> roleIds)
        {
            try
            {
                var userStore = new UserStore<IdentityUser>(_context);
                var userMngr = new UserManager<IdentityUser>(userStore);

                var newUser = _context.Users.Add(applicationUser);

                var userRoles = new List<ApplicationUserRoles>();
                foreach (var roleId in roleIds)
                {
                    var userRole = new ApplicationUserRoles
                    {
                        RoleId = roleId,
                        UserId = newUser.Id
                    };
                    userRoles.Add(userRole);
                    //TODO: getting an error. Will come back to this
                    userMngr.AddToRole(newUser.Id, roleId);
                }

                _context.SaveChanges();

                return newUser.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}