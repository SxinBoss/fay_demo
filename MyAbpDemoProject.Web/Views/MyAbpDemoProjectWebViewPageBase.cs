using Abp.Web.Mvc.Views;

namespace MyAbpDemoProject.Web.Views
{
    public abstract class MyAbpDemoProjectWebViewPageBase : MyAbpDemoProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class MyAbpDemoProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyAbpDemoProjectWebViewPageBase()
        {
            LocalizationSourceName = MyAbpDemoProjectConsts.LocalizationSourceName;
        }
    }
}