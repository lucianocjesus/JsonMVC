using System.Web.Optimization;

namespace JsonMVC.Web
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

			bundles.Add(new ScriptBundle("~/bundles/usuario").Include(
						"~/Scripts/jquery.tabletojson.js",
						"~/Scripts/usuario/functionusuario.js"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/respond.js"));

			//Bundles de scripts para templante bucket
			bundles.Add(new ScriptBundle("~/bundles/themebucket").Include(
						"~/Scripts/themebucket/jquery-ui-1.10.1.custom.min.js",
						"~/Scripts/themebucket/jquery.dcjqaccordion.2.7.js",
						"~/Scripts/themebucket/jquery.scrollTo.min.js",
						"~/Scripts/themebucket/jquery.slimscroll.js",
						"~/Scripts/themebucket/jquery.nicescroll.js",
						"~/Scripts/themebucket/skycons.js",
						"~/Scripts/themebucket/jquery.scrollTo.js",
						"~/Scripts/themebucket/clndr.js",
						"~/Scripts/themebucket/moment-2.2.1.js",
						"~/Scripts/themebucket/evnt.calendar.init.js",
						"~/Scripts/themebucket/jquery-jvectormap-1.2.2.min.js",
						"~/Scripts/themebucket/jquery-jvectormap-us-lcc-en.js",
						//"~/Scripts/themebucket/gauge.js",
						"~/Scripts/themebucket/jquery.easypiechart.js",
						"~/Scripts/themebucket/jquery.sparkline.js",
						//"~/Scripts/themebucket/morris.js",
						"~/Scripts/themebucket/raphael-min.js",
						//"~/Scripts/themebucket/jquery.flot.js",
						//"~/Scripts/themebucket/jquery.flot.tooltip.min.js",
						//"~/Scripts/themebucket/jquery.flot.resize.js",
						//"~/Scripts/themebucket/jquery.flot.pie.resize.js",
						"~/Scripts/themebucket/jquery.flot.animator.min.js",
						//"~/Scripts/themebucket/jquery.flot.growraf.js",
						//"~/Scripts/themebucket/dashboard.js",
						"~/Scripts/themebucket/jquery.customSelect.min.js",
						"~/Scripts/themebucket/scripts.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/bootstrap-theme.css",
					  "~/font-awesome/css/font-awesome.min.css",
					  "~/Content/site.css"));

			//Bundles de css para pagina de login
			bundles.Add(new StyleBundle("~/Content/login").Include(
						"~/Content/animate.css",
						"~/Content/login/StyleLogin.css"));

			//Bundles de css para templante Bucket
			bundles.Add(new StyleBundle("~/Content/bucket").Include(
						"~/Content/themebucket/bootstrap-reset.css",
						"~/Content/themebucket/clndr.css",
						"~/Content/themebucket/jquery-jvectormap-1.2.2.css",
						"~/Content/themebucket/jquery-ui-1.10.1.custom.min.css",
						"~/Content/themebucket/style.css",
						"~/Content/themebucket/style-responsive.css"));

		}
	}
}
