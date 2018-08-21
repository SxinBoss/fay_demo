using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MyAbpDemoProject.EntityFramework;

namespace MyAbpDemoProject.Migrator
{
    [DependsOn(typeof(MyAbpDemoProjectDataModule))]
    public class MyAbpDemoProjectMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyAbpDemoProjectDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}