using DAT.Model;

namespace DAT.Tests
{
    [TestClass]
    public class TestPagedMemory
    {
        [TestMethod]
        public void TestZeroes()
        {
            var memory = new PagedMemory(0, 0, 0);
        }
    }
}