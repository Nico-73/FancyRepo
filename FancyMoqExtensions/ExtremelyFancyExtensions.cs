using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace FancyMoqExtensions
{
    public static class ExtremelyFancyExtensions
    {
        public static string GetFancyStringByLogger(this Logger logger)
        {
            return logger.GetHashCode().ToString();
        }
    }
}
