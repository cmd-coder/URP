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
            try
            {
                bool checkFName = obj.matchFName(fName);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual("Invalid First Name", ce.Message);
            }
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
            try
            {
                bool checkLName = obj.matchLName(fName);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual("Invalid Last Name", ce.Message);
            }
        }

        [TestMethod]
        public void TestMethodEmail_Pass()//Test mobile email id of the user
        {
            patternMatch obj = new patternMatch();
            string email = "abc@cd.com";
            bool result = obj.matchEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodEmail_Fail()//Test mobile email id of the user
        {
            patternMatch obj = new patternMatch();
            string email = "abc@cd.com.in.as";
            try
            {
                bool checkEmail = obj.matchEmail(email);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual("Invalid Email", ce.Message);
            }
        }

        [TestMethod]
        public void TestMethodMobile_Pass()//Test mobile phone number of the user
        {
            patternMatch obj = new patternMatch();
            string mobile = "91 7894561230";
            bool result = obj.matchMobile(mobile);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodMobile_Fail()//Test mobile phone number of the user
        {
            patternMatch obj = new patternMatch();
            string mobile = "91 0894561230";
            try
            {
                bool checkMobile = obj.matchMobile(mobile);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual("Invalid Mobile Number", ce.Message);
            }
        }

        [TestMethod]
        public void TestMethodPassword_Pass()//Test password of the user
        {
            patternMatch obj = new patternMatch();
            string password = "dgds!54654SDGSG";
            bool result = obj.matchPassword(password);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodPassword_Fail()//Test password of the user
        {
            patternMatch obj = new patternMatch();
            string password = "dgds!54654SDGSG@";
            try
            {
                bool checkPassword = obj.matchPassword(password);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual("Invalid Password", ce.Message);
            }
        }
    }
}
