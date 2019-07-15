using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD.DAL.Models.Context
{
    public class CRUDDBContext : DbContext
    {
        public CRUDDBContext()
        {

        }
        public DbSet<AgentInfoModel> AgentInfoModels { get; set; }
        public DbSet<AgentWithFlightAPIS> AgentWithFlightAPISs { get; set; }
        public DbSet<MarkUpPlan> MarkUpPlans { get; set; }
    }
}