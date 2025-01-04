using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATON.Models
{
    public class AtonTestCase : AtonObjectType
    {
        public Image ObjImg { get => new Bitmap("./Resouurces/TestcaseIcon.png"); }
    }
}
