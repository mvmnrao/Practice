using Abp.Web.Mvc.Views;

namespace Manik.Practice.Web.Views
{
    public abstract class PracticeWebViewPageBase : PracticeWebViewPageBase<dynamic>
    {

    }

    public abstract class PracticeWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected PracticeWebViewPageBase()
        {
            LocalizationSourceName = PracticeConsts.LocalizationSourceName;
        }
    }
}