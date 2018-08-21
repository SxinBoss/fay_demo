using MyAbpDemoProject.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MyAbpDemoProject.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MyAbpDemoProjectDbContext _context;

        public InitialHostDbBuilder(MyAbpDemoProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
