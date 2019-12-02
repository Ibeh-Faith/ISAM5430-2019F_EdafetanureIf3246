using System;
using System.Collections.Generic;
using Xunit;

namespace ISAM5430.FA19.HW08.Tests
{
    public class CollectionAssertTests
    {
        //[Fact]
        public void AreEquivalent()
        {
            var expected = new Dictionary<string, string> { { "a", "aaa" }, { "b", "aaa" } };
            var actual = new Dictionary<string, string> { { "b", "aaa" }, { "a", "aaa" } };
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
