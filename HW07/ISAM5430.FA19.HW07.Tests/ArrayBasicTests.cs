using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Tests
{
    public class ArrayBasicTests
    {
        private dynamic _object;
        public ArrayBasicTests()
        {
            _object = new ArrayBasic();
        }
        [Fact]
        [Trait("Category", "Easy")]
        public void FirstElement()
        {
            Int32 expected, actual;

            expected = 2;
            actual = _object.FirstElement(new[] { 2, 3, 1 });
            Assert.Equal(expected, actual);

            expected = 5;
            actual = _object.FirstElement(new[] { 5, 3, 1, 7, 9, 10 });
            Assert.Equal(expected, actual);

            expected = 10;
            actual = _object.FirstElement(new[] { 10 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.FirstElement(new int[0]);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.FirstElement(null);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void LastElement()
        {

            Int32 expected, actual;

            expected = 1;
            actual = _object.LastElement(new[] { 2, 3, 1 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.LastElement(new[] { 5, 3, 1, 7, 9, 0 });
            Assert.Equal(expected, actual);

            expected = 10;
            actual = _object.LastElement(new[] { 10 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.LastElement(new int[0]);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.LastElement(null);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void MiddleElement()
        {

            Int32 expected, actual;

            expected = 1;
            actual = _object.MiddleElement(new[] { 2, 3, 1, 6, 5 });
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.MiddleElement(new[] { 2, 3, 1, 4, 6, 5 });
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.MiddleElement(new[] { 2, 3, 1, 5, 4, 6 });
            Assert.Equal(expected, actual);

            expected = 7;
            actual = _object.MiddleElement(new[] { 7 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.MiddleElement(new int[0]);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.MiddleElement(null);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void FirstLast6()
        {

            Boolean expected, actual;

            expected = false;
            actual = _object.FirstLast6(null);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.FirstLast6(new int[0]);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.FirstLast6(new[] { 1, 2, 6 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.FirstLast6(new[] { 6, 1, 2, 3 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.FirstLast6(new[] { 13, 6, 1, 2, 3 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.FirstLast6(new[] { 13, 6, 1, 2, 6 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.FirstLast6(new[] { 3, 2, 1 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.FirstLast6(new[] { 3, 6, 1 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.FirstLast6(new[] { 3, 6 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.FirstLast6(new[] { 6 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.FirstLast6(new[] { 3 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.FirstLast6(new[] { 5, 6 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.FirstLast6(new[] { 5, 5 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.FirstLast6(new[] { 1, 2, 3, 4, 6 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.FirstLast6(new[] { 1, 2, 3, 4 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void CommonEnd()
        {

            Boolean expected, actual;

            expected = true;
            actual = _object.CommonEnd(new[] { 1, 2, 3 }, new[] { 7, 3 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.CommonEnd(new[] { 1, 2, 3 }, new[] { 7, 3, 2 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.CommonEnd(new[] { 1, 2, 3 }, new[] { 1, 3 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.CommonEnd(new[] { 1, 2, 3 }, new[] { 1 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.CommonEnd(new[] { 1, 2, 3 }, new[] { 2 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.CommonEnd(new int[0], null);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.CommonEnd(new int[0], new int[0]);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.CommonEnd(new int[0], new[] { 0 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void MiddleWay()
        {

            Int32[] expected, actual;

            expected = new[] { 2, 5 };
            actual = _object.MiddleWay(new[] { 1, 2, 3 }, new[] { 4, 5, 6 });
            Assert.Equal(expected, actual);

            expected = new[] { 7, 8 };
            actual = _object.MiddleWay(new[] { 7, 7, 7 }, new[] { 3, 8, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 2, 4 };
            actual = _object.MiddleWay(new[] { 5, 2, 9 }, new[] { 1, 4, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 9, 8 };
            actual = _object.MiddleWay(new[] { 1, 9, 7 }, new[] { 4, 8, 8 });
            Assert.Equal(expected, actual);

            expected = new[] { 2, 1 };
            actual = _object.MiddleWay(new[] { 1, 2, 3 }, new[] { 3, 1, 4 });
            Assert.Equal(expected, actual);

            expected = new[] { 2, 1 };
            actual = _object.MiddleWay(new[] { 1, 2, 3 }, new[] { 4, 1, 1 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void No23()
        {

            Boolean expected, actual;
            expected = true;
            actual = _object.No23(new[] { 4, 5 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.No23(new[] { 4, 2 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.No23(new[] { 3, 5 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.No23(new[] { 1, 9 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.No23(new[] { 2, 9 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.No23(new[] { 1, 3 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.No23(new[] { 1, 1 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.No23(new[] { 2, 2 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.No23(new[] { 3, 3 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.No23(new[] { 7, 8 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.No23(new[] { 8, 7 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void Fix23()
        {

            Int32[] expected, actual;

            expected = new[] { 1, 2, 0 };
            actual = _object.Fix23(new[] { 1, 2, 3 });
            Assert.Equal(expected, actual);

            expected = new[] { 2, 0, 5 };
            actual = _object.Fix23(new[] { 2, 3, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 1, 2, 1 };
            actual = _object.Fix23(new[] { 1, 2, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 3, 2, 1 };
            actual = _object.Fix23(new[] { 3, 2, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 2, 2, 0 };
            actual = _object.Fix23(new[] { 2, 2, 3 });
            Assert.Equal(expected, actual);

            expected = new[] { 2, 0, 3 };
            actual = _object.Fix23(new[] { 2, 3, 3 });
            Assert.Equal(expected, actual);

        }


        [Fact]
        [Trait("Category", "Easy")]
        public void SumEqual()
        {

            int[] array;
            bool actual;
            int index;

            array = new int[0];
            index = 0;
            actual = _object.SumEqual(array, index);
            Assert.False(actual);

            array = null;
            index = 0;
            actual = _object.SumEqual(array, index);
            Assert.False(actual);

            array = new[] { -3, 1, 3, -1, 1, 5, 4 };
            index = -1;
            actual = _object.SumEqual(array, index);
            Assert.False(actual);

            index = 0;
            actual = _object.SumEqual(array, index);
            Assert.False(actual);

            index = 1;
            actual = _object.SumEqual(array, index);
            Assert.True(actual);

            index = 2;
            actual = _object.SumEqual(array, index);
            Assert.False(actual);

            index = 3;
            actual = _object.SumEqual(array, index);
            Assert.False(actual);

            index = 4;
            actual = _object.SumEqual(array, index);
            Assert.True(actual);

            index = 5;
            actual = _object.SumEqual(array, index);
            Assert.False(actual);

            index = 6;
            actual = _object.SumEqual(array, index);
            Assert.False(actual);

            index = 7;
            actual = _object.SumEqual(array, index);
            Assert.False(actual);

        }
    }
}
