using System.Linq;
using MyAbpDemoProject.EntityFramework;
using MyAbpDemoProject.MultiTenancy;

namespace MyAbpDemoProject.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MyAbpDemoProjectDbContext _context;

        public DefaultTenantCreator(MyAbpDemoProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
