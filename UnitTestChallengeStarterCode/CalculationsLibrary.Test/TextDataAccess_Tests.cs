using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace CalculationsLibrary.Test
{
    public class TextDataAccess_Tests
    {
        [Fact]
        public void SaveText_Normal()
        {
            List<string> lines = new List<string>()
            {
                "Test one", 
                "Test two", 
                "test three"
            };

            string filePath = @"C:\Temp\Test.txt";
            string fileName = "Test.txt";

            var mock = new Mock<IWriteToText>();
            mock.Setup(x => x.WriteToFile(fileName, It.IsAny<List<string>>())).Verifiable();

            TextDataAccess dataAccess = new TextDataAccess();
            dataAccess.SaveText(filePath, lines, mock.Object);

            mock.Verify();
        }

        [Fact]
        public void SaveText_InvalidPath_ShouldThrowException()
        {
            List<string> lines = new List<string>()
            {
                "Test one",
                "Test two",
                "test three"
            };

            string fileName = @"C:\Temp\Test.txt";
            string filePath = "Test.txtddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd" +
                "txtddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd" +
                "txtddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd" +
                "txtddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd" +
                "txtddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd" +
                "txtddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd";

            var mock = new Mock<IWriteToText>();
            mock.Setup(x => x.WriteToFile(fileName, It.IsAny<List<string>>())).Verifiable();

            TextDataAccess dataAccess = new TextDataAccess();

            Assert.Throws<PathTooLongException>(
                () => dataAccess.SaveText(filePath, lines, mock.Object));
        }
    }
}
