﻿using LinqToTwitter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToTwitterPcl.Tests.LinqToTwitterTests
{
    [TestClass]
    public class TwitterErrorHandlerTests
    {
        [TestMethod]
        public void ParseTwitterErrorMessage_Handles_String_Types()
        {
            string stringError = "{\"errors\":\"sharing is not permissible for this status (Share validations failed)\"}";

            TwitterErrorHandler.TwitterErrorDetails details = 
                TwitterErrorHandler.ParseTwitterErrorMessage(stringError);

            Assert.IsNotNull(details);
            Assert.AreEqual(
                "sharing is not permissible for this status (Share validations failed)",
                details.Message);
        }
    }
}