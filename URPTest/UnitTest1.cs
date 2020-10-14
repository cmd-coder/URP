using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using URP;

namespace URPTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void matchFName_FirstName_ReturnsTrue()//Test first name of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "Firstname";
            bool result = obj.matchFName(fName);
            Assert.AreEqual(true, result);
            
        }

        [TestMethod]
        public void matchFName_FirstName_ThrowsCustomException()//Test first name of the user
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
        public void matchLName_LastName_ReturnsTrue()//Test last name of the user
        {
            patternMatch obj = new patternMatch();
            string fName = "Lastname";
            bool result = obj.matchLName(fName);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void matchLName_LastName_ThrowsCustomException()//Test last name of the user
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
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc+100@gmail.com")]
        [DataRow("abc@gmail.com.com")]
        public void matchEmail_Email_ReturnsTrue(string email)//Test mobile email id of the user
        {
            patternMatch obj = new patternMatch();
            //string email = "abc@cd.com";
            bool result = obj.matchEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc@gmail.com.aa.au")]
        [DataRow("abc..2002@gmail.com")]
        public void matchEmail_Email_ThrowsCustomException(string email)//Test email id of the user
        {
            patternMatch obj = new patternMatch();
            //string email = "abc@cd.com.in.as";
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
        public void matchMobile_Mobile_ReturnsTrue()//Test mobile phone number of the user
        {
            patternMatch obj = new patternMatch();
            string mobile = "91 7894561230";
            bool result = obj.matchMobile(mobile);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void matchMobile_Mobile_ThrowsCustomException()//Test mobile phone number of the user
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
        public void matchPassword_Password_ReturnsTrue()//Test password of the user
        {
            patternMatch obj = new patternMatch();
            string password = "dgds!54654SDGSG";
            bool result = obj.matchPassword(password);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void matchPassword_Password_ThrowsCustomException()//Test password of the user
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
