﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            // Prepare
            app.Auth.Logout();

            // Action
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);

            // Verification
            Assert.IsTrue(app.Auth.IsLoggedIn());
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            // Prepare
            app.Auth.Logout();

            // Action
            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);

            // Verification
            Assert.IsFalse(app.Auth.IsLoggedIn());
        }
    }
}
