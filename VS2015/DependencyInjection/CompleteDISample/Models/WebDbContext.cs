using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteDISample.Models
{
    public class WebDbContext : DbContext, IWebDbContext
    {
        public DbSet<Article> Articles { get; set; }

        public WebDbContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Mappings
            modelBuilder.Configurations.Add(new ArticleMapping());

            base.OnModelCreating(modelBuilder);

        }

        public new void Dispose()
        {

        }
    }
}