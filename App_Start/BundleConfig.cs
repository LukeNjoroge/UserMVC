using System.Web;
using System.Web.Optimization;

namespace UserMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/adminlte.min.js",
                      "~/Scripts/bootstrap3-wysihtml5.all.min.js",
                      "~/Scripts/select2.full.min.js",
                      "~/Scripts/daterangepicker.js",
                      "~/Scripts/bootstrap-datepicker.min.js",
                      "~/Scripts/demo.js",
                      "~/Scripts/fastclick.js",
                      "~/Scripts/jquery-jvectormap-1.2.2.min.js",
                      "~/Scripts/jquery-jvectormap-world-mill-en.js",
                      "~/Scripts/jquery-ui.min.js",
                      "~/Scripts/jquery.knob.min.js",
                      "~/Scripts/jquery.slimscroll.min.js",
                      "~/Scripts/jquery.sparkline.min.js",
                      "~/Scripts/moment.min.js",
                      "~/Scripts/morris.min.js",
                      "~/Scripts/raphael.min.js",
                      "~/Scripts/jquery.dataTables.min.js",
                      "~/Scripts/dataTables.bootstrap.min.js",
                      "~/Scripts/jquery.inputmask.js",
                      "~/Scripts/jquery.inputmask.date.extensions.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/_all-skins.min.css",
                      "~/Content/AdminLTE.min.css",
                      "~/Content/bootstrap-datepicker.min.css",
                      "~/Content/bootstrap3-wysihtml5.min.css",
                      "~/Content/daterangepicker.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/jquery-jvectormap-1.2.2.css",
                      "~/Content/ionicons.min.css",
                      "~/Content/morris.css",
                      "~/Content/Stylecss.css"));
        }
    }
}
