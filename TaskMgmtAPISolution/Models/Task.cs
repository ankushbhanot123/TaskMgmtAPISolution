using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskMgmtAPISolution.Models
{
    public class ATask
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