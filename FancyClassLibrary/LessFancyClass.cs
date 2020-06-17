using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyMoqExtensions;
using NLog;

namespace FancyClassLibrary
{
    public class LessFancyClass
    {
        public LessFancyClass(Logger fancyLogger)
        {
            MoreLessFancyString = fancyLogger.GetFancyStringByLogger();
        }

        public string MoreLessFancyString { get; }
    }
}
