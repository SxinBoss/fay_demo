using System.Data.Common;
using System.Data.Entity;
using System.Web.UI.WebControls;
using Abp.Zero.EntityFramework;
using MyAbpDemoProject.Authorization.Roles;
using MyAbpDemoProject.Authorization.Users;
using MyAbpDemoProject.DataModels;
using MyAbpDemoProject.MultiTenancy;

namespace MyAbpDemoProject.EntityFramework
{
    public class MyAbpDemoProjectDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /// <summary>
        /// 菜单
        /// </summary>
        public virtual IDbSet<MyMenu> MyMenus { get; set; }

        public MyAbpDemoProjectDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyAbpDemoProjectDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyAbpDemoProjectDbContext since ABP automatically handles it.
         */
        public MyAbpDemoProjectDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MyAbpDemoProjectDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MyAbpDemoProjectDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
