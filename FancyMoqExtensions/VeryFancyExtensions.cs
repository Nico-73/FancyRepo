using System.Collections.Generic;
using Moq;

namespace FancyMoqExtensions
{
    public static class VeryFancyExtensions
    {
        public static void DoSomeFancyThings(this Mock<IEnumerable<string>> fancyMock, string fancyName)
        {
            fancyMock.Name = fancyName;
        }
    }
}
