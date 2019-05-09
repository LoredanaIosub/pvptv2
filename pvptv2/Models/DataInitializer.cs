using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pvptv2.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var users = new List<Tourist>
            {
                new Tourist{FirstName="Loredana", LastName="Iosub", Nationality="romana", FeedBack="Un oras superb!"},
                new Tourist{FirstName="Admin", LastName="Admin", Nationality="romana", FeedBack="Un oras superb!"},
                new Tourist{FirstName="Aadmin", LastName="Aadmin", Nationality="romana", FeedBack="Un oras superb!"}
            };

            users.ForEach(u => context.Tourists.Add(u));
            context.SaveChanges();
        }
    }
}