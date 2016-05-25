using System.Web;
using System.Web.Optimization;

namespace DemoApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //AngularJS
            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-route.min.js"));

            //AngularJS Modules
            bundles.Add(new ScriptBundle("~/bundles/modules").Include(
                        "~/Scripts/Modules/DemoModule.js",
                        "~/Scripts/Modules/MailModule.js",
                        "~/Scripts/Modules/SpaModule.js"));

            //AngularJS Filters
            bundles.Add(new ScriptBundle("~/bundles/filters").Include(
                        "~/Scripts/Filters/TitleCaseFilter.js"));


            //AngularJS Services
            bundles.Add(new ScriptBundle("~/bundles/services").Include(
                        "~/Scripts/Services/ProductListService.js",
                        "~/Scripts/Services/MailListService.js"));

            //AngularJS Directives
            bundles.Add(new ScriptBundle("~/bundles/directives").Include(
                        "~/Scripts/Directives/focusDirective.js"));

            //AngularJS Demo Module Controllers
            bundles.Add(new ScriptBundle("~/bundles/demoModuleControllers").Include(
                        "~/Scripts/Controllers/DemoModule/DemoController.js",
                        "~/Scripts/Controllers/DemoModule/ShoppingCartController.js",
                        "~/Scripts/Controllers/DemoModule/StartupFundingController.js",
                        "~/Scripts/Controllers/DemoModule/StudentListController.js"));

            //AngularJS Mail Module Controllers
            bundles.Add(new ScriptBundle("~/bundles/mailModuleControllers").Include(
                        "~/Scripts/Controllers/MailModule/MailListController.js",
                        "~/Scripts/Controllers/MailModule/MailDetailController.js"));

            //AngularJS SPA Module Controllers
            bundles.Add(new ScriptBundle("~/bundles/spaModuleControllers").Include(
                        "~/Scripts/Controllers/SpaModule/AddOrderController.js",
                        "~/Scripts/Controllers/SpaModule/ShowOrderController.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
