using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATON.Models
{

    //AtonFunctions are object designed to contain runnable python code and be used inside TestCases
    public class AtonFunction 
    {

       //ATON Function Name 
       public String Name { get; set; } 

       //ATON Function Description
       public String Description { get; set; }


       //Python Code Container
       public String PyCode { get; set; } 

        
    }
}
