using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectP.Core.UnitTests
{
    [TestClass]
    public class AppCoreTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            Assert.IsNotNull(AppCore.GroupsStorage);
            Assert.IsNotNull(AppCore.PrototypesStorage);
        }
    }
}
