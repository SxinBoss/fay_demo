using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MyAbpDemoProject.EntityFramework.Repositories
{
    public abstract class MyAbpDemoProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyAbpDemoProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyAbpDemoProjectRepositoryBase(IDbContextProvider<MyAbpDemoProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyAbpDemoProjectRepositoryBase<TEntity> : MyAbpDemoProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyAbpDemoProjectRepositoryBase(IDbContextProvider<MyAbpDemoProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
