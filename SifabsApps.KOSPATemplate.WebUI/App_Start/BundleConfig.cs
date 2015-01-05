using System.Web;
using System.Web.Optimization;

namespace SifabsApps.KOSPATemplate.WebUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/require").Include(
                "~/Scripts/app/require.config.js",
                "~/Scripts/lib/require.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/libs").Include(
                    //"~/Scripts/lib/bootstrap*",
                    "~/Scripts/lib/crossroads.js",
                    "~/Scripts/lib/hasher.js",
                    "~/Scripts/lib/jquery.js",
                    "~/Scripts/lib/knockout.js",
                    "~/Scripts/lib/knockout-projections.js",
                    "~/Scripts/lib/signals.js",
                    "~/Scripts/lib/text.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/router.js",
                "~/Scripts/app/home/*.js"
            ));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
