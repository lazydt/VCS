using VCS;
using VCSLibrary;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassDirectoryString_ReturnsByteCollection()
        {

            //Arrange//
            var test = new Buffers();

            //Act//
            var result = test.CreateBuffer(Directory.GetCurrentDirectory());

            //Assert//
            Assert.NotEmpty(result);

        }
    }
}

