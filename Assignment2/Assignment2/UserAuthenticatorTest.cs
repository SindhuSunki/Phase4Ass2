using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    [TestFixture]
    public class UserAuthenticatorTest
    {
        public UserAuthenticator authenticator;

        [SetUp]
        public void Setup()
        {
            authenticator = new UserAuthenticator();
        }

        [Test]
        public void TestUserRegistration()
        {
            Assert.IsTrue(authenticator.RegisterUser("user", "pwd"));
            Assert.IsFalse(authenticator.RegisterUser("user", "pwd1")); // User already registered
        }

        [Test]
        public void TestUserLogin()
        {
            authenticator.RegisterUser("user2", "pwd2");

            Assert.IsTrue(authenticator.LoginUser("user2", "pwd2"));
            Assert.IsFalse(authenticator.LoginUser("user2", "wrongpwd")); // Invalid password
            Assert.IsFalse(authenticator.LoginUser("nonexistentuser", "pwd")); // User does not exist
        }

        [Test]
        public void TestPasswordReset()
        {
            authenticator.RegisterUser("user3", "pwd3");

            Assert.IsTrue(authenticator.ResetuserPwd("user3", "newpwd"));
            Assert.IsFalse(authenticator.ResetuserPwd("nonexistentuser", "newpwd")); // User does not exist
        }
    }
}