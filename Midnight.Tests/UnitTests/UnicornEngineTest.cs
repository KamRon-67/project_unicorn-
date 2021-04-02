﻿using Midnight.Core.Extensions;
using Xunit;
using FluentAssertions;
using Midnight.Core.Extensions.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Midnight.Core.Extensions.Interfaces;
using System;
using Moq;

namespace Midnight.Tests.UnitTests
{
    public class UnicornEngineTest
    {
        [Fact]
        public void UnicornEngineThrowException()
        {
            //Arrange
            Action testUnicornEngine = () => { _ = new UnicornEngine(null, null, null); };

            //Act
            var ex = Record.Exception(testUnicornEngine);
            Assert.NotNull(ex);

            // Assert
            Assert.IsType<ArgumentException>(ex);
        }
    }
}
