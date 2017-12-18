using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMgmt.Domain.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; }
        public DateTime Date { get; set; }
        public double EstimatedCost { get; set; }
        public string Description { get; set; }
        public DateTime AddedOn { get; set; }
        public bool Status { get; set; }
    }
}