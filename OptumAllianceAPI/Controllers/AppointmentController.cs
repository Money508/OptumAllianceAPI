using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OptumAllianceAPI.Models;
namespace OptumAllianceAPI.Controllers
{

    public class AppointmentController : ApiController
    {
        public static List<Appointment> appointmentList = new List<Appointment>()
        {
            new Appointment { MemberName="James Kroft", MemberID ="999982", ScheduledDate=Convert.ToDateTime("10-01-2020"), Gender="Male", MemberDOB=Convert.ToDateTime("11-11-1950")},
            new Appointment { MemberName="Barbara Mcarthur", MemberID ="2222654", ScheduledDate=Convert.ToDateTime("10-01-2020"), Gender="Female", MemberDOB=Convert.ToDateTime("01-08-1956")},
            new Appointment { MemberName="Ana Jones", MemberID ="4443453", ScheduledDate=Convert.ToDateTime("10-01-2020"), Gender="Female", MemberDOB=Convert.ToDateTime("05-08-1965")},
            new Appointment { MemberName="Donald Thompson", MemberID ="667348", ScheduledDate=Convert.ToDateTime("10-01-2020"), Gender="Male", MemberDOB=Convert.ToDateTime("04-05-1951")},
            new Appointment { MemberName="Maria Smith", MemberID ="667348", ScheduledDate=Convert.ToDateTime("10-01-2020"), Gender="Female", MemberDOB=Convert.ToDateTime("07-15-1958")},
        };
        [Route("api/Appointment/")]
        public List<Appointment> Get()
        {
            return appointmentList;
        }
        [Route("api/Appointment/{id}")]
        public Appointment Get(string id)
        {
            Appointment appID = (from a in appointmentList
                                 where a.MemberID == id
                                 select a).SingleOrDefault();
                return appID;
        }
    }
}
