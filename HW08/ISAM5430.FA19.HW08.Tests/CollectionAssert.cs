using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using Xunit;
namespace ISAM5430.FA19.HW08.Tests
{
    public static class CollectionAssert
    {
        public static void AreEquivalent(IEnumerable expected, IEnumerable actual)
        {
            var e = expected.Cast<object>().ToArray();
            var a = expected.Cast<object>().ToArray();
            Array.Sort(e, Comparer.Instance);
            Array.Sort(a, Comparer.Instance);
            Assert.Equal(e, a);
        }

        private class Comparer : IComparer
        {
            public int Compare(object x, object y)
            {
                var a = x as IComparable;
                var b = y as IComparable;
                if (a != null && b != null)
                {
                    return a.CompareTo(b);
                }
                return x.ToString().CompareTo(y.ToString());
            }

            public static readonly IComparer Instance = new Comparer();
        }
    }
}