using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectP.Core.UnitTests
{
    [TestClass]
    public class ThingTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            var sut = new DTO.Thing();
            Assert.IsNotNull(sut.Properties);
            Assert.IsNotNull(sut.Links);
        }
    }
}
