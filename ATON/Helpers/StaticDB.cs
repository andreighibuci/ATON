using ATON.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATON.Helpers
{

    //Use Static Database for object containers (not eficient but easy to maintain and use)
    public static class StaticDB
    {
        //Place holder for all Functons available in App
        public static ObservableCollection<AtonFunction> Functions = new ObservableCollection<AtonFunction>();

        //Place holder for all Testcases available in App
        public static ObservableCollection<AtonTestCase> TestCases = new ObservableCollection<AtonTestCase>();
    }
}
