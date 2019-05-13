using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringConcat;

namespace StringConcatenationTestModule
{
    [TestClass]
    public class StringConcatenationTest
    {
        [TestMethod]
        public void test_add_lh_rh_no_space_result_lh_space_rh()
        {
            // Arrange
            StringConcatenation cut = new StringConcatenation();
            string lh = "AA";
            string rh = "BB";
            string expected = "AA BB";
            
            // Act
            string result = cut.addStrings(lh, rh);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
