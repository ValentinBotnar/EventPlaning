using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolesApp.Models.Meeting
{
    public class MeetingInformation
    {
        public int Id { get; set; }
        public int MeetingID { get; set; }
        public string Header { get; set; }
        public string Context { get; set; }
    }
}
