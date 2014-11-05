using System.Web;
using System.Web.Optimization;

namespace UploadDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js", 
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/fileinput").Include("~/Scripts/fileinput.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/swfupload").Include("~/Scripts/SWFUpload/swfupload.js",
                "~/Scripts/SWFUpload/plugins/swfupload.cookies.js",
                "~/Scripts/SWFUpload/plugins/swfupload.queue.js",
                "~/Scripts/SWFUpload/plugins/swfupload.speed.js",
                "~/Scripts/SWFUpload/plugins/swfupload.swfobject.js",
                "~/Scripts/SWFUpload/jquery.swfupload.js"));

            bundles.Add(new StyleBundle("~/Content/fileinput").Include("~/Content/fileinput.min.css"));
        }
    }
}
