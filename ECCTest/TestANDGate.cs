using ECCServices.Services;

namespace ECCTest
{
    [TestClass]
    public class TestANDGate
    {
        [TestMethod]
        public void And ()
        {
            // Arrange.
            var andGate = new ANDGate ();

            // Act.
            var boolResultAllFalse = andGate.AND (false, false);
            var boolResultOneFalseA = andGate.AND (false, true);
            var boolResultOneFalseB = andGate.AND (true, false);
            var boolResultAllTrue = andGate.AND (true, true);
            var uintResult = andGate.AND (0b11110011001111, 0b01101000010110);

            // Assert.
            Assert.AreEqual (false, boolResultAllFalse);
            Assert.AreEqual (false, boolResultOneFalseA);
            Assert.AreEqual (false, boolResultOneFalseB);
            Assert.AreEqual (true, boolResultAllTrue);
            Assert.AreEqual ((uint) 0b01100000000110, uintResult);
        }
    }
}