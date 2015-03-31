using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryNEW
{
    class Circle : Shape
    {
        double x, y;
        int r;
        string name;
        public void Load(Filer type)
        {
            this.x = type.rdDouble(1);
            this.y = type.rdDouble(2);
            this.r = type.rdInt(3);
            this.name = type.rdString(4);
           
        }
    }
}
