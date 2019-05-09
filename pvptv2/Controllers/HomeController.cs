using pvptv2.Hubs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pvptv2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descoperă frumusețea Brașovului";

            return View();
        }

        public ActionResult Travel()
        {
            ViewBag.Message = "Bucură-te de experiențe minunate";

            return View();
        }

        public ActionResult Activities()
        {
            ViewBag.Message = "Activități";

            return View();
        }

        public ActionResult Relax()
        {
            ViewBag.Message = "Relaxare";

            return View();
        }

        public ActionResult Eat()
        {
            ViewBag.Message = "Mancare buna.";

            return View();
        }

        public ActionResult Play()
        {
            ViewBag.Message = "Play";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Evenimente";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Noutati";

            return View();
        }

        public ActionResult Opinion()
        {
            ViewBag.Message = "Parerea ta!";

            return View();
        }

        public JsonResult Get()
        {

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NotificationsConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"SELECT [Data],[Ora],[Eveniment],[Titlu],[Locație] FROM [dbo].[NotifEvents]", connection))
                {
                    // Make sure the command object does not already have
                    // a notification object associated with it.
                    command.Notification = null;

                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    var listEvents = new List<string>();
                    while (reader.Read())
                    {
                        listEvents.Add(reader[0].ToString());
                    }
                    reader.Close();

                    //var listNotif = reader.Cast<IDataRecord>()
                    //        .Select(x => new
                    //        {
                    //            Data = (int)x["Data"],
                    //            Ora = (string)x["Ora"],
                    //            Eveniment = (string)x["Eveniment"],
                    //            Titlu = (string)x["Titlu"],
                    //            Locație = (string)x["Locație"],
                    //        }).ToList();

                    return Json(new { listNotif = listEvents }, JsonRequestBehavior.AllowGet);

                }
            }
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            NotifHub.Show();
        }
    }
}