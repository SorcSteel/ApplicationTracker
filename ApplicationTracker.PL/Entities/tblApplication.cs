using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTracker.PL.Entities
{
    public class tblApplication
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Status { get; set; }
        public string Position { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Location { get; set; }
    }
}
