using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.FancyFolder;
using FancyClassLibrary;
using Moq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double fancyDouble = 0.3;
            new SuperFancyClass(new FancyClass()).FancyObject.FancyMethod(fancyDouble);

            Mock<IUnfancyInterface> unfancyMock = new Mock<IUnfancyInterface>();
            unfancyMock.CallBase = true;
        }
    }
}
