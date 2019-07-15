using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DAL.Models
{
    public class CustomViewModel
    {
        public List<MarkUpPlan> MarkUpPlanList { get; set; }
        public List<TextValueModel> AgnetTypeList { get; set; }
        public List<TextValueModel> FlightApiList { get; set; }
        public List<TextValueModel> StatusList { get; set; }

        public CustomViewModel()
        {
            this.AgnetTypeList = new List<TextValueModel>
            {
                new TextValueModel { Value = "1", Text = "B2B"},
                new TextValueModel { Value = "2", Text = "B2C"}
            };

            this.FlightApiList = new List<TextValueModel>
            {
                new TextValueModel { Value = "1", Text = "REGENT"},
                new TextValueModel { Value = "2", Text = "NOVO"},
                new TextValueModel { Value = "3", Text = "GALILEO "},
                new TextValueModel { Value = "4", Text = "USB-S"},
                new TextValueModel { Value = "5", Text = "INDIGO"}
            };

            this.StatusList = new List<TextValueModel>
            {
                new TextValueModel { Value = "1", Text = "NEW"},
                new TextValueModel { Value = "2", Text = "ACTIVE"},
                new TextValueModel { Value = "3", Text = "INACTIVE"},
                new TextValueModel { Value = "4", Text = "LOCKED"}
            };
        }
    }
}
