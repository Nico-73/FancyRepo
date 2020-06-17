using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace FancyClassLibrary
{
    public interface IUnfancyInterface
    {
        string VeryUnfancyString { get; }

        string ALittleBitMoreUnfancyString { get; set; }

        Mock<IEnumerable<string>> UnfancyStringListMock { get; }

        LessFancyClass LessFancyClass { get; set; }

        void DoExtremelyUnfancyThings();
    }
}
