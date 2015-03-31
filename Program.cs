using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace FactoryNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            Filer f = new FileFiler("InputDataFile.txt");
            var obj = pr.loadFile(f);
            Console.ReadKey();
        }

        ArrayList loadFile(Filer filer)
        {
            Program pr = new Program();
            ArrayList arr = new ArrayList();

            while(filer.eof())
            {
                int header = filer.rdInt(0);
                Shape s = pr.ChoiseType(header);
                s.Load(filer);
                arr.Add(s);
            }
            return arr;
        }

        public Shape ChoiseType(int type)
        {
            switch (type)
            {
                case 1:
                    return new Circle();
                case 2:
                    return new Square();
                case 3:
                    return new Line();
                default: return null;
            }
        }
    }
}

