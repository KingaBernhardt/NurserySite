using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationNursery.Models
{
    public class Group
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int NumbersOfChildren { get; set; }
        public string Teacher { get; set; }
        public string TeacherAssistant { get; set; }
        public string PictureUrl { get; set; }
    }
}
