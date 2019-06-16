using pvptv2.Hubs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace pvptv2.Models
{
    public class Notification
    {
        [Key]
        public int EventID { get; set; }

        public DateTime EventDate { get; set; }

        public string EventName { get; set; }

        public string EventType { get; set; }

        public string EventLocation { get; set; }

















        //static readonly string connString = (@"data Source = .\SQLEXPRESS;initial Catalog = pvptv2;");

        //internal static SqlCommand command = null;
        //internal static SqlDependency dependency = null;

        ////Get notifications
        //public static string GetNotification()
        //{
        //    try
        //    {
        //        var messages = new List<Notification>();
        //        using (var connection = new SqlConnection(connString))
        //        {
        //            connection.Open();
        //            //Always use "dbo" prefix of database to trigger change event
        //            using (command = new SqlCommand(@"SELECT[EventID],[EventDate],[EventName],[EventType],[EventLocation] FROM[dbo].[Notifications]", connection));
        //            {
        //                command.Notification = null;

        //                if (dependency == null)
        //                {
        //                    dependency = new SqlDependency(command);
        //                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);
        //                }

        //                if (connection.State == System.Data.ConnectionState.Closed)
        //                    connection.Open();

        //                var reader = command.ExecuteReader();

        //                while (reader.Read())
        //                {
        //                    //DateTime aDate = DateTime.Now;
        //                    messages.Add(item: new Notification
        //                    {
        //                        EventID = (int)reader["EventID"],
        //                        //EventDate = reader["EventDate"] != DBNull.Value ? (string)reader["EventDate"] : "",
        //                        EventName = reader["EventName"] != DBNull.Value ? (string)reader["EventName"] : "",
        //                        EventType = reader["EventType"] != DBNull.Value ? (string)reader["EventType"] : "",
        //                        EventLocation = reader["EventLocation"] != DBNull.Value ? (string)reader["EventLocation"] : "",

        //                    });
        //                }
        //            }
        //        }
        //        var jsonSerializer = new JavaScriptSerializer();
        //        var json = jsonSerializer.Serialize(messages);
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return null;
        //}


        //private static void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        //{
        //    if(dependency != null)
        //    {
        //        dependency.OnChange -= dependency_OnChange;
        //        dependency = null;
        //    }
        //    if(e.Type == SqlNotificationType.Change)
        //    {
        //        NotifHub.Send();
        //    }
        //}

    }
}