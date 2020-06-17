using System.Collections.Generic;
using FancyMoqExtensions;
using Moq;

namespace FancyClassLibrary
{
    public class UnfancyClass : IUnfancyInterface
    {
        private string _aLittleBitMoreUnfancyString;

        public UnfancyClass()
        {
            UnfancyStringListMock = new Mock<IEnumerable<string>>();
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

        public void DoExtremelyUnfancyThings()
        {
            UnfancyStringListMock.DoSomeFancyThings("This string is unfancy.");
        }
    }
}
