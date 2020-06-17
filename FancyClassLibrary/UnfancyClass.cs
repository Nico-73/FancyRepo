using System.Collections.Generic;
using FancyMoqExtensions;
using Moq;
using NLog;

namespace FancyClassLibrary
{
    public class UnfancyClass : IUnfancyInterface
    {
        private string _aLittleBitMoreUnfancyString;

        public UnfancyClass()
        {
            UnfancyStringListMock = new Mock<IEnumerable<string>>();
            LessFancyClass = new LessFancyClass(new NullLogger(new LogFactory()));
        }

        /// <inheritdoc />
        public string VeryUnfancyString => "This string is so unfancy!";

        /// <inheritdoc />
        public string ALittleBitMoreUnfancyString
        {
            get => _aLittleBitMoreUnfancyString;
            set => _aLittleBitMoreUnfancyString = value;
        }

        /// <inheritdoc />
        public Mock<IEnumerable<string>> UnfancyStringListMock { get; }

        /// <inheritdoc />
        public LessFancyClass LessFancyClass { get; set; }

        public void DoExtremelyUnfancyThings()
        {
            UnfancyStringListMock.DoSomeFancyThings("This string is unfancy.");
        }
    }
}
