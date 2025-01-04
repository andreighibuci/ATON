using ATON.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATON.Helpers
{
    public static class StaticDB
    {
        public static ObservableCollection<AtonObject> AtonObjects = new ObservableCollection<AtonObject>();
    }
}
