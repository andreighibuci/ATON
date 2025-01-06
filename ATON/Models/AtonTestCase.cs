using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATON.Models
{

    //Object Designed to be the Testcase Container 
    public class AtonTestCase 
    {
        //ATON Testcase Name 
        public String Name { get; set; }

        //ATON Testcase Description
        public String Description { get; set; }

        //List with ATON Functions to be executed at testcase runtime
        public ObservableCollection<AtonFunction> Functions { get; set; }

    }
}
