using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DAL.Models
{
    public class MarkUpPlan
    {
        [Key]
        [Required]
        public int MarkUpPlanId { get; set; }
        public string MarkUpPlanName { get; set; }
    }
}
