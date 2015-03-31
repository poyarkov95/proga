using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryNEW
{
    class Line : Shape
    { 
        double x1, y1, x2, y2;
        string name;
        public void Load(Filer type)
        {
            this.x1 = type.rdDouble(1);
            this.y1 = type.rdDouble(2);
            this.x2 = type.rdDouble(3);
            this.y2 = type.rdDouble(4);
            this.name = type.rdString(5);
            
        }
    }
}
