﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Tests.ValueObjects
{
    [TestClass]
    public class CampaignTests
    {

        [TestMethod]
        [DataRow("", "", "", true)]
        [DataRow("src", "", "", true)]
        [DataRow("src", "med", "", true)]
        [DataRow("src", "med", "name", false)]
        public void TestCampaign(
            string source,
            string medium,
            string name,
            bool expectException)
        {
            if (expectException)
            {
                try
                {
                    new Campaign(source, medium, name);
                    Assert.Fail();
                }
                catch (InvalidCampaingException)
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                new Campaign(source, medium, name);
                Assert.IsTrue(true);
            }
        }
    }
}