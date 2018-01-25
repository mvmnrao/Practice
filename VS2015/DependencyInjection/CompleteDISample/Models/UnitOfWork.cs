using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteDISample.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebDbContext _context;
        private readonly IDbTransaction _transaction;
        private readonly ObjectContext _objectContext;

        public UnitOfWork(IWebDbContext context)
        {
            this._context = context as WebDbContext;
            //this._context = new WebDbContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            this._objectContext = ((IObjectContextAdapter)this._context).ObjectContext;
            //this._objectContext.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (this._objectContext.Connection.State != ConnectionState.Open)
            {
                this._objectContext.Connection.Open();
                this._transaction = _objectContext.Connection.BeginTransaction();
            }
        }

        public void Commit()
        {
            try
            {
                this._context.SaveChanges();
                this._transaction.Commit();
            }
            catch (Exception)
            {
                Rollback();
                throw;
            }
        }

        private void Rollback()
        {
            this._transaction.Rollback();

            foreach (var entry in this._context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }

        public void Dispose()
        {
            if (this._objectContext.Connection.State == ConnectionState.Open)
            {
                this._objectContext.Connection.Close();
            }
        }
    }
}
