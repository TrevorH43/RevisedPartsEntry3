namespace UtilityLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidateNumericIsNull()
        {
            double? doubleVal;
            string validationMessage;
            bool valid = Utility.ValidateIsNumeric(null, "Part Number", out validationMessage, out doubleVal);
            Assert.IsFalse(valid, "Method did not return the expected value of False for valid");
            Assert.AreEqual("Part Number is required", validationMessage,
                "Method did not return the expected validation message");
            Assert.IsNull(doubleVal, "Method did not return the expected value for doubleVal");

        }
        [TestMethod]
        public void TestValidateNumericIsEmpty()
        {
            double? doubleVal;
            string validationMessage;
            bool valid = Utility.ValidateIsNumeric("", "Part Number", out validationMessage, out doubleVal);
            Assert.IsFalse(valid, "Method did not return the expected value of False for valid");
            Assert.AreEqual("Part Number is required", validationMessage,
                "Method did not return the expected validation message");
            Assert.IsNull(doubleVal, "Method did not return the expected value for doubleVal");
        }
        [TestMethod]
        public void TestValidateNumericIsNonNumeric()
        {
            double? doubleVal;
            string validationMessage;
            bool valid = Utility.ValidateIsNumeric("ABCD", "Part Number", out validationMessage, out doubleVal);
            Assert.IsFalse(valid, "Method did not return the expected value of False for valid");
            Assert.AreEqual("Part Number is not numeric.", validationMessage,
                "Method did not return the expected validation message");
            Assert.IsNull(doubleVal, "Method did not return the expected value for doubleVal");
      }
        [TestMethod]
        public void TestValidateNumericIsValid()
        {
            double? doubleVal;
            string validationMessage;
            bool valid = Utility.ValidateIsNumeric("123.45", "Part Number", out validationMessage, out doubleVal);
            Assert.IsTrue(valid, "Method did not return the expected value of True for valid");
            Assert.IsTrue(string.IsNullOrEmpty(validationMessage), "Method did not return the expected message");
            Assert.IsNotNull(doubleVal, "Method did not return the expected value for doubleVal");
            Assert.AreEqual(123.45, doubleVal.Value, "Method did not return the expected value for doubleVal");
        }

    }
}

   