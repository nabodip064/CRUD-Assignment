using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.DAL.Models
{
    public class AgentWithFlightAPIS
    {
        [Key]
        [Required]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Agent Info Id")]
        public int? AgentInfoId { get; set; }

        [DisplayName("Flight API Id")]
        public int? FlightAPIId { get; set; }

        public bool IsDeleted { get; set; }
    }
}