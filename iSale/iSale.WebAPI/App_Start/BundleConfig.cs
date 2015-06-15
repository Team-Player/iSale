using System.Web;
using System.Web.Optimization;

namespace TP_2015
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/leaflet").Include(
                      "~/Scripts/leaflet-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/geosearch").Include(
                      "~/Scripts/l.control.geosearch.js"));

            bundles.Add(new ScriptBundle("~/bundles/geosearchm").Include(
                      "~/Scripts/l.control.geosearch.m.js"));

            bundles.Add(new ScriptBundle("~/bundles/osmsearch").Include(
                      "~/Scripts/l.geosearch.provider.openstreetmap.js"));

            bundles.Add(new ScriptBundle("~/bundles/googlesearch").Include(
                      "~/Scripts/l.geosearch.provider.google.js"));

            bundles.Add(new ScriptBundle("~/bundles/nokiasearch").Include(
                      "~/Scripts/l.geosearch.provider.nokia.js"));

            bundles.Add(new ScriptBundle("~/bundles/esrisearch").Include(
                      "~/Scripts/l.geosearch.provider.esri.js"));

            bundles.Add(new ScriptBundle("~/bundles/bingsearch").Include(
                      "~/Scripts/l.geosearch.provider.bing.js"));

            bundles.Add(new ScriptBundle("~/bundles/tiles").Include(
                      "~/Scripts/tile/bing.js",
                      "~/Scripts/tile/Google.js",
                      "~/Scripts/tile/Yandex.js"
                      ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/font-awesome.css",
                      "~/Content/leaflet.css",
                      "~/Content/l.geosearch.css",
                      "~/Content/site.css"
            ));
        }
    }
}
