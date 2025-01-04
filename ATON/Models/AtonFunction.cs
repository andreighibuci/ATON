using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATON.Models
{
    public class AtonFunction : AtonObjectType
    {
        public Image ObjImg { get => new Bitmap("./Resouurces/FunctionIcon.png"); }
    }
}
