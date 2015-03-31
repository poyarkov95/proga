using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FactoryNEW
{
    class FileFiler : Filer
    {
        StreamReader str;
        string[] ch;
        public FileFiler(string path)
        {
            str = new StreamReader(path);
        }
        public override bool eof()
        {
            ch = str.ReadLine().Split(' ');
            return !str.EndOfStream;
        }
        public override int rdInt(int count)
        {
            int getInt = Convert.ToInt32(ch[count]);
            return getInt;
        }
        public override double rdDouble(int count)
        {
            double getDouble = Convert.ToDouble(ch[count]);
            return getDouble;
        }
        public override string rdString(int count)
        {
            return ch[count];
        }
        
        
    }
}