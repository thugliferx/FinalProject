using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            ///admin side
            ///
            bundles.Add(new ScriptBundle("~/bundles/admin/js").Include(
                       "~/js/vendor/jquery-1.11.2.min.js", "~/js/vendor/bootstrap.min.js", "~/js/owl.carousel.min.js"
                       , "~/js/jquery.magnific-popup.js", "~/js/jquery.easing.1.3.js", "~/css/slick/slick.js"
                       , "~/css/slick/slick.min.js", "~/js/jquery.collapse.js", "~/js/bootsnav.js"
                       , "~/js/plugins.js", "~/js/main.js"));
            
            bundles.Add(new StyleBundle("~/Content/admin/css").Include(
                     "~/css/bootstrap.min.css",
                     "~/css/style.css"));
            
        }
    }
}
