using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryNEW
{
    class Square : Shape
    {
        double x, y, side;
        string name;
        public void Load(Filer type)
        {
            this.x = type.rdDouble(1);
            this.y = type.rdDouble(2);
            this.side = type.rdDouble(3);
            this.name = type.rdString(4);
        }
    }
}
