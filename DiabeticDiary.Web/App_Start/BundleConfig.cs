using System.Web.Optimization;

namespace DiabeticDiary.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include("~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include("~/Scripts/app.js"));

        }
    }
}