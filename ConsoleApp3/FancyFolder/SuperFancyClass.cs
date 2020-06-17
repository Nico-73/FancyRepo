using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyClassLibrary;
using FancyMoqExtensions;
using Moq;
using Newtonsoft.Json;

namespace ConsoleApp3.FancyFolder
{
    public class SuperFancyClass
    {
        public SuperFancyClass(FancyClass fancyObject)
        {
            FancyObject = fancyObject;
            FancyObject.UnfancyMember = new UnfancyClass();
            FancyObject.UnfancyMember.DoExtremelyUnfancyThings();
            Mock<IEnumerable<string>> fancyMock = new Mock<IEnumerable<string>>();
            fancyMock.DoSomeFancyThings("this string is fancy");

            JsonReader reader = new JsonTextReader(new StreamReader(new BufferedStream(Stream.Null)));
        }

        public FancyClass FancyObject { get; }
    }
}
