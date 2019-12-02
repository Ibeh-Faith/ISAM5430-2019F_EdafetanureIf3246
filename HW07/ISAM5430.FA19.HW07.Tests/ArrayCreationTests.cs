using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Tests
{
    public class ArrayCreationTests
    {
        private dynamic _object;

        public ArrayCreationTests()
        {
            _object = new ArrayCreation();
        }

        [Fact]
        [Trait("Category", "Easy")]
        public void FizzArray()
        {

            Int32[] expected, actual;

            expected = new[] { 0, 1, 2, 3 };
            actual = _object.FizzArray(4);
            Assert.Equal(expected, actual);

            expected = new[] { 0 };
            actual = _object.FizzArray(1);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            actual = _object.FizzArray(10);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.FizzArray(0);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 1 };
            actual = _object.FizzArray(2);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 1, 2, 3, 4, 5, 6 };
            actual = _object.FizzArray(7);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void FizzArray2()
        {

            String[] expected, actual;

            expected = new[] { "0", "1", "2", "3" };
            actual = _object.FizzArray2(4);
            Assert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            actual = _object.FizzArray2(10);
            Assert.Equal(expected, actual);

            expected = new[] { "0", "1" };
            actual = _object.FizzArray2(2);
            Assert.Equal(expected, actual);

            expected = new[] { "0" };
            actual = _object.FizzArray2(1);
            Assert.Equal(expected, actual);

            expected = new string[0];
            actual = _object.FizzArray2(0);
            Assert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6" };
            actual = _object.FizzArray2(7);
            Assert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            actual = _object.FizzArray2(9);
            Assert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            actual = _object.FizzArray2(11);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void FizzArray3()
        {

            Int32[] expected, actual;

            expected = new[] { 5, 6, 7, 8, 9 };
            actual = _object.FizzArray3(5, 10);
            Assert.Equal(expected, actual);

            expected = new[] { 11, 12, 13, 14, 15, 16, 17 };
            actual = _object.FizzArray3(11, 18);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 2 };
            actual = _object.FizzArray3(1, 3);
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.FizzArray3(1, 2);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.FizzArray3(1, 1);
            Assert.Equal(expected, actual);

            expected = new[] { 1000, 1001, 1002, 1003, 1004 };
            actual = _object.FizzArray3(1000, 1005);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void SquareUp()
        {

            Int32[] expected, actual;

            expected = new[] { 0, 0, 1, 0, 2, 1, 3, 2, 1 };
            actual = _object.SquareUp(3);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 1, 2, 1 };
            actual = _object.SquareUp(2);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1 };
            actual = _object.SquareUp(4);
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.SquareUp(1);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.SquareUp(0);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 2, 1, 0, 0, 0, 3, 2, 1, 0, 0, 4, 3, 2, 1, 0, 5, 4, 3, 2, 1, 6, 5, 4, 3, 2, 1 };
            actual = _object.SquareUp(6);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void SeriesUp()
        {

            Int32[] expected, actual;

            expected = new[] { 1, 1, 2, 1, 2, 3 };
            actual = _object.SeriesUp(3);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 1, 2, 1, 2, 3, 1, 2, 3, 4 };
            actual = _object.SeriesUp(4);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 1, 2 };
            actual = _object.SeriesUp(2);
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.SeriesUp(1);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.SeriesUp(0);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6 };
            actual = _object.SeriesUp(6);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void Subarray()
        {
            int[] a = SampleArray();
            int[] actual, expected;
            expected = null;
            actual = _object.Subarray(null, 0, 0);
            Assert.Equal(expected, actual);

            expected = new[] { 2 };
            actual = _object.Subarray(a, 0, 0);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16 };
            actual = _object.Subarray(a, 0, 1);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1 };
            actual = _object.Subarray(a, 0, 2);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14 };
            actual = _object.Subarray(a, 0, 3);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11 };
            actual = _object.Subarray(a, 0, 5);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8 };
            actual = _object.Subarray(a, 0, 8);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4 };
            actual = _object.Subarray(a, 0, 13);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            actual = _object.Subarray(a, 0, 21);
            Assert.Equal(expected, actual);

            expected = new[] { 8 };
            actual = _object.Subarray(a, 4, 4);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11 };
            actual = _object.Subarray(a, 4, 5);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11, 11 };
            actual = _object.Subarray(a, 4, 6);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6 };
            actual = _object.Subarray(a, 4, 7);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6, 8, 17 };
            actual = _object.Subarray(a, 4, 9);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0 };
            actual = _object.Subarray(a, 4, 12);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9 };
            actual = _object.Subarray(a, 4, 17);
            Assert.Equal(expected, actual);

            expected = new[] { 8 };
            actual = _object.Subarray(a, 8, 8);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17 };
            actual = _object.Subarray(a, 8, 9);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17, 14 };
            actual = _object.Subarray(a, 8, 10);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9 };
            actual = _object.Subarray(a, 8, 11);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9, 0, 4 };
            actual = _object.Subarray(a, 8, 13);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1 };
            actual = _object.Subarray(a, 8, 16);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            actual = _object.Subarray(a, 8, 21);
            Assert.Equal(expected, actual);

            expected = new[] { 0 };
            actual = _object.Subarray(a, 12, 12);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 4 };
            actual = _object.Subarray(a, 12, 13);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 4, 19 };
            actual = _object.Subarray(a, 12, 14);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 4, 19, 13 };
            actual = _object.Subarray(a, 12, 15);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 4, 19, 13, 1, 9 };
            actual = _object.Subarray(a, 12, 17);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 4, 19, 13, 1, 9, 7, 17, 20 };
            actual = _object.Subarray(a, 12, 20);
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.Subarray(a, 16, 16);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 9 };
            actual = _object.Subarray(a, 16, 17);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 9, 7 };
            actual = _object.Subarray(a, 16, 18);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 9, 7, 17 };
            actual = _object.Subarray(a, 16, 19);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 9, 7, 17, 20, 3 };
            actual = _object.Subarray(a, 16, 21);
            Assert.Equal(expected, actual);

            expected = new[] { 20 };
            actual = _object.Subarray(a, 20, 20);
            Assert.Equal(expected, actual);

            expected = new[] { 20, 3 };
            actual = _object.Subarray(a, 20, 21);
            Assert.Equal(expected, actual);

            expected = new[] { 3 };
            actual = _object.Subarray(a, 21, 21);
            Assert.Equal(expected, actual);




            //var sb = new StringBuilder();


            //for (int i = 0; i <= 24; i += 4)
            //{
            //    int p = 0, q = 1;
            //    if (i == 24) i = 21;
            //    for (int j = i; j < a.Length; j = i + q)
            //    {
            //        q = p + q;
            //        p = q - p;
            //        sb.AppendLine($"expected = new [] {_object.Subarray(a, i, j).ToCode()};");
            //        sb.AppendLine($"actual = _object.Subarray(a, {i}, {j});");
            //        sb.AppendLine("Assert.Equal(expected, actual);");
            //        sb.AppendLine();
            //    }
            //}
            //Assert.Fail(sb.ToString());

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void Copyarray()
        {

            int[] actual, expected, a;

            expected = null;
            actual = _object.Copyarray(null);
            Assert.Equal(expected, actual);

            expected = new[] { 20 };
            a = new[] { 20 };
            actual = _object.Copyarray(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            Assert.Equal(expected, actual);

            expected = new[] { 1, 2 };
            a = new[] { 1, 2 };
            actual = _object.Copyarray(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            Assert.Equal(expected, actual);

            expected = new[] { -13, 34, 55 };
            a = new[] { -13, 34, 55 };
            actual = _object.Copyarray(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            a = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            actual = _object.Copyarray(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            Assert.Equal(expected, actual);

        }

        private int[] SampleArray()
        {
            return new int[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
        }
    }
}
