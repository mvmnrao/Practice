using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteDISample.Models
{
    public class ArticleMapping: EntityTypeConfiguration<Article>
    {
        public ArticleMapping()
        {
            this.HasKey(a => a.Id);
            this.ToTable("Articles");
        }
    }
}
