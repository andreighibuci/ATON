using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATON.Models
{
    public class AtonObject
    {
        public String Name { get; set; }  
        public String Description { get; set; } 
        public AtonObjectType AtonObjectType { get; set; }
    }
}
