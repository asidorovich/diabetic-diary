using System.Web.Optimization;

namespace DiabeticDiary.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include("~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include("~/Scripts/app/app.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include("~/Content/bootstrap.min.css")
                                                        .Include("~/Content/bootstrap-theme.css")
                                                        .Include("~/Content/site.css"));

        }
    }
}