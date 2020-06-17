using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyClassLibrary;

namespace ConsoleApp3.FancyFolder
{
    public class FancyClass
    {
        public FancyClass()
        {
            FancyBool = true;
        }

        internal int FancyInt { get; private set; }
        internal bool FancyBool { get; }

        internal IUnfancyInterface UnfancyMember { get; set; }

        internal void FancyMethod(double fancyDouble)
        {
            FancyInt = (int)(fancyDouble * (FancyBool ? 1 : 2));
        }
    }
}
