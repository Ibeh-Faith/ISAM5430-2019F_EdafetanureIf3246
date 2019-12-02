using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Assignments.Tests.Library;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;

namespace CSharp.Assignments.Tests
{
    public class ArrayTrackingTests
    {
        private dynamic _object;
        public ArrayTrackingTests()
        {
            _object = new ArrayTracking();
        }

        [Fact]
        [Trait("Category", "Medium")]
        public void MaxValue()
        {

            Int32 expected, actual;

            expected = 0;
            actual = _object.MaxValue(null);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.MaxValue(new int[0]);
            Assert.Equal(expected, actual);

            expected = 5;
            actual = _object.MaxValue(new[] { 1, 4, 5, 2, 2 });
            Assert.Equal(expected, actual);

            expected = 7;
            actual = _object.MaxValue(new[] { 6, 4, 7, 4, 2, 7, 2 });
            Assert.Equal(expected, actual);

            expected = 6;
            actual = _object.MaxValue(new[] { 6 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void MinValue()
        {

            Int32 expected, actual;

            expected = 0;
            actual = _object.MinValue(null);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.MinValue(new int[0]);
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.MinValue(new[] { 1, 4, 5, 2, 2 });
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.MinValue(new[] { 6, 4, 7, 4, 2, 7, 2 });
            Assert.Equal(expected, actual);

            expected = 6;
            actual = _object.MinValue(new[] { 6 });
            Assert.Equal(expected, actual);

        }
       
        [Fact]
        [Trait("Category", "Medium")]
        public void NeedleInHaystack()
        {

            Int32 expected, actual;

            expected = -1;
            actual = _object.NeedleInHaystack(null, 0);
            Assert.Equal(expected, actual);

            expected = -1;
            actual = _object.NeedleInHaystack(new int[0], 2);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }, 4);
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }, 2);
            Assert.Equal(expected, actual);

