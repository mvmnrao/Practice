using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Manik.Practice.EntityFramework.Repositories
{
    public abstract class PracticeRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<PracticeDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected PracticeRepositoryBase(IDbContextProvider<PracticeDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class PracticeRepositoryBase<TEntity> : PracticeRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected PracticeRepositoryBase(IDbContextProvider<PracticeDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
