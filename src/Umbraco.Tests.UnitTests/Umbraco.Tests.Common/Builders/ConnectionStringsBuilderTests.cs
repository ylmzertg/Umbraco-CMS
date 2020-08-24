﻿using NUnit.Framework;
using Umbraco.Tests.Common.Builders;

namespace Umbraco.Tests.UnitTests.Umbraco.Tests.Common.Builders
{
    [TestFixture]
    public class ConnectionStringsBuilderTests
    {
        [Test]
        public void Is_Built_Correctly()
        {
            // Arrange
            const string umbracoConnectionString = "connection string";

            var builder = new ConnectionStringsBuilder();

            // Act
            var connectionStrings = builder
                .WithUmbracoConnectionString(umbracoConnectionString)
                .Build();

            // Assert
            Assert.AreEqual(umbracoConnectionString, connectionStrings.UmbracoConnectionString);
        }
    }
}