            expected = 6;
            actual = _object.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }, 1);
            Assert.Equal(expected, actual);

            expected = -1;
            actual = _object.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }, 6);
            Assert.Equal(expected, actual);

            expected = -1;
            actual = _object.NeedleInHaystack(new[] { 6 }, 7);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.NeedleInHaystack(new[] { 6 }, 6);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void ClosestItem()
        {

            Int32 expected, actual;

            expected = 0;
            actual = _object.ClosestItem(null, 0);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.ClosestItem(new int[0], 2);
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.ClosestItem(new[] { 4, 5, 2, 8, 3, 7, 1 }, 3);
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.ClosestItem(new[] { 4, 5, 2, 8, 3, 7, 1 }, 1);
            Assert.Equal(expected, actual);

            expected = 8;
            actual = _object.ClosestItem(new[] { 4, 5, 2, 8, 3, 7, 1 }, 9);
            Assert.Equal(expected, actual);

            expected = 5;
            actual = _object.ClosestItem(new[] { 4, 5, 2, 9, 3, 8, 1 }, 6);
            Assert.Equal(expected, actual);

            expected = 6;
            actual = _object.ClosestItem(new[] { 6 }, 6);
            Assert.Equal(expected, actual);

            expected = 6;
            actual = _object.ClosestItem(new[] { 6 }, -100);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void FarthestItem()
        {

            Int32 expected, actual;

            expected = 0;
            actual = _object.FarthestItem(null, 0);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.FarthestItem(new int[0], 2);
            Assert.Equal(expected, actual);

            expected = 7;
            actual = _object.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }, 2);
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }, 5);
            Assert.Equal(expected, actual);

            expected = 7;
            actual = _object.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }, -5);
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }, 10);
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.FarthestItem(new[] { 3 }, 100);
            Assert.Equal(expected, actual);


        }
        
        [Fact]
        [Trait("Category", "Medium")]
        public void HirschIndex()
        {

            Int32 expected, actual;

            expected = -1;
            actual = _object.HirschIndex(null);
            Assert.Equal(expected, actual);

            expected = -1;
            actual = _object.HirschIndex(new int[0]);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.HirschIndex(new[] { 0, 0, 0, 0 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.HirschIndex(new[] { 12, 312, 33, 12 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.HirschIndex(new[] { 1, 2, 3, 4, 5, 6, 7 });
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.HirschIndex(new[] { 22, 33, 1, 2, 4 });
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.HirschIndex(new[] { 1000, 2, 2, 2 });
            Assert.Equal(expected, actual);

            expected = 20;
            actual = _object.HirschIndex(new[] { 23, 42, 12, 92, 39, 46, 23, 56, 31, 12, 43, 23, 54, 23, 56, 73, 35, 73, 42, 12, 10, 15, 35, 23, 12, 42 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void BigDiff()
        {
            Int32 expected, actual;

            expected = 7;
            actual = _object.BigDiff(new[] { 10, 3, 5, 6 });
            Assert.Equal(expected, actual);

            expected = 8;
            actual = _object.BigDiff(new[] { 7, 2, 10, 9 });
            Assert.Equal(expected, actual);

            expected = 8;
            actual = _object.BigDiff(new[] { 2, 10, 7, 2 });
            Assert.Equal(expected, actual);

            expected = 8;
            actual = _object.BigDiff(new[] { 2, 10 });
            Assert.Equal(expected, actual);

            expected = 8;
            actual = _object.BigDiff(new[] { 10, 2 });
            Assert.Equal(expected, actual);

            expected = 10;
            actual = _object.BigDiff(new[] { 10, 0 });
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.BigDiff(new[] { 2, 3 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.BigDiff(new[] { 2, 2 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.BigDiff(new[] { 2 });
            Assert.Equal(expected, actual);

            expected = 8;
            actual = _object.BigDiff(new[] { 5, 1, 6, 1, 9, 9 });
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.BigDiff(new[] { 7, 6, 8, 5 });
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.BigDiff(new[] { 7, 7, 6, 8, 5, 5, 6 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.BigDiff(new int[0]);
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.BigDiff(null);
            Assert.Equal(expected, actual);

        }
        

        [Fact]
        [Trait("Category", "Medium")]
        public void SameEnds()
        {

            Boolean expected, actual;

            expected = false;
            actual = _object.SameEnds(new[] { 5, 6, 45, 99, 13, 5, 6 }, 1);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.SameEnds(new[] { 5, 6, 45, 99, 13, 5, 6 }, 2);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.SameEnds(new[] { 5, 6, 45, 99, 13, 5, 6 }, 3);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.SameEnds(new[] { 1, 2, 5, 2, 1 }, 1);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.SameEnds(new[] { 1, 2, 5, 2, 1 }, 2);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.SameEnds(new[] { 1, 2, 5, 2, 1 }, 0);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.SameEnds(new[] { 1, 2, 5, 2, 1 }, 5);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.SameEnds(new[] { 1, 1, 1 }, 0);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.SameEnds(new[] { 1, 1, 1 }, 1);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.SameEnds(new[] { 1, 1, 1 }, 2);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.SameEnds(new[] { 1, 1, 1 }, 3);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.SameEnds(new[] { 1 }, 1);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.SameEnds(new int[0], 0);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.SameEnds(new[] { 4, 2, 4, 5 }, 1);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void IsEverywhere()
        {

            Boolean expected, actual;

            expected = true;
            actual = _object.IsEverywhere(new[] { 1, 2, 1, 3 }, 1);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 1, 2, 1, 3 }, 2);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 1, 2, 1, 3, 4 }, 1);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 1 }, 1);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 1 }, 2);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 3, 1 }, 2);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 3, 1 }, 3);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 3, 1 }, 2);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 3 }, 1);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new int[0], 1);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 1, 2, 1, 2, 3, 2, 5 }, 2);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 1, 2, 1, 1, 1, 2 }, 2);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 1, 1, 2 }, 2);
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 2, 2, 1, 1, 2 }, 2);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 2, 2, 1, 2, 1 }, 2);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 1, 2 }, 2);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void RepeatedTimes()
        {   

            Int32[] expected, actual;

            expected = new int[0];
            actual = _object.RepeatedTimes(null);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.RepeatedTimes(new int[0]);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.RepeatedTimes(new[] { 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.RepeatedTimes(new[] { 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 2 };
            actual = _object.RepeatedTimes(new[] { 2, 1, 2, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 2, 3 };
            actual = _object.RepeatedTimes(new[] { 1, 5, 2, 5, 3, 3, 2, 1, 3, 5, 4, 5 });
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.RepeatedTimes(new[] { 1, 2, 5, 3, 3, 2, 1, 3, 5, 4, 5, 2, 3 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void CenteredAverage()
        {

            Int32 expected, actual;

            expected = 3;
            actual = _object.CenteredAverage(new[] { 1, 2, 3, 4, 100 });
            Assert.Equal(expected, actual);

            expected = 5;
            actual = _object.CenteredAverage(new[] { 1, 1, 5, 5, 10, 8, 7 });
            Assert.Equal(expected, actual);

            expected = -3;
            actual = _object.CenteredAverage(new[] { -10, -4, -2, -4, -2, 0 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 5, 3, 4, 6, 2 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 5, 3, 4, 0, 100 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 100, 0, 5, 3, 4 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 4, 0, 100 });
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.CenteredAverage(new[] { 0, 2, 3, 4, 100 });
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.CenteredAverage(new[] { 1, 1, 100 });
            Assert.Equal(expected, actual);

            expected = 7;
            actual = _object.CenteredAverage(new[] { 7, 7, 7 });
            Assert.Equal(expected, actual);

            expected = 7;
            actual = _object.CenteredAverage(new[] { 1, 7, 8 });
            Assert.Equal(expected, actual);

            expected = 50;
            actual = _object.CenteredAverage(new[] { 1, 1, 99, 99 });
            Assert.Equal(expected, actual);

            expected = 50;
            actual = _object.CenteredAverage(new[] { 1000, 0, 1, 99 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 4, 4, 4, 4, 5 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 4, 4, 4, 1, 5 });
            Assert.Equal(expected, actual);

            expected = 6;
            actual = _object.CenteredAverage(new[] { 6, 4, 8, 12, 3 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void AloneEvenAverage()
        {

            double actual, expected;

            expected = 0;
            actual = _object.AloneEvenAverage(new int[0]);
            Assert.Equal(expected, actual, 3);

            expected = 0;
            actual = _object.AloneEvenAverage(null);
            Assert.Equal(expected, actual, 3);

            expected = 0;
            actual = _object.AloneEvenAverage(new[] { 1, 3, 5, 7 });
            Assert.Equal(expected, actual, 3);

            expected = 0;
            actual = _object.AloneEvenAverage(new[] { 2, 4 });
            Assert.Equal(expected, actual, 3);

            expected = 2;
            actual = _object.AloneEvenAverage(new[] { 2 });
            Assert.Equal(expected, actual, 3);

            expected = 2;
            actual = _object.AloneEvenAverage(new[] { 2, 1 });
            Assert.Equal(expected, actual, 3);

            expected = 2;
            actual = _object.AloneEvenAverage(new[] { 3, 2, 1 });
            Assert.Equal(expected, actual, 3);

            expected = 6.4;
            actual = _object.AloneEvenAverage(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 });
            Assert.Equal(expected, actual, 3);


            expected = 3;
            actual = _object.AloneEvenAverage(new[] { 1, 2, 4, 3, 4, 8, 0, 5, 6, 7, 8, 6, -2, 9, 0 });
            Assert.Equal(expected, actual, 3);

            expected = 0.8;
            actual = _object.AloneEvenAverage(new[] { 2, -1, 4, 3, 4, -8, 0, 5, 6, 7, -8, 9, 0, 1 });
            Assert.Equal(expected, actual, 3);

            expected = -1.6;
            actual = _object.AloneEvenAverage(new[] { -2, -1, -4, 3, 4, -8, 0, 5, 6, 7, -8, 9, 0, 1 });
            Assert.Equal(expected, actual, 3);

            expected = -2.4;
            actual = _object.AloneEvenAverage(new[] { -6, -1, -4, 3, 4, -2, 0, 5, 6, 7, -8, 9, 0, 1 });
            Assert.Equal(expected, actual, 3);

            expected = 0;
            actual = _object.AloneEvenAverage(new[] { 0, 1, 2, 4, 3, 4, -8, 0, 5, 6, 7, -8, 9, 0, 1, -2, -3, 4 });
            Assert.Equal(expected, actual, 3);

        }

        [Fact]
        [Trait("Category", "Hard")]
        public void MaxSpan()
        {

            Int32 expected, actual;

            expected = 4;
            actual = _object.MaxSpan(new[] { 1, 2, 1, 1, 3 });
            Assert.Equal(expected, actual);

            expected = 6;
            actual = _object.MaxSpan(new[] { 1, 4, 2, 1, 4, 1, 4 });
            Assert.Equal(expected, actual);

            expected = 6;
            actual = _object.MaxSpan(new[] { 1, 4, 2, 1, 4, 4, 4 });
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.MaxSpan(new[] { 3, 3, 3 });
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.MaxSpan(new[] { 3, 9, 3 });
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.MaxSpan(new[] { 3, 9, 9 });
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.MaxSpan(new[] { 3, 9 });
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.MaxSpan(new[] { 3, 3 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.MaxSpan(new int[0]);
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.MaxSpan(new[] { 1 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Hard")]
        public void CanBalance()
        {

            Boolean expected, actual;

            expected = true;
            actual = _object.CanBalance(new[] { 1, 1, 1, 2, 1 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.CanBalance(new[] { 2, 1, 1, 2, 1 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.CanBalance(new[] { 10, 10 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.CanBalance(new[] { 10, 0, 1, -1, 10 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.CanBalance(new[] { 1, 1, 1, 1, 4 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.CanBalance(new[] { 2, 1, 1, 1, 4 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.CanBalance(new[] { 2, 3, 4, 1, 2 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.CanBalance(new[] { 1, 2, 3, 1, 0, 2, 3 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.CanBalance(new[] { 1, 2, 3, 1, 0, 1, 3 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.CanBalance(new[] { 1 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.CanBalance(new[] { 1, 1, 1, 2, 1 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Hard")]
        public void LinearIn()
        {

            Boolean expected, actual;

            expected = true;
            actual = _object.LinearIn(new[] { 1, 2, 4, 6 }, new[] { 2, 4 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.LinearIn(new[] { 1, 2, 4, 6 }, new[] { 2, 3, 4 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.LinearIn(new[] { 1, 2, 4, 4, 6 }, new[] { 2, 4 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.LinearIn(new[] { 2, 2, 4, 4, 6, 6 }, new[] { 2, 4 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.LinearIn(new[] { 2, 2, 2, 2, 2 }, new[] { 2, 2 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.LinearIn(new[] { 2, 2, 2, 2, 2 }, new[] { 2, 4 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.LinearIn(new[] { 2, 2, 2, 2, 4 }, new[] { 2, 4 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.LinearIn(new[] { 1, 2, 3 }, new[] { 2 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.LinearIn(new[] { 1, 2, 3 }, new[] { -1 });
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.LinearIn(new[] { 1, 2, 3 }, new int[0]);
            Assert.Equal(expected, actual);

            expected = true;
            actual = _object.LinearIn(new[] { -1, 0, 3, 3, 3, 10, 12 }, new[] { -1, 0, 3, 12 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.LinearIn(new[] { -1, 0, 3, 3, 3, 10, 12 }, new[] { 0, 3, 12, 14 });
            Assert.Equal(expected, actual);

            expected = false;
            actual = _object.LinearIn(new[] { -1, 0, 3, 3, 3, 10, 12 }, new[] { -1, 10, 11 });
            Assert.Equal(expected, actual);
        }

        [Fact]
        [Trait("Category", "Hard")]
        public void ZeroFront()
        {

            Int32[] expected, actual;

            expected = null;
            actual = _object.ZeroFront(null);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.ZeroFront(new int[0]);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 1, 1, 1 };
            actual = _object.ZeroFront(new[] { 0, 1, 0, 0, 1, 0, 1, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            actual = _object.ZeroFront(new[] { 0, 2, 2, 2, 2, 2, 2, 0, 2, 2, 2, 2, 2, 2, 2 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
            actual = _object.ZeroFront(new[] { 0, 3, 0, 0, 3, 0, 3, 0, 3, 3, 3, 3, 0, 3, 3, 3 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 4, 4, 4, 4, 4, 4, 4 };
            actual = _object.ZeroFront(new[] { 4, 0, 4, 0, 0, 4, 0, 4, 4, 4, 4 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5 };
            actual = _object.ZeroFront(new[] { 5, 0, 0, 0, 5, 5, 5, 0, 0, 5, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6 };
            actual = _object.ZeroFront(new[] { 0, 0, 6, 0, 0, 6, 0, 0, 6, 6, 6, 0, 6, 6, 0, 6 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 7, 7, 7, 7 };
            actual = _object.ZeroFront(new[] { 0, 0, 0, 7, 7, 0, 0, 7, 0, 0, 0, 7, 0, 0, 7, 7, 7, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 8, 8, 8, 8, 8 };
            actual = _object.ZeroFront(new[] { 8, 8, 0, 8, 8, 8, 0, 0, 0, 0, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9 };
            actual = _object.ZeroFront(new[] { 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            actual = _object.ZeroFront(new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, 0, -1, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2 };
            actual = _object.ZeroFront(new[] { -2, -2, -2, 0, 0, -2, -2, 0, -2, -2, -2, 0, -2, -2 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, -3, -3, -3, -3, -3, -3, -3, -3 };
            actual = _object.ZeroFront(new[] { -3, 0, 0, -3, -3, -3, -3, -3, 0, -3, -3 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 0, 0, -4, -4, -4, -4, -4, -4, -4, -4, -4, -4, -4 };
            actual = _object.ZeroFront(new[] { -4, 0, 0, -4, 0, 0, -4, -4, -4, 0, -4, -4, -4, -4, -4, 0, 0, -4, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 0, -5, -5, -5, -5, -5 };
            actual = _object.ZeroFront(new[] { -5, -5, 0, 0, -5, 0, 0, -5, -5, 0, 0, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -6, -6, -6 };
            actual = _object.ZeroFront(new[] { -6, 0, -6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -6, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -7, -7, -7 };
            actual = _object.ZeroFront(new[] { 0, 0, 0, 0, 0, 0, -7, 0, 0, 0, -7, -7, 0, 0, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30 };
            actual = _object.ZeroFront(new[] { 0, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            Assert.Equal(expected, actual);

            expected = new[] { 3, 3, 47, 59, 17, 57, 78, 72, 96, 70, 50, 78, 40, 12, 97, 40, 45, 59, 87 };
            actual = _object.ZeroFront(new[] { 3, 3, 47, 59, 17, 57, 78, 72, 96, 70, 50, 78, 40, 12, 97, 40, 45, 59, 87 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Hard")]
        public void CountClumps()
        {

            Int32 expected, actual;

            expected = 2;
            actual = _object.CountClumps(new[] { 1, 2, 2, 3, 4, 4 });
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.CountClumps(new[] { 1, 1, 2, 1, 1 });
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.CountClumps(new[] { 1, 1, 1, 1, 1 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.CountClumps(new[] { 1, 2, 3 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.CountClumps(new[] { 2, 2, 1, 1, 1, 2, 1, 1, 2, 2 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.CountClumps(new[] { 0, 2, 2, 1, 1, 1, 2, 1, 1, 2, 2 });
            Assert.Equal(expected, actual);

            expected = 5;
            actual = _object.CountClumps(new[] { 0, 0, 2, 2, 1, 1, 1, 2, 1, 1, 2, 2 });
            Assert.Equal(expected, actual);

            expected = 5;
            actual = _object.CountClumps(new[] { 0, 0, 0, 2, 2, 1, 1, 1, 2, 1, 1, 2, 2 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.CountClumps(new int[0]);
            Assert.Equal(expected, actual);

        }
        /*
        [Fact]
        [Trait("Category", "Medium")]
        public void Fix34()
        {

            Int32[] expected, actual;

            expected = new[] { 1, 3, 4, 1 };
            actual = _object.Fix34(new[] { 1, 3, 1, 4 });
            Assert.Equal(expected, actual);

            expected = new[] { 1, 3, 4, 1, 1, 3, 4 };
            actual = _object.Fix34(new[] { 1, 3, 1, 4, 4, 3, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 3, 4, 2, 2 };
            actual = _object.Fix34(new[] { 3, 2, 2, 4 });
            Assert.Equal(expected, actual);

            expected = new[] { 3, 4, 3, 4, 2, 2 };
            actual = _object.Fix34(new[] { 3, 2, 3, 2, 4, 4 });
            Assert.Equal(expected, actual);

            expected = new[] { 2, 3, 4, 3, 4, 2, 2 };
            actual = _object.Fix34(new[] { 2, 3, 2, 3, 2, 4, 4 });
            Assert.Equal(expected, actual);

            expected = new[] { 5, 3, 4, 5, 5, 5, 5, 5, 3, 4, 3, 4 };
            actual = _object.Fix34(new[] { 5, 3, 5, 4, 5, 4, 5, 4, 3, 5, 3, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 3, 4, 1 };
            actual = _object.Fix34(new[] { 3, 1, 4 });
            Assert.Equal(expected, actual);

            expected = new[] { 3, 4, 1 };
            actual = _object.Fix34(new[] { 3, 4, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 1, 1, 1 };
            actual = _object.Fix34(new[] { 1, 1, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.Fix34(new[] { 1 });
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.Fix34(new int[0]);
            Assert.Equal(expected, actual);

            expected = new[] { 7, 3, 4, 7, 7 };
            actual = _object.Fix34(new[] { 7, 3, 7, 7, 4 });
            Assert.Equal(expected, actual);

            expected = new[] { 3, 4, 1, 3, 4, 1 };
            actual = _object.Fix34(new[] { 3, 1, 4, 3, 1, 4 });
            Assert.Equal(expected, actual);

            expected = new[] { 3, 4, 1, 3, 4, 1 };
            actual = _object.Fix34(new[] { 3, 1, 1, 3, 4, 4 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Hard")]
        public void Fix45()
        {

            Int32[] expected, actual;

            expected = new[] { 9, 4, 5, 4, 5, 9 };
            actual = _object.Fix45(new[] { 5, 4, 9, 4, 9, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 1, 4, 5, 1 };
            actual = _object.Fix45(new[] { 1, 4, 1, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 1, 4, 5, 1, 1, 4, 5 };
            actual = _object.Fix45(new[] { 1, 4, 1, 5, 5, 4, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 4, 5, 4, 5, 9, 9, 4, 5, 9 };
            actual = _object.Fix45(new[] { 4, 9, 4, 9, 5, 5, 4, 9, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 1, 1, 4, 5, 4, 5 };
            actual = _object.Fix45(new[] { 5, 5, 4, 1, 4, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 4, 5, 2, 2 };
            actual = _object.Fix45(new[] { 4, 2, 2, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 4, 5, 4, 5, 2, 2 };
            actual = _object.Fix45(new[] { 4, 2, 4, 2, 5, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 4, 5, 4, 5, 2 };
            actual = _object.Fix45(new[] { 4, 2, 4, 5, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 1, 1, 1 };
            actual = _object.Fix45(new[] { 1, 1, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 4, 5 };
            actual = _object.Fix45(new[] { 4, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 1, 4, 5 };
            actual = _object.Fix45(new[] { 5, 4, 1 });
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.Fix45(new int[0]);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 4, 5, 4, 5 };
            actual = _object.Fix45(new[] { 5, 4, 5, 4, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 4, 5, 4, 5, 1 };
            actual = _object.Fix45(new[] { 4, 5, 4, 1, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 3, 4, 5 };
            actual = _object.Fix45(new[] { 3, 4, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 4, 5, 1 };
            actual = _object.Fix45(new[] { 4, 1, 5 });
            Assert.Equal(expected, actual);

            expected = new[] { 1, 4, 5 };
            actual = _object.Fix45(new[] { 5, 4, 1 });
            Assert.Equal(expected, actual);

            expected = new[] { 2, 4, 5, 2 };
            actual = _object.Fix45(new[] { 2, 4, 2, 5 });
            Assert.Equal(expected, actual);

        }
        
        [Fact]
        [Trait("Category", "Hard")]
        public void MaxMirror()
        {

            Int32 expected, actual;

            expected = 3;
            actual = _object.MaxMirror(new[] { 1, 2, 3, 8, 9, 3, 2, 1 });
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.MaxMirror(new[] { 1, 2, 1, 4 });
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.MaxMirror(new[] { 7, 1, 2, 9, 7, 2, 1 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.MaxMirror(new[] { 21, 22, 9, 8, 7, 6, 23, 24, 6, 7, 8, 9, 25, 7, 8, 9 });
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.MaxMirror(new[] { 1, 2, 1, 20, 21, 1, 2, 1, 2, 23, 24, 2, 1, 2, 1, 25 });
            Assert.Equal(expected, actual);

            expected = 5;
            actual = _object.MaxMirror(new[] { 1, 2, 3, 2, 1 });
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.MaxMirror(new[] { 1, 2, 3, 3, 8 });
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.MaxMirror(new[] { 1, 2, 7, 8, 1, 7, 2 });
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.MaxMirror(new[] { 1, 1, 1 });
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.MaxMirror(new[] { 1 });
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.MaxMirror(new int[0]);
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.MaxMirror(new[] { 9, 1, 1, 4, 2, 1, 1, 1 });
            Assert.Equal(expected, actual);

            expected = 7;
            actual = _object.MaxMirror(new[] { 5, 9, 9, 4, 5, 4, 9, 9, 2 });
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.MaxMirror(new[] { 5, 9, 9, 6, 5, 4, 9, 9, 2 });
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.MaxMirror(new[] { 5, 9, 1, 6, 5, 4, 1, 9, 5 });
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void NegativePositiveZero()
        {

            int[] actual, expected;

            actual = null;
            _object.NegativePositiveZero(actual);
            expected = null;
            Assert.Equal(expected, actual);

            actual = new int[0];
            _object.NegativePositiveZero(actual);
            expected = new int[0];
            Assert.Equal(expected, actual);

            actual = new[] { 2, 0, -1 };
            _object.NegativePositiveZero(actual);
            expected = new[] { -1, 2, 0 };
            Assert.Equal(expected, actual);

            actual = new[] { 0, 2, 0, -1 };
            _object.NegativePositiveZero(actual);
            expected = new[] { -1, 2, 0, 0 };
            Assert.Equal(expected, actual);

            actual = new[] { 0, 2, -10, 0, -1 };
            _object.NegativePositiveZero(actual);
            expected = new[] { -1, -10, 2, 0, 0 };
            AssertNPZ(expected, actual);

            actual = new[] { 0, 4, -2, 0, 2, -7, 0, -8, 9, 0 };
            _object.NegativePositiveZero(actual);
            expected = new[] { -2, -8, -7, 4, 2, 9, 0, 0, 0, 0 };
            AssertNPZ(expected, actual);

            #region Larger Test Cases: Negatives, Positives, Zeros
            actual = new[] { 0, 0, 0, 10, 0, -6, 5, 5, 0, 16, 0, -14, -14, 0, 19, 0, 6, -19, -14, -4, 12, 15, 2, -20, -7, 0, 0, -10, -1, 0, 13, 5, 18, 0, 2, -10, 0, 19, 9, -14, 0, -17, 0, -12, -20, -19, -10, -17, 0, 0, -17, -4, 1, 2, -13, 0, 6, -10, -14, -19, -13, -16, 0, -3, 0, -9, -3, 0, 0, -2, 17, 16, 2, 0, -9, -1, -16, -16, 0, -19, 3, 0, -12, -1, -14, -13, 0, -15, 20, -4, 14, 19, 3, -3, 0, 20, 0, 0, -16, 18, 13, -19, 12, 3, -17, -3, 0, 2, -20, 18, 0, -9, -10, 0, 7, -7, 0, 5, -19, 16, -13, -18, -12, 0, 14, 0, -17, 0, 0, 1, -10, -19, 0, -19, -2, -8, -19, 15, -14, 18, -7, 1, 0, 0, 4, -8, -2, -3, 19, 6, 0, 3, 0, -3, 0, 0, 0, 8, 18, -15, -16, 18, 2, 8, -3, 10, -9, 0, 7, -15, -18, -19, -11, -7, -7, 16, 0, -14, -1, -8, -2, 15, -15, -7, 8, 17, -11, 2, 10, 0, 0, 2, 0, 0, 3, 4, 0, -5, 4, 0, 0, -11, 20, 4, -6, 12, -17, -2, 0, 14, -8, 5, 0, -4, 16, -1, 3, 0, 0, 10, -10, 19, -2, 9, 14, 9, -16, -13, 19, 19, 17, 13, 12, 4, -9, 0, 0, 11, 0, 0, 3, 0, -3, 0, 5, 0, -7, 0, -15, 0, 0, 0, -6, 0, 4, -18, 0, -19, 19, 14, -2, 0, 8, -15, 0, 8, 0, 4, 0, 6, 4, 0, 0, 0, 0, -2, -9, 2, 0, 19, -14, 14, 0, 14, 18, 0, -11, 18, 0, 0, -12, 13, 0, -15, -3, 7, -18, -18, 0, 0, 0, 18, -5, 8, 0, 0, 12, -12, 17, 0, 20, -12, 0, 0, -2, 13, 0, 0, -4, 0, -11, 0, 3, 0, -12, 20, 0, 0, 8, -1, -15, 0, 3, 0, 17, -3, -12, -7, -16, 9, -17, 0, 0, 0, -12, 0, 6, 0, 17, 13, 12, -12, 15, 0, 7, 0, -16, -2, -11, 9, 0, 19, 10, -13, 19, 11, 15, 0, -19, 0, -6, 0, 10, 16, 16, -11, 0, 9, 7, -11, -16, 0, 0, 0, 16, 0, -7, 4, 0, 20, -17, 20, 0, 4, 1, -7, -11, 13, 0, 6, -16, 6, 11, 16, -12, -18, 7, 0, -18, -13, 0, 5, 20, 0, -5, 0, 14, 16, 0, 0, -12, -20, -1, -9, 17, 4, -4, 0, -15, -7, 0, -11, 3, 0, 0, 7, -5, -12, 6, 4, -11, -6, -8, -18, 0, 7, 0, 0, 0, -1, 9, 3, -17, -18, -12, 0, 0, -10, 0, 13, 15, 1, 13, 18, -13, 4, 0, 19, 0, 17, 6, -5, 0, 0, 2, 0, 18, -13, -5, 0, 5, -7, 0, 15, 14, -3, 0, -9, 12, 0, 0, 0, -11, 0, 19, 17, 11, 3, 0, -9, 5, 0, 0, -9, 0, -17, -7, -13, 9, -5, -16, 20, 0, 19, 0, -8, 5, 0, 0, 20, -3, 10, 0, 0, -13, 0, 0, -14, 0, 15, -19, -15, -8, 0, 4, -4, -15, 5, 0, 0, 0, 19, 11, -14, 16, 9, -20, 0, 15, -4, -18, 14, -1, 0, 0, 0, 0, -18, 0, -7, 0, 0, -20, 0, -17, 0, -2, 20, -15, 11, 0, 0, 0, 4, 16, 8, 0, 20, 0, 8, -11, 5, 1, 9, 2, -3, 15, -13, -20, 8, -6, 0, 1, -1, -9, 0, 8, 17, 0, 16, -19, -10, -15, 0, -10, -18, 9, 0, -13, -15, 0, -19, 0, -5, 0, 3, 4, 1, -8, 16, -16, -20, 10, 6, -13, 0, -2, 5, -18, 19, 0, -19, 17, -8, -4, 0, -11, -2, -11, -11, 17, 20, 0, 0, 11, -18, 0, 0, -5, 18, -8, 0, -6, -14, 2, 0, 9, 9, 16, -13, 13, 0, 12, -2, -15, 15, -6, 10, 0, 0, -17, 0, -18, 0, 0, -7, -19, 16, 0, 0, 0, -7, 0, -7, -4, 0, 16, 0, 20, -5, -11, 10, 11, 0, 5, 14, 0, 1, 8, 0, 17, -11, 0, -9, 4, -14, 0, -8, -12, 0, 19, 0, 14, 11, -15, -10, 0, -11, 0, -7, 0, 0, 20, 3, 14, 3, -6, -19, -4, -16, -15, 9, 0, 0, -13, 12, -14, 18, 18, -20, 0, -6, -18, 11, 5, -4, 0, 0, 15, -15, 20, 18, -1, -15, 0, 0, -1, 2, 6, 0, 0, 13, 0, 0, 0, -20, 15, 16, -6, 2, 0, 0, 0, 0, -5, 4, 12, 0, 0, -12, 7, -6, -5, -19, -6, -4, -20, 0, 0, -6, -17, 14, -19, 17, -12, -17, -2, 0, 17, -5, 10, 0, 6, -18, -19, 14, -12, 8, 20, -7, -20, -11, 4, -12, -7, -3, -12, 14, 9, -3, 0, 0, 16, 0, -11, -11, 0, 13, 2, -19, 0, 3, -9, 2, 7, -1, 18, -17, 0, 9, 0, 1, 0, 6, -17, 0, 0, 0, -7, 0, 0, 13, -1, -10, -5, 16, -9, 6, 0, 0, 20, 4, 0, 8, -13, 7, 0, 0, 11, 0, 9, 0, 14, 0, -12, -3, 0, -20, 16, -5, -20, 0, -10, 11, -15, -8, 0, 0, 0, 0, 0, -19, -11, 0, 18, 4, -4, -7, -12, 6, 0, 0, -19, -2, -18, 20, 0, 0, 0, 0, 0, -19, 20, -3, 11, 19, -16, -6, -8, 0, 2, 0, 0, 19, 17, -3, 15, 6, -20, 14, 0, -2, 0, 0, 0, 0, 19, 0, -1, -5, -8, 4, 0, 0, 0, 0, -9, 0, -4, 0, -11, 0, 0, -8, 0, 0, -20, -9, 11, 14, 0, -8, -11, -12, 0, -5, -11, 10, 0, 8, 0, -8, 0, 0, 2, 0, 0, 18, 0, 0, 0, 0, 0, -19, -6, 0, -2, -1, 0, 2, 0, -3, -20, 14, -10, 0, -16, 10, -19, 2 };
            _object.NegativePositiveZero(actual);
            expected = new[] { -19, -16, -6, -10, -14, -14, -20, -3, -19, -14, -4, -20, -7, -1, -10, -1, -2, -6, -10, -19, -14, -17, -12, -20, -19, -10, -17, -8, -17, -4, -13, -10, -14, -19, -13, -16, -11, -3, -5, -9, -3, -12, -11, -2, -8, -9, -1, -16, -16, -19, -12, -1, -14, -13, -9, -15, -4, -3, -20, -8, -11, -16, -19, -17, -3, -4, -20, -9, -9, -10, -7, -8, -19, -13, -18, -12, -5, -1, -17, -2, -10, -19, -19, -2, -8, -19, -14, -7, -20, -8, -2, -3, -3, -3, -15, -16, -3, -9, -8, -15, -18, -19, -11, -7, -7, -6, -14, -1, -8, -2, -15, -7, -11, -16, -3, -5, -19, -11, -6, -17, -2, -18, -8, -2, -4, -1, -19, -10, -2, -16, -13, -9, -12, -7, -4, -3, -11, -19, -7, -8, -15, -15, -10, -6, -20, -18, -5, -19, -2, -15, -20, -3, -12, -2, -9, -13, -14, -11, -12, -9, -15, -3, -18, -18, -5, -10, -5, -1, -12, -7, -12, -17, -2, -4, -17, -11, -1, -12, -1, -15, -9, -3, -12, -7, -16, -17, -19, -12, -11, -11, -12, -3, -16, -2, -11, -13, -19, -12, -6, -3, -11, -7, -11, -16, -12, -11, -20, -7, -7, -17, -7, -11, -16, -12, -18, -12, -18, -13, -19, -5, -18, -12, -20, -1, -9, -4, -5, -15, -7, -11, -2, -17, -5, -12, -11, -6, -8, -18, -12, -19, -1, -17, -18, -12, -17, -6, -10, -20, -13, -4, -6, -5, -19, -5, -6, -13, -5, -7, -12, -3, -9, -5, -11, -6, -9, -20, -9, -17, -7, -13, -5, -16, -8, -1, -15, -3, -1, -13, -15, -14, -19, -15, -8, -4, -4, -15, -18, -14, -20, -6, -4, -18, -1, -20, -14, -18, -7, -13, -20, -15, -17, -16, -2, -15, -4, -19, -6, -11, -3, -13, -20, -6, -1, -9, -7, -19, -10, -15, -11, -10, -18, -10, -13, -15, -15, -19, -5, -8, -16, -20, -13, -2, -18, -12, -19, -8, -4, -8, -11, -2, -11, -11, -14, -18, -9, -11, -5, -8, -6, -14, -13, -2, -15, -6, -17, -18, -11, -7, -19, -5, -7, -4, -7, 4, 19, 11, 15, 14, 20, 17, 4, 16, 10, 16, 16, 20, 5, 9, 7, 20, 4, 2, 4, 12, 16, 16, 2, 4, 10, 20, 14, 20, 20, 4, 1, 2, 5, 13, 8, 6, 5, 6, 11, 16, 14, 16, 7, 19, 3, 14, 14, 5, 20, 6, 10, 19, 14, 16, 6, 10, 19, 8, 9, 14, 17, 4, 9, 1, 3, 19, 17, 19, 3, 17, 13, 7, 12, 4, 6, 4, 11, 14, 5, 11, 6, 7, 17, 4, 14, 3, 9, 3, 18, 1, 2, 5, 15, 13, 18, 13, 15, 1, 13, 18, 10, 4, 1, 19, 11, 17, 6, 20, 6, 4, 2, 4, 18, 6, 14, 7, 5, 19, 19, 15, 14, 14, 12, 19, 12, 4, 16, 2, 8, 6, 19, 17, 11, 3, 16, 15, 5, 15, 8, 3, 13, 4, 3, 6, 9, 4, 14, 20, 6, 19, 2, 9, 5, 11, 7, 20, 5, 10, 17, 18, 2, 20, 19, 19, 15, 15, 2, 14, 8, 14, 4, 18, 4, 5, 5, 11, 8, 19, 11, 18, 16, 9, 20, 6, 15, 18, 13, 14, 18, 20, 18, 18, 18, 7, 12, 2, 8, 9, 16, 10, 10, 18, 2, 20, 8, 11, 16, 13, 12, 4, 16, 8, 3, 20, 14, 8, 7, 5, 1, 9, 2, 17, 15, 18, 20, 8, 13, 3, 1, 14, 6, 20, 8, 17, 12, 16, 13, 1, 9, 3, 19, 16, 9, 18, 3, 9, 12, 20, 11, 7, 14, 3, 4, 1, 2, 16, 8, 2, 10, 6, 18, 19, 18, 5, 3, 19, 3, 17, 17, 15, 15, 2, 8, 9, 17, 2, 17, 20, 2, 4, 11, 13, 2, 10, 6, 18, 4, 17, 17, 13, 2, 8, 9, 9, 16, 12, 13, 1, 12, 19, 15, 15, 16, 10, 14, 5, 7, 11, 2, 10, 11, 7, 3, 16, 9, 20, 16, 9, 19, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            AssertNPZ(expected, actual);
            #endregion

        }
        */
        [Fact]
        [Trait("Category", "Medium")]
        public void RotateOne()
        {

            int[] actual, expected;

            expected = null;
            actual = null;
            _object.Rotate(actual, false);
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = new[] { 1 };
            _object.Rotate(actual, false);
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 1 };
            actual = new[] { 1, 2 };
            _object.Rotate(actual, false);
            Assert.Equal(expected, actual);
            actual = new[] { 1, 2 };
            _object.Rotate(actual, true);
            Assert.Equal(expected, actual);

            expected = new[] { 3, 1, 2 };
            actual = new[] { 1, 2, 3 };
            _object.Rotate(actual, false);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 3, 1 };
            actual = new[] { 1, 2, 3 };
            _object.Rotate(actual, true);
            Assert.Equal(expected, actual);

            actual = SampleArray();
            _object.Rotate(actual, false);
            expected = new[] { 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, false);
            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            Assert.Equal(expected, actual);

            actual = SampleArray();
            _object.Rotate(actual, true);
            expected = new[] { 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20 };
            Assert.Equal(expected, actual);
            _object.Rotate(actual, true);
            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void RotateMany()
        {

            int[] actual, expected;

            actual = new[] { 1, 2, 3, 4 };
            _object.Rotate(actual, 0);
            expected = new[] { 1, 2, 3, 4 };
            Assert.Equal(expected, actual);
            actual = new[] { 1, 2, 3, 4 };
            _object.Rotate(actual, -1);
            expected = new[] { 4, 1, 2, 3 };
            Assert.Equal(expected, actual);
            actual = new[] { 1, 2, 3, 4 };
            _object.Rotate(actual, -2);
            expected = new[] { 3, 4, 1, 2 };
            Assert.Equal(expected, actual);
            actual = new[] { 1, 2, 3, 4 };
            _object.Rotate(actual, -3);
            expected = new[] { 2, 3, 4, 1 };
            Assert.Equal(expected, actual);
            actual = new[] { 1, 2, 3, 4 };
            _object.Rotate(actual, -4);
            expected = new[] { 1, 2, 3, 4 };
            Assert.Equal(expected, actual);

            actual = new[] { 1, 2, 3, 4 };
            _object.Rotate(actual, 1);
            expected = new[] { 2, 3, 4, 1 };
            Assert.Equal(expected, actual);
            actual = new[] { 1, 2, 3, 4 };
            _object.Rotate(actual, 2);
            expected = new[] { 3, 4, 1, 2 };
            Assert.Equal(expected, actual);
            actual = new[] { 1, 2, 3, 4 };
            _object.Rotate(actual, 3);
            expected = new[] { 4, 1, 2, 3 };
            Assert.Equal(expected, actual);
            actual = new[] { 1, 2, 3, 4 };
            _object.Rotate(actual, 4);
            expected = new[] { 1, 2, 3, 4 };
            Assert.Equal(expected, actual);

            actual = SampleArray();
            _object.Rotate(actual, 0);
            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 1);
            expected = new[] { 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 2);
            expected = new[] { 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 3);
            expected = new[] { 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 4);
            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 5);
            expected = new[] { 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 6);
            expected = new[] { 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 7);
            expected = new[] { 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 8);
            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 9);
            expected = new[] { 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 10);
            expected = new[] { 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 11);
            expected = new[] { 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 12);
            expected = new[] { 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 13);
            expected = new[] { 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 14);
            expected = new[] { 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 15);
            expected = new[] { 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 16);
            expected = new[] { 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 17);
            expected = new[] { 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 18);
            expected = new[] { 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 19);
            expected = new[] { 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 20);
            expected = new[] { 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 21);
            expected = new[] { 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, 22);
            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            Assert.Equal(expected, actual);

            actual = SampleArray();
            _object.Rotate(actual, -1);
            expected = new[] { 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -2);
            expected = new[] { 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -3);
            expected = new[] { 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -4);
            expected = new[] { 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -5);
            expected = new[] { 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -6);
            expected = new[] { 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -7);
            expected = new[] { 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -8);
            expected = new[] { 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -9);
            expected = new[] { 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -10);
            expected = new[] { 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -11);
            expected = new[] { 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -12);
            expected = new[] { 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -13);
            expected = new[] { 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -14);
            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -15);
            expected = new[] { 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -16);
            expected = new[] { 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -17);
            expected = new[] { 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -18);
            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -19);
            expected = new[] { 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -20);
            expected = new[] { 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -21);
            expected = new[] { 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2 };
            Assert.Equal(expected, actual);
            actual = SampleArray();
            _object.Rotate(actual, -22);
            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            Assert.Equal(expected, actual);


            // These test cases should not take long.

            expected = SampleArray();
            actual = SampleArray();
            _object.Rotate(actual, 1100000000);
            Assert.Equal(expected, actual);
            _object.Rotate(actual, -1100000000);
            Assert.Equal(expected, actual);

            actual = SampleArray();
            _object.Rotate(actual, 1100000011);
            expected = new[] { 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14 };
            Assert.Equal(expected, actual);

        }

        

        [Trait("Category", "Medium")]
        [Fact]
        public void PalindromicCount()
        {

            int[] array;
            int expected, actual;

            array = null;
            expected = 0;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new int[0];
            expected = 0;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 1, 2, 3, 4, 3, 2, 1 };
            expected = 0;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 1, 3, 2, 1, 7, 0, 7, 2, 3, 3, 7 };
            expected = 3;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 7, 3, 3, 2, 7, 0, 7, 2, 3, 3, 7 };
            expected = 0;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 1, 3, 2, 1, 7, 7, 2, 3, 3, 7 };
            expected = 3;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -57, -10, 44, -52, -85, 47, 70, 53, -86, -9, 35, 99, 71, 96, 44, 11, -6, -53, -35, 52, -30, -43, -97, -55, 19, 18, -48, 93, 19, -79, -71, 81, -16, 92, 78, -12, -94, 38, 13, 70, -65, 80, -72, -75, 12, -74, 85, 93, -56, -52, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 0;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -57, -10, 44, -52, -85, 47, 70, 53, -86, -9, 35, 99, 71, 96, 44, 11, -6, -53, -35, 52, -30, -43, -97, -55, 19, 18, -48, 93, 19, -79, -71, 81, -16, 92, 78, -12, -94, 38, 13, 70, -65, 80, -72, -75, 12, -74, 85, 93, -56, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 0;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -57, -10, 44, -52, -85, 47, 70, 53, -86, -9, 35, 99, 5, 96, 44, 11, -6, -53, -52, 52, -30, -43, -97, -5, 19, 18, -48, 93, 19, -79, -71, 81, -16, 92, 78, -12, -94, 16, 13, 70, -65, 80, -72, -81, 12, -12, 85, -38, -56, -28, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 7;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -57, -10, 44, -52, -85, 47, 70, 53, -86, -9, 35, 99, 71, 49, 44, 11, 48, -53, -35, 52, -30, -70, 32, -18, 19, 18, -48, 93, 19, -79, -71, 81, -16, 92, 78, -12, -94, 34, 13, 70, -65, 80, -72, 33, 12, -74, 85, -99, -56, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 8;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -57, -84, 44, -40, -85, 62, 70, 53, -86, -9, 10, 99, 99, 96, 44, -79, -6, -42, -35, 52, -30, -43, -97, -74, 19, 18, -93, 93, 19, -79, -71, 81, -16, 92, 95, 18, -94, 10, 13, 58, -64, 80, 88, -75, 12, -74, 85, 93, -56, 6, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 15;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -57, 80, 74, -52, -85, 47, 83, -38, -9, -9, 35, -60, -60, 96, 44, 11, -6, -53, 60, 52, 61, -43, 92, -55, 19, 18, 48, 93, 19, -79, -71, -68, -93, -6, 78, -12, -34, 38, 13, 70, -65, -75, -72, -75, 25, -74, -48, 93, -56, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 18;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -57, -12, -62, -52, -85, 84, 70, 88, 82, -9, 51, 99, 71, 96, 44, 11, -6, 60, 97, 52, -30, -84, -97, 12, 19, 18, -48, 93, 55, -79, -71, 55, -16, -71, 78, 21, -94, -50, 13, -63, -75, -17, -32, 51, 12, -54, 85, 93, 56, -66, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 22;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -57, -10, 44, 87, -85, -87, 70, 53, 5, -9, 35, -98, 71, 4, -70, 91, 22, 27, -35, -61, -14, -49, -28, 22, 4, 18, 67, 7, 19, -79, -71, 18, -16, 76, 76, -12, -94, 38, -75, 70, -65, 46, -72, 43, 88, -74, 85, 93, -56, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 24;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 75, -57, -10, 44, -52, 94, -69, 52, 49, -86, -9, -49, 99, -57, 35, 2, -93, -6, 66, -35, 52, -33, -43, -97, -55, 19, 82, -48, 93, 31, -91, 70, 81, 22, 6, 78, -39, 48, 38, 13, 60, -26, 96, -99, -75, 87, 67, -98, 93, -56, -82, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 27;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -6, 88, -10, 44, -99, -33, 47, -38, 53, -39, -53, 65, 23, 99, 96, 88, 11, -6, -53, -36, 60, -30, -64, -97, -55, -21, -99, -48, 93, 54, 73, 44, 81, -16, -92, -99, -64, -1, 27, 99, 32, -65, -69, -11, -75, 12, -74, 85, 93, -60, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 29;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -57, 44, 66, 68, -84, -77, -33, 53, -62, -75, -58, -14, 39, 42, 15, 95, -6, 83, 97, 52, -30, 78, 10, -21, 19, 18, 2, 93, 19, 44, -71, 81, -98, -86, -13, -35, 87, -92, 92, -15, -65, 80, -72, -75, 12, -37, 85, 93, 49, -44, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 31;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -57, -10, 9, 55, 55, -57, -36, 53, 85, -9, -33, -47, -51, 16, -16, 11, -96, -53, -67, 52, -85, -16, -97, -90, -79, -66, -48, -3, -83, -79, -71, 81, 69, 16, 19, 23, 51, 15, 40, 44, 83, 5, -20, 17, 12, 75, 85, 37, -91, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 35;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -39, -92, -10, -24, -52, -78, 47, 70, 12, -44, 73, -75, 99, -7, -1, -26, 32, -6, -53, -35, 23, -13, 85, 66, -55, 7, 18, -53, 26, 90, -79, -71, 80, 91, 66, 4, -26, -94, -84, -55, 70, 58, 59, -75, 72, 12, -23, 85, 93, 60, 96, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 33;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -32, -35, 53, 44, -76, 80, 62, 31, 79, -86, 70, 0, 4, -90, -22, -40, 78, -6, -53, -5, 52, -33, -43, -80, -74, -62, 18, -48, 43, 19, 67, -71, 56, -26, -97, -80, -12, -94, -81, 13, 70, -24, -29, -23, -83, 54, 16, 56, -67, 54, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 36;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 18, -57, -10, -38, 20, 77, 46, -38, 53, 77, 3, 11, 9, -53, 96, -28, -45, -6, 61, -44, 52, 53, -83, 59, 69, -8, 18, 80, -21, -27, -79, 69, 81, -69, 19, 78, 78, -94, -63, 38, -70, 87, 80, -79, 54, 16, 81, 97, -43, -74, -45, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 38;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 42, 23, 46, 44, 75, -85, 47, 70, 68, -86, 13, 64, 73, 8, -5, -15, -56, 59, -53, 49, -91, -30, 7, 62, -55, 41, 18, 8, 78, 24, 57, 63, -21, -16, -41, -31, -12, 73, -97, -58, 70, -36, -6, -72, -75, -96, -86, 94, -27, 66, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 36;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, -61, 85, 44, -67, -94, 95, 18, -49, -86, -66, -21, -8, -72, 96, -74, -11, -67, -32, 87, -1, -30, 99, -97, -55, -17, 6, 22, -11, 14, -97, 42, -72, -16, -67, 56, 93, -90, -81, 2, 37, -22, 52, 75, -75, -92, -74, -3, -68, 85, -35, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 40;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 79, 1, 23, 44, 14, -76, 25, -51, 81, -47, 42, -26, -87, 21, 0, 62, 37, 64, -53, -35, 41, -15, 53, -69, -83, 70, 52, -52, 89, 19, -84, 93, -49, 64, -29, 12, -14, -8, 38, -73, 70, -88, 80, 40, 46, -21, -44, 85, 1, -19, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 41;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -9, -28, -10, 62, 8, 58, 32, -13, 53, 33, -9, 71, -45, -78, -54, 55, 11, 32, -37, -31, 52, -16, 46, -76, -66, -91, 18, 31, -30, 59, -79, -18, -32, -95, -91, 51, 65, 98, -35, -5, -88, -32, 69, -72, -48, 25, -57, -86, 93, -83, -39, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 41;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 36, 15, 70, -7, -38, -85, -31, 70, -2, -54, 13, -60, -18, 71, -67, -73, -59, 53, 75, -35, -19, 38, -43, 80, -74, 63, -64, -48, 47, 19, -71, 80, -77, 62, 56, -38, 64, 77, 28, 13, -41, 65, -36, -33, 42, 12, -9, 87, -14, -3, -56, 93, 85, -74, 12, -75, -72, 80, -65, 70, 13, 38, -94, -12, 78, 92, -16, 81, -71, -79, 19, 93, -48, 18, 19, -55, -97, -43, -30, 52, -35, -53, -6, 11, 44, 96, 71, 99, 35, -9, -86, 53, 70, 47, -85, -52, 44, -10, -57, 79 };
            expected = 41;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 18, -43, 56, 2, 56, -61, -49, -81, -1, 72, -70, -73, -12, -62, 40, 66, 4, -62, -67, -10, -11, -63, 21, -86, 82, -65, -33, -95, -24, -64, -81, -87, 27, 26, 30, -38, -87, 28, -13, -87, -38, 14, -11, -20, 53, -86, 84, -72, 97, -2, 4, -2, 97, -72, 84, -86, 53, -20, -11, 14, -38, -87, -13, 28, -87, -38, 30, 26, 27, -87, -81, -64, -24, -95, -33, -65, 82, -86, 21, -63, -11, -10, -67, -62, 4, 66, 40, -62, -12, -73, -70, 72, -1, -81, -49, -61, 56, 2, 56, -43, 18 };
            expected = 0;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 52, 73, -14, 64, -19, 36, 42, 20, 22, 71, -53, 43, -36, 53, -82, -1, 61, 7, -22, 53, 75, 51, -80, -72, 75, 48, -58, -39, 68, -49, -60, -92, 78, 31, -34, -61, -58, 62, -50, 26, -29, -91, 65, -58, -84, 71, -74, 26, 35, 14, 14, 35, 26, -74, 71, -84, -58, 65, -91, -29, 26, -50, 62, -58, -61, -34, 31, 78, -92, -60, -49, 68, -39, -58, 48, 75, -72, -80, 51, 75, 53, -22, 7, 61, -1, -82, 53, -36, 43, -53, 71, 22, 20, 42, 36, -19, 64, -14, 73, 52 };
            expected = 0;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -76, 20, 20, 52, 28, -98, -37, -42, 88, 33, -6, -19, 52, -28, 32, -61, 64, 33, -13, 78, -42, 98, -42, -61, -55, 67, 85, 77, -87, -95, 23, 15, 25, -46, -72, 19, -13, -66, -97, -43, -84, 83, -38, 17, 55, 90, -89, -6, 10, 76, -93, 76, 10, -6, -43, 90, -68, 17, 73, 83, -15, -35, -97, -66, -13, 19, -72, -46, 25, 15, 23, -95, -87, 77, 85, 67, -17, 51, -42, 98, -42, 78, -13, 33, 64, -61, 32, -28, 52, -19, -6, 33, 88, -42, 54, -98, 28, 44, 20, 20, -76 };
            expected = 9;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 31, 30, -77, -6, -26, -75, 41, 20, -66, 11, 57, -32, -64, 97, -69, -24, -42, 97, -97, -44, 19, 72, -58, -50, 8, 38, 88, 7, -48, -65, -32, -50, -3, -75, -25, 62, -83, -37, -57, 99, 22, -51, -88, -49, 23, 9, 36, 87, 79, 4, 4, 79, 87, -90, 9, 23, -49, 69, -51, 22, 99, 82, -37, -83, 62, -25, -75, -3, -50, 58, -65, -48, 7, 88, 38, 8, -50, -58, 72, 19, -44, -97, 97, 68, -24, -69, 97, -64, -32, -8, 11, -7, 20, 41, -75, -26, -6, -77, 30, 31 };
            expected = 7;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -41, -53, -85, 4, 33, -30, 61, -45, 26, 99, 28, -38, 27, 48, 19, 0, -92, 39, 90, 17, -25, -55, -60, -53, 63, -12, 78, 11, -2, -19, 37, 98, 81, 12, -55, -18, -14, -61, -76, 63, 55, 71, 16, 86, 98, -66, 7, 19, -89, -6, -65, -6, -89, 19, 7, -66, -92, 86, -54, -4, 55, 63, -76, -61, -14, -18, -55, 12, -35, 98, 37, -19, -2, 11, 80, -12, 63, -53, -22, -55, -25, 17, 90, 39, -92, -42, -52, 48, 27, -98, 28, 99, 26, 91, -96, -30, 33, -97, -85, 5, -41 };
            expected = 13;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 19, 99, 78, -26, 66, -97, -99, 24, -22, -4, -8, -28, -54, 23, -35, 16, 93, -5, -85, -84, 36, 28, 14, -36, -72, -85, -11, 99, -99, 90, -21, -3, -27, 11, -91, 35, -61, 53, -3, 75, 98, -34, 61, 81, -60, -54, -86, -19, -38, 89, 89, 81, -19, -45, -54, -11, -66, 61, 67, 98, 75, -3, 53, 37, 70, -47, 11, -27, -3, -21, 51, 56, 99, -11, 91, -72, -36, 10, 28, 36, -84, -85, -55, 93, 16, -35, 23, -54, -84, -8, -4, -22, 24, -99, -97, -36, -26, 78, 99, 19 };
            expected = 15;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -28, -77, 7, -74, -38, -94, 99, -65, -84, -6, -10, -61, -54, -59, -61, 45, -9, -35, -77, 48, -76, -34, -68, -35, 69, -92, 83, -99, 60, 8, -97, -38, 42, -91, 52, 55, 14, 22, 77, -85, 70, 32, -40, -42, 78, -83, 97, 31, -41, -25, 99, -79, 55, 31, 97, -83, -22, -18, -40, 32, 70, -80, 77, 22, 32, 55, -85, -91, 42, -16, -97, 51, 60, -99, 83, 5, 35, -35, 39, -86, -76, 48, 97, -35, -34, 45, -88, -13, -89, 20, 4, -6, -84, -65, 99, 97, -38, -74, 7, -77, -19 };
            expected = 22;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -17, -94, 16, -8, 62, 53, 36, 12, -28, 97, -20, 53, -4, 83, -71, -74, 92, 71, -13, -66, 57, -33, -22, -31, 12, 92, 70, 31, -26, -65, 50, -9, 86, -67, -9, -66, -39, -58, -57, 59, 21, -17, 7, 12, 93, -27, 34, 16, -16, 43, 43, -16, 16, 34, 62, 58, -40, 74, -17, 21, -80, -57, 71, -39, -66, -54, -67, -78, -68, 38, -65, -4, 31, 45, 92, 12, -19, 29, -33, 57, -66, -94, 71, -33, 12, 24, 83, 25, -66, -20, 97, -84, 12, 36, 53, 62, -51, 71, -44, -74 };
            expected = 25;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -3, -42, 68, -4, 12, 79, -69, -61, 48, -66, -24, -36, 67, -97, -55, -19, 4, -43, 76, 96, -93, 0, 79, 29, 15, 9, -50, -45, -39, -99, -54, -2, 5, 77, 90, -62, -98, 69, 67, 91, 58, 89, -28, -24, -99, 98, -75, 28, -90, -89, -83, -89, -90, 28, -75, -55, -65, 67, -28, -95, 58, -67, 60, -51, -98, -51, -79, 92, 5, -1, -57, 83, -39, -45, -50, -83, -99, -88, -31, 0, -93, 96, 75, -43, -39, -19, 84, -49, -83, 5, -24, -66, 20, -37, 57, 79, 12, 85, 68, -42, -34 };
            expected = 28;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -8, 18, 20, -1, 91, -73, 71, 18, 48, 97, -55, 32, 15, 16, 70, 88, -64, -93, 29, -58, -10, 28, 93, 30, 44, -96, 21, -81, -30, -44, 98, 17, 21, -24, -53, 28, -81, -87, 46, 81, 94, 59, -63, -99, 32, 69, -31, -1, 5, 67, 67, 5, -40, -31, 69, 32, 87, -93, -67, -13, 81, 12, 17, -41, 64, -53, -24, 85, 17, 98, -44, -2, 97, 21, -8, 44, -20, 3, 66, -48, 97, -3, 61, -64, -34, 70, 16, -59, 32, -55, -14, 63, 18, 71, -75, 91, 12, 20, 24, -8 };
            expected = 27;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 44, 85, -17, -48, 77, 19, -29, 57, 13, 49, 77, -43, -80, 99, 55, -61, 28, 56, -5, -71, 26, -28, 65, 41, -50, -24, -31, 40, -59, -11, -83, 84, -52, 30, 23, -16, -98, -30, -59, -45, 97, 8, -70, -84, -34, 15, -80, 11, 92, 24, -40, -77, 92, -63, -80, -94, -48, -84, 21, -13, 71, 58, -59, 46, -10, 4, 23, -24, 90, 84, -75, 72, -63, -57, -31, -24, -50, 41, 35, 22, -67, -63, 35, 56, 28, -61, 55, 99, 26, 48, 7, 49, 69, 94, -29, 19, 52, 45, -84, -38, -94 };
            expected = 32;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 64, -3, 44, 32, 39, -69, 24, 87, 76, 48, 31, -51, -87, -54, -96, -48, -77, 1, -45, 63, -32, 84, 88, 99, -94, 13, -53, -23, 3, -41, 11, -63, 53, -22, -60, -62, -17, -28, 18, -44, -64, -35, 99, 65, -74, -53, -57, 79, 25, -63, 92, 56, -11, -57, 5, 66, -14, 99, -57, 48, -44, 18, -28, -50, -62, -69, 57, 80, -92, 29, 4, 3, -23, -53, 13, -18, 99, -50, -96, -32, 46, 33, -47, -74, 78, -96, -97, -87, -46, 46, 48, 40, -33, 24, -69, -20, -12, 78, -60, 86 };
            expected = 33;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 77, -53, -34, -73, -80, 93, 6, 91, -3, 63, -39, 36, 56, 91, 93, 99, 27, 41, 18, 70, 31, 95, 0, -12, 46, 21, -72, -93, 3, -5, -85, 61, -99, 40, 53, -56, 3, -1, 20, 51, 87, -39, -62, 1, -29, -38, 0, -59, -36, 27, -5, 27, -36, -59, 38, 37, -16, -58, -42, -50, -10, 51, 20, -28, -87, 22, 22, 60, 29, -49, 34, -5, -42, -93, 47, -22, -27, -12, -93, 95, 85, -86, -16, 41, 27, 40, 24, -50, 26, -70, 64, -94, -27, 91, 92, 93, -15, -73, -72, -74, 75 };
            expected = 36;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -89, -29, 60, 33, 95, 81, -65, -82, -47, -41, -63, -74, 92, -15, -23, 55, -95, -49, -60, -17, -28, 76, 86, -42, 41, 87, 42, -19, -55, -14, -67, 79, 74, -81, -45, -90, -19, 72, -78, -45, -84, -58, -38, 65, -23, -8, 28, -46, 98, -71, -71, 98, 41, 28, 93, -33, -73, 8, -58, -84, 85, -78, 17, -14, -57, -2, -81, 46, 79, -67, 85, 17, -29, -28, -12, 32, -42, 86, 20, -33, -38, -29, -24, 43, 55, 6, 58, -36, -38, -63, 18, -47, -15, -9, -59, 35, 33, -83, -29, 62 };
            expected = 34;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 90, -31, 90, 75, 29, 65, -10, 98, -23, -18, -62, -46, 94, 68, 32, 68, -10, 24, 57, 88, -9, 71, 9, 11, -82, -91, -58, -2, -65, 39, 31, 70, 3, -74, 34, -13, -59, 33, -91, 50, 15, -62, -4, -30, -3, 92, 44, -76, 32, 79, 27, 42, 39, -96, -2, 30, -66, 58, -4, 59, 82, 15, -91, -85, -59, -61, 86, -24, -47, 70, 31, 65, 84, 76, -33, 39, 90, 11, 9, 71, -1, 88, 0, 61, 32, 59, -97, -8, 94, -46, 84, -29, 80, -81, -10, 65, -50, -74, 52, -90, 90 };
            expected = 36;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 45, 10, 12, 95, -45, 52, -96, -65, 72, -89, 31, 42, -78, 48, -37, 56, 54, 40, 9, -67, 83, 21, 82, -40, -91, 47, -23, 49, -26, -42, 88, 65, -24, 16, 48, 6, -36, 63, -11, 1, -17, 29, -77, -7, -67, 70, -95, -28, 16, -46, 28, 68, -28, -95, 70, 51, -32, -59, 29, 75, 2, -11, 90, -36, 6, -39, 69, -24, 36, 54, -42, -26, 28, 48, 10, 37, -77, 13, -57, -39, -67, 41, 16, 54, 56, 76, 14, -78, 63, 31, 69, -25, -65, 57, -53, -37, 58, 12, 10, -91 };
            expected = 32;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -29, -91, 85, -25, 72, -11, -84, 15, -2, 48, -40, -43, -24, 98, 81, -32, -58, 17, -20, -82, 50, 75, 86, 39, -93, -4, -65, 94, 48, 98, -54, -33, -45, -56, -65, -96, -19, 9, 23, -15, 85, 71, 53, -68, 82, 71, -80, 42, -61, -94, 60, 69, -66, 99, 42, 5, -95, -22, -59, 69, 95, -28, 75, 9, -19, 62, -65, -69, -45, -90, 30, -30, 26, -2, -65, -7, 55, 32, -66, 85, -34, 5, 20, 78, -50, -32, -80, 98, 41, -43, 99, 48, -31, 5, 69, -47, 72, 94, 26, 99, -41 };
            expected = 40;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { -8, 39, 25, -70, -36, -45, -39, -86, -79, 8, -14, -54, 99, 95, -79, 59, 53, -5, -33, -49, 75, -32, 59, -26, -84, -23, 84, 14, -34, -89, -19, 73, -56, -45, 52, -54, -16, -10, 28, -94, 2, 3, -1, 2, 46, 3, -88, 91, -14, 52, -53, -36, 91, 37, -83, 54, 23, 56, -48, 55, -94, 76, -10, 32, 3, 52, 30, 6, -26, 94, -89, -29, -59, 84, 46, -84, -95, 67, -14, 75, 91, 50, -38, 53, 49, -79, 65, 5, -51, 17, -20, 41, 80, -39, -80, 62, -97, -60, -38, -8 };
            expected = 38;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 98, -94, 66, 73, 56, -90, 35, -93, 92, -65, 37, -8, 14, -24, -66, 24, -79, -67, 73, -1, -53, -51, -42, -17, 2, -69, 77, -28, 86, 14, -77, -62, 85, 86, 91, -70, 38, -88, -63, -53, -3, -47, 43, 76, 89, 91, 80, -12, 96, -38, -43, 74, 96, -12, 88, -78, -10, -30, 94, -85, -3, -13, 87, 9, 88, 55, 91, -33, 85, 94, 61, 34, 46, 73, 94, 44, -60, 3, -88, -34, -53, -24, 73, -93, -79, 26, 98, 63, -23, -8, -95, 99, -40, -93, 15, -1, -1, -16, 13, -94, 7 };
            expected = 39;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);

            array = new[] { 87, 54, -69, -94, 62, -64, 38, 90, 80, -2, -72, -9, -51, -29, 40, -94, -1, 54, -72, 49, -10, -34, 43, -75, 34, -23, -46, -17, -37, 87, -82, 13, -21, 45, 65, -90, 1, -8, -21, -91, 73, -81, -92, -49, 37, -8, 59, -64, 93, 43, -28, 90, 96, -59, 54, 9, -64, -23, 41, -39, 95, -55, -8, -77, 96, 36, -55, 77, -79, -82, -36, -41, 91, 90, 26, 34, -75, 8, -65, 75, 15, 43, 54, -44, -57, -68, 27, 51, -21, -22, -2, 80, 48, 38, -5, -42, -94, -69, 70, 37 };
            expected = 40;
            actual = _object.PalindromicCount(array);
            Assert.Equal(expected, actual);


         

        }
        
        [Trait("Category", "Hard")]
        [Fact]
        public void InEquilibrium()
        {

            bool actual;
            int[] array;

            array = new[] { 2, 4, 8, 6, 1, 2, 3, 4, 3, 6, 9, 12 };
            actual = _object.InEquilibrium(array);
            Assert.True(actual);

            array = new[] { 3, -9, 3, 9 };
            actual = _object.InEquilibrium(array);
            Assert.True(actual);

            array = new[] { -2, -7, 4, -7 };
            actual = _object.InEquilibrium(array);
            Assert.False(actual);

            array = new[] { -7, 2, -6, -7, 3, -8, 9, 0 };
            actual = _object.InEquilibrium(array);
            Assert.True(actual);

            array = new[] { -1, 3, 1, 8, 0, -4, -1, 5 };
            actual = _object.InEquilibrium(array);
            Assert.False(actual);

            array = new[] { 2, 7, 7, 2, -8, 3, 1, -8, 0, 9, -3, 6, 2, 3, 7, 3, 4, 4, 7, 7, -8, 0, -1, -7, 1, -5, -4, -7, 9, 4, 6, 9, -6, 0, -3, 4, 8, -6, 3, 3, -2, -9, -4, 7, -5, -2, 9, -9, -4, -4, -1, -3, -7, 9, -8, -7, -1, 5, -8, 7, -3, -2, -8, 5 };
            actual = _object.InEquilibrium(array);
            Assert.True(actual);

            array = new[] { 0, -5, 7, -7, 9, 5, -1, -7, -5, -2, -1, -9, 6, 2, 0, 6, -1, 7, 4, 4, 6, 4, 3, -7, 8, -3, 7, -1, -1, -4, -4, 5, 7, -2, -4, 7, -3, -1, 1, 8, 9, 3, -4, 8, 8, -8, 6, 0, 9, 8, -2, 5, -6, 3, -5, 6, 2, 4, -6, 2, 8, 9, 3, 9 };
            actual = _object.InEquilibrium(array);
            Assert.False(actual);

         


        }

        [Fact]
        public void ClosestAdjacent()
        {

            double expected, actual;
            int[] input;
            try
            {
                actual = _object.ClosestAdjacent(null);
                Assert.True(false, $"Should throw an ArgumentNullException but instead return {actual:N5}");
            }
            catch (ArgumentNullException) { }

            try
            {
                actual = _object.ClosestAdjacent(new int[0]);
                Assert.True(false, $"Should throw an InvalidOperationException but instead return {actual:N5}");
            }
            catch (InvalidOperationException) { }

            try
            {
                actual = _object.ClosestAdjacent(new[] { 1 });
                Assert.True(false, $"Should throw an InvalidOperationException but instead return {actual:N5}");
            }
            catch (InvalidOperationException) { }

            expected = 1.5;
            input = new[] { 1, 3, 2, 5 };
            actual = _object.ClosestAdjacent(input);
            Assert.Equal(expected, actual, 5);

            expected = 4;
            input = new[] { -9, 4, -1, 2, -4, 6, -4, 7, -5, 1 };
            actual = _object.ClosestAdjacent(input);
            Assert.Equal(expected, actual, 5);

            #region Longer Test Cases - ClosestAdjacent
            expected = 11;
            input = new[] { -875, 90, 884, 814, -229, -662, -813, -5, -791, -635, 499, -179, -775, -173, 5, -150, -794, 174, -910, 102, 376, 622, 566, -757, 466, 21, -275, 863, -479, 437, -903, 359, 214, 155, 704, -934, 559, -832, 235, -134, 438, 529, -716, -706, -986, 329, -611, -220, -533, -685, -477, -209, -407, -411, -906, -498, 524, 641, -652, 750, 612, -676, -527, -229, -733, -861, 606, 70, 122, -61, 291, -963, 939, 223, 664, 847, 337, 272, -772, -864, -369, 944, 396, -795, -87, 306, -234, -375, 60, 202, -458, 918, 820, 484, 254, 114, 55, 512, -974, 874, 722, 319, 658, 528, 24, -514, -148, 369, -75, -753, 164, -749, 412, -789, 118, 668, -72, -732, 858, -39, 373, -19, -991, 919, -603, 373, -783, -546, 969, -451, -208, 824, 245, -647, -587, 311, -715, 868, 181, -574, -546, 396, 700, -187, -963, -710, -495, 608, -634, 585, -814, -214, 654, 65, -499, -259, 310, 738, 131, 650, -731, -603, 400, -625, 455, 340, 6, 58, 797, 806, 382, 60, 86, 431, -493, 977, 280, 196, 882, -894, -133, -392, -912, -616, -637, -995, -831, -820, 852, 672, -999, -454, -263, 530, -843, -944, 996, 324, 357, -303, 283, 447, 810, -441, -798, 126, 699, -777, -443, -476, 460, -887, 856, 24, -217, 660, -691, 16, -988, 450, 170, -174, 206, -875, 805, -165, -678, 556, 273, -549, 980, 956, 838, 185, -177, 420, -202, 529, -819, 236, -695, 946, 622, 328, -789, 887, -310, 712, -253, -503, 746, -20, 311, 907, 526, -543, -759, 684, -246, 367, -197, -857, -50, -894, -457, 504, -725, -330, -799, 362, -139, -220, -166, -224, 144, 223, 204, 877, 914, 917, -855, -390, -192, -225, -296, 0, -356, 931, 658, -635, 179, 113, -225, -187, -567, -839, -4, 515, -216, -294, 612, -980, 511, 384, 635, -35, -855, -465, -238, -697, 253, -637, 770, -163, 222, -807, 334, -826, 401, 543, -140, -657, 11, 835, -817, 747, -995, -979, -658, -18, -773, 688, 93, 208, -696, -876, 98, 423, 140, 738, -146, -892, 169, 355, 112, -184, 343, 937, 591, -760, -173, -179, -887, 240, 846, 268, 8, 676, 201, 888, -40, -876, -808, 779, -925, 564, 270, -438, -468, 97, 94, 910, 33, 662, -311, -249, 174, 656, -278, 367, -597, -933, -571, -898, -845, 405, 574, 852, 361, 35, 116, 421, -778, 252, -222, -271, 915, 389, 280, 547, 546, -219, 405, -506, 145, -84, 787, -550, -449, 94, -906, 351, -47, 834, 484, -108, 694, -910, 623, -331, 990, 417, 200, 497, 980, 673, 688, 781, -116, 959, -165, 785, -624, 175, 821, 621, -338, 935, -43, 239, 617, 123, 300, -733, -59, 764, -532, -612, 767, 886, 35, 825, 765, -390, 557, -872, 581, 908, -487, 472, 227, -994, 566, -408, -741, -691, -25, 778, -987, 862, -770, 759, 132, -616, 51, -134, -884, -67, -445, -785, 204, 300, -987, -3, -76, 9, -981, 765, 617, 692, -960, -246, 421, 485, -989, 611, 556, -292, -993, -368, -211, -311, -625, 905, 656, 275, -307, 381, 558, -310, -989, -352, 352, -702, -733, 927, 992, -431, 668, 249, -710, 209, -840, -680, 822, 475, -662, 647, -628, 440, 309, 408, -75, 923, 426, -485, -75, -892, 341, 648, -684, -363, -794, -73, 681, 391, 402, 123, 218, -917, 619, -13, 40, -242, -658, 579, -471, -946, -917, -820, -64, 45, 9, -882, 381, -398, 723, 428, -129, 752, 2, 883, 227, -981, -68, 652, 3, 233, -362, -570, -927, 215, -571, -712, 820, -679, -632, -834, 581, 847, 985, -130, -975, 161, -288, 271, 628, -912, 546, 78, 668, 973, -749, 465, 81, 735, 760, 21, 826, -311, -424, 295, 416, 652, -894, 721, -384, -280, -703, 59, -766, 556, 846, 24, 766, -868, 858, -934, 307, 661, -976, -86, 687, 559, -238, -900, -37, -37, 207, -916, -439, 347, -660, -108, 271, -310, 453, -627, 54, -10, -346, -92, 790, -514, -156, -889, -874, 227, 699, -51, 877, 694, 713, -836, -335, 661, 608, 856, -111, -994, -242, 652, 512, -788, -502, -113, 216, -46, 753, 76, -322, 484, 11, -684, 6, 116, 123, 200, -285, -349, 973, 736, 264, -742, -793, -134, 633, -825, -773, 609, 81, 597, 483, 48, -768, 1, 395, 577, 988, 957, -106, 171, 473, -377, -729, -608, -317, 397, 158, 548, -463, -593, 141, -763, -968, 21, -612, 254, -995, 631, 253, 40, -273, -857, 994, 80, -1000, 962, -916, -996, 720, 546, 212, -242, 756, -198, -738, -360, 986, 814, -817, -764, 17, -322, 72, -327, -544, 245, 16, 210, -387, -860, 572, -644, -297, 853, -556, 330, -372, 190, -608, -279, 312, 153, 827, -9, 195, -617, -519, 230, -241, 748, 267, -809, 448, 17, -977, -951, 71, 320, -376, -246, -55, -127, 391, 580, 973, -144, -946, 902, -642, -69, -989, -204, 422, 462, -77, 863, -150, -920, 478, -928, -236, 786, -550, -136, -128, 380, -93, 685, 830, -606, -742, 308, -435, 637, 775, -561, 761, -753, 17, -661, -672, -422, -128, 827, 736, -530, -231, 986, -906, -840, 198, -9, 842, -448, 990, 158, -577, -474, -293, -407, 948, -632, -928, 963, -327, -297, -769, 784, 686, -517, -899, -397, 63, 139, 744, -814, -86, -377, 128, -599, -389, -80, 591, 670, 195, 267, 465, -987, 646, -384, -984, 235, 539, -576, -610, 959, -495, -92, 154, 32, -761, -16, -700, 610, -942, -405, 928, -297, -193, 804, -756, 799, 397, -694, 981, 28, -223, -598, -233, 405, 237, -782, -862, 69, -533, -134, 63, -362, -252, 784, 680, -995, 468, -905, -838, 627, -380, 980, 611, -400, 339, -238, 205, 842, -628, -784, 837, 233, -558, 362, 182, -897, -859, 748, 795, -980, -154, 230, 142, 191, 532, 289, 954, 23, -877, -762, -670, 302, -857, -646, -593, -204, -210, -833, -934, -526, 13, -705, -304, -749, 29, 829, -805, 386, -398, 577, 864, 720, -700, -858, -220, 389, -162, -580, 67, -951, -192, -818, 718, -866, 885, -465, 90, -912, -46, -615, 312, 974 };
            actual = _object.ClosestAdjacent(input);
            Assert.Equal(expected, actual, 5);
            #endregion


        }
        /*
        [Fact]
        public void Median()
        {
            string str;
            int[] n;
            int actual;
            n = new[] { 2, 8, 3, 5, 6, 7, 1, 4, 9 };
            str = n.ToCode();
            actual = _object.Median(n);
            Assert.True(5 == actual, str + " ==> " + n.ToCode());

            n = new[] { 7, 2, 4, 3, 6, 8, 5, 9, 1 };
            str = n.ToCode();
            actual = _object.Median(n);
            Assert.True(5 == actual, str + " ==> " + n.ToCode());

            //n = new[] { 46, 94, 29, 30, 75, 90, 38, 53, 48, 83, 97, 55, 50, 6, 52, 99, 95, 72, 59, 86, 23, 17, 95, 98, 23, 20, 21, 32, 9, 92, 47, 86, 76, 33, 16, 14, 44, 19, 39, 47, 9, 23, 17, 1, 33, 1, 15, 15, 60, 44, 31, 75, 83, 40, 21, 28, 99, 30, 6, 54, 68, 6, 44, 56, 35, 10, 79, 16, 89, 37, 55, 75, 32, 11, 77, 0, 0, 93, 65, 22, 5, 6, 71, 64, 61, 71, 3, 35, 11, 88, 15, 13, 13, 85, 79, 3, 79, 60, 65, 22 };
            str = n.ToCode();
            actual = _object.Median(n);
            Assert.True(5 == actual, str + " ==> " + n.ToCode());
        }
        */
        #region Assertion Helpers
        public void AssertNPZ(int[] expected, int[] actual)
        {
            // Asserting whether the values match (order doesn't matter)
            Assert.Equal(expected.OrderBy(x => x),
                actual.OrderBy(x => x));

            // Asserting whether the patterns match (negatives => positives => zeros)
            Assert.Equal(
                actual.Select(n => n.CompareTo(0)).ToList(),
                expected.Select(n => n.CompareTo(0)).ToList());
        }


        int[] SampleArray()
        {
            return new int[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
        }
        #endregion

    }
}
