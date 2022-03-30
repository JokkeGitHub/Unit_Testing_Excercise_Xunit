using Xunit;
using System.IO;
using System;

namespace Calculator.Test2
{
    public class ExamplesTests
    {
        [Fact]
        public void LoadTextFile_Fact_ValidNameShouldWork()
        {
            XUnit_Calculator.LoadFileExample loadFileExample = new XUnit_Calculator.LoadFileExample();

            string actualResult = loadFileExample.LoadTextFile("This is a valid file name");

            Assert.True(actualResult.Length > 0);
        }

        [Fact]
        public void LoadTextFile_Fact_InvalidNameShouldFail()
        {
            XUnit_Calculator.LoadFileExample loadFileExample = new XUnit_Calculator.LoadFileExample();

            Assert.Throws<ArgumentException>("File", () => loadFileExample.LoadTextFile(""));
        }
    }
}
