using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteDISample.Models
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetAll();
        Article Add(Article item);
        void Update(Article item);
        void Delete(Article item);
        Article Get(Guid id);
    }
}
