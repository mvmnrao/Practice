using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompleteDISample.Models;
using System.Web.Mvc;

namespace CompleteDISample.Controllers
{
    public class ArticleController : BaseController
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleController(IUnitOfWorkManager unitOfWorkManager, IArticleRepository articleRepository)
            : base(unitOfWorkManager)
        {
            this._articleRepository = articleRepository;
        }

        public ActionResult Test()
        {
            Article article;
            // Create a article
            using (var unitOfWork = this.UnitOfWorkManager.NewUnitOfWork())
            {
                article = this._articleRepository.Add(new Article()
                {
                    Id = Guid.NewGuid(),
                    Title = "Title Text One",
                    Summary = "Summary Text One",
                    ArticleContent = "Html content One",
                    ViewCount = 0,
                    CreatedDate = DateTime.Now,
                    CreatedByUsername = "admin",
                    Tags = "mvc, unity, asp.net"
                });

                unitOfWork.Commit();
            }

            return View(article);
        }
    }
}
