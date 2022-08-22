using System.Web;
using System.Web.Optimization;

namespace ges_assoc
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            #region Template design

                bundles.Add(new ScriptBundle("~/template/js").Include(
                            "~/Scripts/js/jquery.min.js",
                            "~/Scripts/js/bootstrap.min.js",
                            "~/Scripts/js/waves.js",
                            "~/Scripts/js/wow.min.js",
                            "~/Scripts/js/jquery.nicescroll.js",
                            "~/Scripts/js/jquery.scrollTo.min.js",
                            "~/Scripts/js/jquery.app.js",
                            "~/Scripts/js/jquery.dashboard.js",
                            "~/Scripts/js/jquery.chat.js",
                            "~/Scripts/js/jquery.todo.js",
                            "~/Content/assets/flot-chart/jquery.flot.js",
                            "~/Content/assets/flot-chart/jquery.flot.time.js",
                            "~/Content/assets/flot-chart/jquery.flot.tooltip.min.js",
                            "~/Content/assets/flot-chart/jquery.flot.resize.js",
                            "~/Content/assets/flot-chart/jquery.flot.pie.js",
                            "~/Content/assets/flot-chart/jquery.flot.selection.js",
                            "~/Content/assets/flot-chart/jquery.flot.stack.js",
                            "~/Content/assets/flot-chart/jquery.flot.crosshair.js",
                            "~/Content/assets/chat/moment-2.2.1.js",
                            "~/Content/assets/jquery-sparkline/jquery.sparkline.min.js",
                            "~/Content/assets/jquery-detectmobile/detect.js",
                            "~/Content/assets/fastclick/fastclick.js",
                            "~/Content/assets/jquery-slimscroll/jquery.slimscroll.js",
                            "~/Content/assets/jquery-blockui/jquery.blockUI.js",
                            "~/Content/assets/counterup/waypoints.min.js",
                            "~/Content/assets/counterup/jquery.counterup.min.js"));



                bundles.Add(new StyleBundle("~/template/css").Include(
                         "~/Content/css/bootstrap.min.css",
                         "~/Content/assets/font-awesome/css/font-awesome.min.css",
                         "~/Content/assets/ionicon/css/ionicons.min.css",
                         "~/Content/css/material-design-iconic-font.min.css",
                         "~/Content/css/helper.css",
                         "~/Content/css/style.css",
                         "~/Content/assets/sweet-alert/sweet-alert.min.css",
                         "~/Content/css/waves-effect.css",
                         "~/Content/css/animate.css"));

            #endregion
        }
    }
}
