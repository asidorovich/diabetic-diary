using System.Web.Optimization;

namespace DiabeticDiary.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include("~/Scripts/angular.js")
                                                               .Include("~/Scripts/angular-ui/ui-bootstrap-tpls.js")
                                                               .Include("~/Scripts/angular-route.js")
                                                               .Include("~/Scripts/angular-resource.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").IncludeDirectory("~/Scripts/app/", "*.js", true));

            bundles.Add(new StyleBundle("~/bundles/css").Include("~/Content/bootstrap.min.css")
                                                        .Include("~/Content/bootstrap-theme.css")
                                                        .Include("~/Content/site.css"));

        }
    }
}