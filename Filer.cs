using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FactoryNEW
{
    abstract class Filer
    {
        public int rdInt(int count);
        public double rdDouble(int count);
        public string rdString(int count);
        public bool eof();
    }
}
