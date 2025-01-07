using ATON.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATON.Helpers
{
    public static class Mockuper
    {
        //Create Random Objects for populating Project Explorer List with Functions
        public static ObservableCollection<AtonFunction> CreateRandFuncs()
        {
            ObservableCollection<AtonFunction> randomFuncs = new ObservableCollection<AtonFunction>();

            randomFuncs.Add(new AtonFunction { Name = "WriteVar", PyCode = new string[] { "if 1>0:", "  print(\"yes\")" } });
            randomFuncs.Add(new AtonFunction { Name = "WriteVar1" });
            randomFuncs.Add(new AtonFunction { Name = "WriteVar2" });


            return randomFuncs;
        }


        //Create Random Objects for populating Project Explorer List with TestCases
        public static ObservableCollection<AtonTestCase> CreateRandTestCases()
        {

            ObservableCollection<AtonTestCase> randomTestcases = new ObservableCollection<AtonTestCase>();

            randomTestcases.Add(new AtonTestCase { Name = "Test1" });
            randomTestcases.Add(new AtonTestCase { Name = "Test2" });
            randomTestcases.Add(new AtonTestCase { Name = "Test3" });


            return randomTestcases;

        }
    }
}
