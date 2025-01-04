using ATON.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATON.Helpers
{
    public static class Mockuper
    {
        //Create Random Objects for populating Project Explorer List
        public static ObservableCollection<AtonObject> CreateRandObjects()
        {
            ObservableCollection<AtonObject> atonObjects = new ObservableCollection<AtonObject>();

            AtonObject Testcase = new AtonObject { 
                Name = "Test1",
                Description = "Testing Sth..",
                AtonObjectType = new AtonTestCase()};

            atonObjects.Add(Testcase);
            return atonObjects;

        }
    }
}
