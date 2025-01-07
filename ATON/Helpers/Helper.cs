using ATON.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ATON.Helpers
{
    public static class Helper
    {
        //Python Code Save Path
        public static readonly string pCodePath = "C:\\Data\\Aton\\pCode\\";
        
        //Navi Frame used throught MainWindow to collaborate with other VMs
        public static Frame EditorFrame { get; set; }


        //Function to Save Current Python Code of a function
        public static void SaveAtonFunction(AtonFunction atonFunction)
        {
            // Write each line to the file
            using (StreamWriter writer = new StreamWriter(pCodePath + atonFunction.Name + ".py")) {
                foreach (string pyCodeLine in atonFunction.PyCode) {
                    writer.WriteLine(pyCodeLine); 
                } 
            }

        }
    }
}
