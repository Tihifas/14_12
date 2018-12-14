using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OperasWebSite.Models
{
    public class OperasInitializer : DropCreateDatabaseAlways<OperasDB>
    {
        protected override void Seed(OperasDB context)
        {
            var operas = new List<Opera>
            {
                new Opera
                {
                    Title = "Cost van Tutte",
                    Year = 1790,
                    Composer = "Mozart"
                }
            };

            operas.ForEach( a => context.Operas.Add(a));
            context.SaveChanges();
        }
    }
}