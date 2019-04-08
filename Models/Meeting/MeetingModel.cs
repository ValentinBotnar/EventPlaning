                using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolesApp.Models.Meeting
{
    public class MeetingModel
    {
        public string NameEvent { get; set; }

        public List<string> HeaderEvent { get; set; }

        public List<string> ContextEvent { get; set; }
    }
}
