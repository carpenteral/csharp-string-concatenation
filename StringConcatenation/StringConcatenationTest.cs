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
        [TestMethod]
        public void test_add_lh_space_rh_no_space_result_lh_space_rh()
        {
            // Arrange
            StringConcatenation cut = new StringConcatenation();
            string lh = "AA ";
            string rh = "BB";
            string expected = "AA BB";

            // Act
            string result = cut.addStrings(lh, rh);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void test_add_lh_no_space_rh_space_result_lh_space_rh()
        {
            // Arrange
            StringConcatenation cut = new StringConcatenation();
            string lh = "AA";
            string rh = "BB ";
            string expected = "AA BB";

            // Act
            string result = cut.addStrings(lh, rh);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void test_add_space_lh_rh_no_space_result_lh_space_rh()
        {
            // Arrange
            StringConcatenation cut = new StringConcatenation();
            string lh = " AA";
            string rh = "BB";
            string expected = "AA BB";

            // Act
            string result = cut.addStrings(lh, rh);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void test_add_lh_no_space_space_rh_result_lh_space_rh()
        {
            // Arrange
            StringConcatenation cut = new StringConcatenation();
            string lh = "AA";
            string rh = " BB";
            string expected = "AA BB";

            // Act
            string result = cut.addStrings(lh, rh);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void test_add_lh_space_rh_space_result_lh_space_rh()
        {
            // Arrange
            StringConcatenation cut = new StringConcatenation();
            string lh = "AA";
            string rh = " BB ";
            string expected = "AA BB";

            // Act
            string result = cut.addStrings(lh, rh);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void test_add_lh_blank_rh_blank_result_space()
        {
            // Arrange
            StringConcatenation cut = new StringConcatenation();
            string lh = "";
            string rh = "";
            string expected = " ";

            // Act
            string result = cut.addStrings(lh, rh);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void test_add_lh_blank_space_rh_blank_result_space()
        {
            // Arrange
            StringConcatenation cut = new StringConcatenation();
            string lh = " ";
            string rh = "";
            string expected = "  ";

            // Act
            string result = cut.addStrings(lh, rh);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void test_add_lh_blank_space_rh_blank_space_result_space()
        {
            // Arrange
            StringConcatenation cut = new StringConcatenation();
            string lh = "";
            string rh = " ";
            string expected = "  ";

            // Act
            string result = cut.addStrings(lh, rh);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
