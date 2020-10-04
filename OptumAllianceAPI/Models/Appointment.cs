using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptumAllianceAPI.Models
{
    public class Appointment
    {
        public string MemberName { get; set; }
        public string MemberID { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string Gender { get; set; }
        public DateTime? MemberDOB { get; set;}

    }
}