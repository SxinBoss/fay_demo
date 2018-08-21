using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MyAbpDemoProject.EntityFramework;

namespace MyAbpDemoProject
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MyAbpDemoProjectCoreModule))]
    public class MyAbpDemoProjectDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyAbpDemoProjectDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
