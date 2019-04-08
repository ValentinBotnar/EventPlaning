using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RolesApp.Models
{
    public class NameMeetingEvent
    {
        [Key]
        public int Id { get; set; }
        public string NameEvent { get; set; }
    }
}
