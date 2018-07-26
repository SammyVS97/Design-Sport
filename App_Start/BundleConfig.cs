using System.Web;
using System.Web.Optimization;

namespace Design_Sport
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-{version}.slim.min.js",
                        "~/Scripts/jquery.mCustomScrollbar.concat.min.js",
                        "~/Scripts/sidebar.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/popper.js",
                      "~/Scripts/popper.min.js",
                      "~/Scripts/fontawesome.js",
                      "~/Scripts/solid.js",
                      "~/Scripts/regular.js",
                      "~/Scripts/brands.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/jquery.mCustomScrollbar.min.css"));
        }
    }
}
