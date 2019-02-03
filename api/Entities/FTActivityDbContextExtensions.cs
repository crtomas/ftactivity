using System.Collections.Generic;
using System.Linq;
using System;

namespace FTActivity.Entities
{
    public static class FTActivityDbContextExtensions
    {
        public static void EnsureSeedDataForFTActivityDbContext(this FTActivityDbContext context)
        {
            if(context.Activities.Any())
            {
                return;
            }

            var activities = new List<Activity>()
            {
                new Activity() { Date = DateTime.Now, Contact="James", Amount = 13, Note="The 13 of July of 2018"  },
                new Activity() { Date = DateTime.Now, Contact="Kyle", Amount = 10, Note="The 17 of October of 2018"  }                
            };

            context.Activities.AddRange(activities);
            context.SaveChanges();
        }
    }
}