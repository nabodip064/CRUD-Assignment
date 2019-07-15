namespace CRUD.DAL.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUD.DAL.Models.Context.CRUDDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRUD.DAL.Models.Context.CRUDDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //IList<MarkUpPlan> plans = new List<MarkUpPlan>();
            //plans.Add(new MarkUpPlan {
            //    MarkUpPlanName = "HT Agent Transaction Above 1 Lac"
            //});

            //plans.Add(new MarkUpPlan
            //{
            //    MarkUpPlanName = "HT Agent Transaction Above 5 Lac"
            //});

            //plans.Add(new MarkUpPlan
            //{
            //    MarkUpPlanName = "HT Agent Transaction Above 10 Lac"
            //});

            //plans.Add(new MarkUpPlan
            //{
            //    MarkUpPlanName = "HT Agent Transaction Above 15 Lac"
            //});

            //plans.Add(new MarkUpPlan
            //{
            //    MarkUpPlanName = "HT Agent Transaction Above 20 Lac"
            //});

            //plans.Add(new MarkUpPlan
            //{
            //    MarkUpPlanName = "HT Agent Transaction Above 25 Lac"
            //});

            //foreach (MarkUpPlan plan in plans)
            //    context.MarkUpPlans.Add(plan);
            //base.Seed(context);
        }
    }
}
