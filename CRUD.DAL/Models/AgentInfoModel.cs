using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.DAL.Models
{
    public class AgentInfoModel
    {
        [Key]
        [Required]
        [DisplayName("Agent Info Id")]
        public int AgentInfoId { get; set; }

        [Required]
        [DisplayName("Code")]
        public string AgentCode { get; set; }
        
        [DisplayName("Name")]
        public string AgentName { get; set; }

        [DisplayName("Mark Up Plan")]
        public int MarkUpPlanId { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Mobile")]
        public string Mobile { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("State")]
        public string State { get; set; }

        [DisplayName("Post Code")]
        public string PostCode { get; set; }

        [DisplayName("Joining Date")]
        public DateTime? JoiningDate { get; set; }

        [DisplayName("Balance")]
        public double Balance { get; set; }

        [DisplayName("Agent Types")]
        public int? AgentTypes { get; set; }

        [DisplayName("Flight APIS")]
        public int? FlightAPIS { get; set; }

        [DisplayName("Status")]
        public int? Status { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<AgentWithFlightAPIS> FlightAPIList { get; set; }
        public virtual MarkUpPlan Plan { get; set; }
    }
}