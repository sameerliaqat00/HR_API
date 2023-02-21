using HR_API.Data;
using HR_API.Models;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace HR_API.IDbInitializer
{
    public class DbInitializer : IDbInitializer
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void Initialize()
        {
            if (_roleManager.FindByNameAsync(SD.Admin).Result == null)
            {
                _roleManager.CreateAsync(new IdentityRole(SD.SuperAdmin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.User)).GetAwaiter().GetResult();
            }
            else { return; }

            ApplicationUser superadmin = new ()
            {
                UserName = "info@mmbtechnologies.com",
                Email = "info@mmbtechnologies.com",
                EmailConfirmed = true,
                PhoneNumber = "111111111111",
                Name = "Rashid Ikram",
            };

            _userManager.CreateAsync(superadmin, "mmbTechnologies@786@").GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(superadmin, SD.SuperAdmin).GetAwaiter().GetResult();

            var claims1 = _userManager.AddClaimsAsync(superadmin, new Claim[] {
                new Claim(JwtClaimTypes.Name,superadmin.Name),
                new Claim(JwtClaimTypes.Role,SD.SuperAdmin)
            }).Result;
        }
    }
}
