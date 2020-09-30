using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectP.Core.UnitTests
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            var sut = new DTO.Group();
            Assert.IsNotNull(sut.Groups);
            Assert.IsNotNull(sut.Links);
            Assert.IsNotNull(sut.Things);
        }
    }
}
