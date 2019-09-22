using System;
using Xunit;

namespace AppVeyorTest.Tests
{
    public class LogicTests
    {
        [Fact]
        public void Should_Add()
        {
            Assert.Equal(2, new Logic().Add(1, 1));
        }
    }
}
