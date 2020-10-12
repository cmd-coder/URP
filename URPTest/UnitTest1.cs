using Microsoft.VisualStudio.TestTools.UnitTesting;
using URP;

namespace URPTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodFName_Pass()//Test first name of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "Firstname";
            bool result = obj.matchFName(fName);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodFName_Fail()//Test first name of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "firstname";
            bool result = obj.matchFName(fName);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodLName_Pass()//Test last name of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "Lastname";
            bool result = obj.matchFName(fName);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodLName_Fail()//Test last name of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "lastname";
            bool result = obj.matchFName(fName);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodEmail_Pass()//Test mobile email id of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "abc@cd.com";
            bool result = obj.matchEmail(fName);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodEmail_Fail()//Test mobile email id of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "abc@cd.com.in.as";
            bool result = obj.matchEmail(fName);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodMobile_Pass()//Test mobile phone number of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "91 7894561230";
            bool result = obj.matchMobile(fName);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodMobile_Fail()//Test mobile phone number of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "91 0894561230";
            bool result = obj.matchMobile(fName);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodPassword_Pass()//Test password of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "dgds!54654SDGSG";
            bool result = obj.matchPassword(fName);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodPassword_Fail()//Test password of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "dgds!54654SDGSG@";
            bool result = obj.matchPassword(fName);
            Assert.AreEqual(true, result);
        }
    }
}
