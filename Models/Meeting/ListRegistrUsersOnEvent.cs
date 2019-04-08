using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolesApp.Models.Meeting
{
    public class ListRegistrUsersOnEvent
    {
        public int id { get; set; }
        public int IdUser { get; set; }
        public int IdMeeting { get; set; }
    }
}
