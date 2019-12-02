using System;
using System.IO;
using System.Linq;
using System.Reflection;
using CSharp.Assignments.Tests.Library;
using NUnit.Framework;

namespace CSharp.Assignments.Tests
{
    public class MethodArithmeticTests
    {
        private dynamic _object;
        private TypeAssert _test;
        [SetUp]
        public void Setup()
        {
            _object = new MethodArithmetic();
            _test = new TypeAssert<MethodArithmetic>();
        }

        [Category("Easy")]
        [TestCase(3, 4, ExpectedResult = 5)]
        [TestCase(0.5, 1.2, ExpectedResult = 1.3)]
        [TestCase(.08, .15, ExpectedResult = 0.17)]
        [TestCase(7, 24, ExpectedResult = 25)]
        [TestCase(1.61, 2.40, ExpectedResult = 2.89)]
        [TestCase(.068, .285, ExpectedResult = 0.293)]
        public decimal Hypotenuse(decimal a, decimal b)
        {
            _test.Method<decimal>(
                "Hypotenuse",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<decimal>("a"),
                new Param<decimal>("b")
            );
            decimal c = _object.Hypotenuse(a, b);
            return c;
        }

        [Category("Easy")]
        [TestCase(10, 0, ExpectedResult = true)]
        [TestCase(-10, 0, ExpectedResult = true)]
        [TestCase(0, 0, ExpectedResult = true)]
        [TestCase(-10, -5, ExpectedResult = true)]
        [TestCase(-5, -10, ExpectedResult = false)]
        [TestCase(10, 5, ExpectedResult = true)]
        [TestCase(5, 10, ExpectedResult = false)]
        [TestCase(-7, -49, ExpectedResult = false)]
        [TestCase(-49, 7, ExpectedResult = true)]
        public bool Multiple(int a, int b)
        {
            _test.Method<bool>(
                "Multiple",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("a"),
                new Param<int>("b")
            );
            return _object.Multiple(a, b);
        }

        [Category("Easy")]
        [TestCase(-2, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(8, ExpectedResult = true)]
        [TestCase(-52, ExpectedResult = true)]
        [TestCase(0, ExpectedResult = true)]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(-1, ExpectedResult = false)]
        [TestCase(-3, ExpectedResult = false)]
        [TestCase(3, ExpectedResult = false)]
        [TestCase(111, ExpectedResult = false)]
        [TestCase(-777, ExpectedResult = false)]
        [TestCase(299792458, ExpectedResult = true)]
        public bool IsEven(int n)
        {
            _test.Method<bool>(
                "IsEven",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("n")
            );
            return _object.IsEven(n);
        }

        [Category("Easy")]
        [TestCase(1, 2, 4, ExpectedResult = 2)]
        [TestCase(1, 5, 2, ExpectedResult = 3)]
        [TestCase(-2, -4, -1, ExpectedResult = -2)]
        [TestCase(-5, -1, -2, ExpectedResult = -3)]
        [TestCase(-71, 82, -23, ExpectedResult = -4)]
        [TestCase(-77778, 9552, -23, ExpectedResult = -22750)]
        [TestCase(2_000_000_001, 2_000_000_001, 2_000_000_001, ExpectedResult = 2_000_000_001)]
        [TestCase(2_000_000_001, 2_000_000_001, 2_000_000_000, ExpectedResult = 2_000_000_001)]
        [TestCase(2_000_000_001, 2_000_000_000, 2_000_000_000, ExpectedResult = 2_000_000_000)]
        [TestCase(2_000_000_000, 2_000_000_000, 2_000_000_000, ExpectedResult = 2_000_000_000)]
        [TestCase(-2_000_000_001, -2_000_000_001, -2_000_000_001, ExpectedResult = -2_000_000_001)]
        [TestCase(-2_000_000_001, -2_000_000_001, -2_000_000_000, ExpectedResult = -2_000_000_001)]
        [TestCase(-2_000_000_001, -2_000_000_000, -2_000_000_000, ExpectedResult = -2_000_000_000)]
        [TestCase(-2_000_000_000, -2_000_000_000, -2_000_000_000, ExpectedResult = -2_000_000_000)]
        [TestCase(int.MinValue, int.MinValue, int.MaxValue, ExpectedResult = int.MinValue / 3 - 1)]
        [TestCase(int.MaxValue, int.MaxValue, int.MinValue, ExpectedResult = int.MaxValue / 3)]
        [TestCase(int.MinValue, int.MinValue, int.MinValue, ExpectedResult = int.MinValue)]
        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, ExpectedResult = int.MaxValue)]
        public int RoundThreeAverages(int a, int b, int c)
        {
            _test.Method<int>(
                "RoundThreeAverages",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("a"),
                new Param<int>("b"),
                new Param<int>("c")
            );
            return _object.RoundThreeAverages(a, b, c);
        }

        [Category("Medium")]
        [TestCase(0, 0, '*', ExpectedResult = "")]
        [TestCase(-1, 10, 'X', ExpectedResult = "")]
        [TestCase(10, 0, '-', ExpectedResult = "")]
        [TestCase(1, 10, 'X', ExpectedResult = "XXXXXXXXXX")]
        [TestCase(10, 1, 'x', ExpectedResult = "x\nx\nx\nx\nx\nx\nx\nx\nx\nx")]
        [TestCase(4, 5, '#', ExpectedResult = "#####\n#####\n#####\n#####")]
        [TestCase(4, 2, '*', ExpectedResult = "**\n**\n**\n**")]
        public string DisplayBox(int rows, int columns, char fills)
        {
            _test.Method(
                "DisplayBox",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("row"),
                new Param<int>("column"),
                new Param<char>("fillCharacter")
            );

            string output = ConsoleAssert.Run(() => _object.DisplayBox(rows, columns, fills));
            return output;
        }

        [Category("Medium")]
        [TestCase(1234, ExpectedResult = "1  2  3  4")]
        [TestCase(-4321, ExpectedResult = "-4  3  2  1")]
        [TestCase(0, ExpectedResult = "0")]
        [TestCase(83000, ExpectedResult = "8  3  0  0  0")]
        [TestCase(-83000, ExpectedResult = "-8  3  0  0  0")]
        [TestCase(123456789, ExpectedResult = "1  2  3  4  5  6  7  8  9")]
        [TestCase(2147483647, ExpectedResult = "2  1  4  7  4  8  3  6  4  7")]
        [TestCase(-2147483648, ExpectedResult = "-2  1  4  7  4  8  3  6  4  8")]
        public string DisplayDigits(int n)
        {
            _test.Method(
                "DisplayDigits",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("n")
            );

            string output = ConsoleAssert.Run(() => _object.DisplayDigits(n));
            return output;
        }

        [Category("Medium")]
        [TestCase("2", 3, ExpectedResult = "8")]
        [TestCase("2", -3, ExpectedResult = "0.125")]
        [TestCase("2", 0, ExpectedResult = "1")]
        [TestCase("2", 1, ExpectedResult = "2")]
        [TestCase("2", -1, ExpectedResult = "0.5")]
        [TestCase("13", 13, ExpectedResult = "302875106592253")]
        [TestCase("5", -32, ExpectedResult = "0.00000000000000000000004294967296")]
        [TestCase("23.54", 11, ExpectedResult = "1229903517490157.1123000715495")]
        [TestCase("1.0000000005", 2000000000, ExpectedResult = "2.7182818277794747785573706592", Description = "Test for Efficiency")]
        public string Power(string x, int y)
        {
            _test.Method<decimal>(
                "Power",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<decimal>("x"),
                new Param<int>("y")
            );

            decimal a = decimal.Parse(x);
            decimal p = _object.Power(a, y);
            // special case since a small decimal cannot be converted exactly to a string.
            if (a == 5m && y == -32)
            {
                Assert.AreEqual(0.00000000000000000000004294967296m, p);
                return "0.00000000000000000000004294967296";
            }
            return p.ToString();
        }

        [Category("Easy")]
        [TestCase(4, 3, 5, ExpectedResult = 3)]
        [TestCase(2, 4, 3, ExpectedResult = 2)]
        [TestCase(-1, -7, -10, ExpectedResult = -10)]
        [TestCase(0, 0, 1, ExpectedResult = 0)]
        [TestCase(0, 0, -1, ExpectedResult = -1)]

        public int Minimum3(int a, int b, int c)
        {
            _test.Method<int>(
                "Minimum3",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("a"),
                new Param<int>("b"),
                new Param<int>("c")
            );
            int min = _object.Minimum3(a, b, c);
            return min;
        }

        [Category("Medium")]
        [TestCase(null, ExpectedResult = true)]
        [TestCase(0, ExpectedResult = false)]
        [TestCase(33550336, ExpectedResult = true)]
        public bool PerfectNumber(int? num)
        {
            _test.Method<bool>(
                "PerfectNumber",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("n")
            );

            if (num == null)
            {
                for (int i = 2; i <= 10000; i++)
                {
                    bool expected = i == 6 || i == 28 || i == 496 || i == 8128;
                    Assert.AreEqual(expected, _object.PerfectNumber(i));
                }
                return true;
            }
            return _object.PerfectNumber(num.Value);
        }

        [Category("Medium")]
        [TestCase(null, ExpectedResult = true)]
        [TestCase(9973, ExpectedResult = true)]
        [TestCase(9971, ExpectedResult = false)]
        [TestCase(9719, ExpectedResult = true)]
        [TestCase(9721, ExpectedResult = true)]
        [TestCase(8821, ExpectedResult = true)]
        [TestCase(8823, ExpectedResult = false)]
        public bool IsPrime(int? num)
        {
            _test.Method<bool>(
                "IsPrime",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("n")
            );

            if (num == null)
            {
                int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 };
                for (int i = -101; i <= 101; i++)
                {
                    bool expected = primes.Contains(i < 0 ? -i : i);
                    Assert.AreEqual(expected, _object.IsPrime(i));
                }
                return true;
            }
            bool p = _object.IsPrime(num.Value);
            return p;
        }

        [Category("Medium")]
        [TestCase(0, ExpectedResult = "0")]
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(1234567890, ExpectedResult = "100101101000000011010011001001")]
        [TestCase(123, ExpectedResult = "1101111")]
        [TestCase(1072, ExpectedResult = "1100001")]
        [TestCase(64, ExpectedResult = "1")]
        [TestCase(16777216, ExpectedResult = "1")]
        [TestCase(1073741824, ExpectedResult = "1")]
        public string ReverseBits(int n)
        {
            _test.Method<string>(
                "ReverseBits",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("n")
            );

            string bits = _object.ReverseBits(n);
            return bits;
        }


        [Category("Medium")]
        [TestCase(37, 0, ExpectedResult = 37)]
        [TestCase(0, 1234567890, ExpectedResult = 1234567890)]
        [TestCase(68, 26, ExpectedResult = 2)]
        [TestCase(-78, -26, ExpectedResult = 26)]
        [TestCase(91, -26, ExpectedResult = 13)]
        [TestCase(-12345, 567890, ExpectedResult = 5)]
        [TestCase(7777, -1111, ExpectedResult = 1111)]
        [TestCase(7777, 11111, ExpectedResult = 1)]
        [TestCase(997, 853, ExpectedResult = 1)]
        public int Gcd(int a, int b)
        {
            _test.Method<int>(
                "Gcd",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("a"),
                new Param<int>("b")
            );

            int gcd = _object.Gcd(a, b);
            return gcd;
        }

        [Category("Medium")]
        [TestCase(2, 3, ExpectedResult = 6)]
        [TestCase(4, 6, ExpectedResult = 12)]
        [TestCase(88, 22, ExpectedResult = 88)]
        [TestCase(7896, 1896, ExpectedResult = 623784)]
        [TestCase(2425, -8215, ExpectedResult = 3984275)]
        [TestCase(-1413, 3491, ExpectedResult = 4932783)]
        [TestCase(-1748, -2732, ExpectedResult = 1193884)]
        public long Lcm(int a, int b)
        {
            _test.Method<long>(
                "Lcm",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("a"),
                new Param<int>("b")
            );

            long lcm = _object.Lcm(a, b);
            return lcm;
        }
        [Category("Medium")]
        [TestCase(null, ExpectedResult = new[] { "0-59", "F" })]
        [TestCase(60, ExpectedResult = new[] { "0.6666666666666666666666666667", "D-" })]
        [TestCase(61, ExpectedResult = new[] { "0.6666666666666666666666666667", "D-" })]
        [TestCase(62, ExpectedResult = new[] { "0.6666666666666666666666666667", "D-" })]
        [TestCase(63, ExpectedResult = new[] { "0.6666666666666666666666666667", "D-" })]
        [TestCase(64, ExpectedResult = new[] { "1", "D" })]
        [TestCase(65, ExpectedResult = new[] { "1", "D" })]
        [TestCase(66, ExpectedResult = new[] { "1", "D" })]
        [TestCase(67, ExpectedResult = new[] { "1.3333333333333333333333333333", "D+" })]
        [TestCase(68, ExpectedResult = new[] { "1.3333333333333333333333333333", "D+" })]
        [TestCase(69, ExpectedResult = new[] { "1.3333333333333333333333333333", "D+" })]
        [TestCase(70, ExpectedResult = new[] { "1.6666666666666666666666666667", "C-" })]
        [TestCase(71, ExpectedResult = new[] { "1.6666666666666666666666666667", "C-" })]
        [TestCase(72, ExpectedResult = new[] { "1.6666666666666666666666666667", "C-" })]
        [TestCase(73, ExpectedResult = new[] { "1.6666666666666666666666666667", "C-" })]
        [TestCase(74, ExpectedResult = new[] { "2", "C" })]
        [TestCase(75, ExpectedResult = new[] { "2", "C" })]
        [TestCase(76, ExpectedResult = new[] { "2", "C" })]
        [TestCase(77, ExpectedResult = new[] { "2.3333333333333333333333333333", "C+" })]
        [TestCase(78, ExpectedResult = new[] { "2.3333333333333333333333333333", "C+" })]
        [TestCase(79, ExpectedResult = new[] { "2.3333333333333333333333333333", "C+" })]
        [TestCase(80, ExpectedResult = new[] { "2.6666666666666666666666666667", "B-" })]
        [TestCase(81, ExpectedResult = new[] { "2.6666666666666666666666666667", "B-" })]
        [TestCase(82, ExpectedResult = new[] { "2.6666666666666666666666666667", "B-" })]
        [TestCase(83, ExpectedResult = new[] { "2.6666666666666666666666666667", "B-" })]
        [TestCase(84, ExpectedResult = new[] { "3", "B" })]
        [TestCase(85, ExpectedResult = new[] { "3", "B" })]
        [TestCase(86, ExpectedResult = new[] { "3", "B" })]
        [TestCase(87, ExpectedResult = new[] { "3.3333333333333333333333333333", "B+" })]
        [TestCase(88, ExpectedResult = new[] { "3.3333333333333333333333333333", "B+" })]
        [TestCase(89, ExpectedResult = new[] { "3.3333333333333333333333333333", "B+" })]
        [TestCase(90, ExpectedResult = new[] { "3.6666666666666666666666666667", "A-" })]
        [TestCase(91, ExpectedResult = new[] { "3.6666666666666666666666666667", "A-" })]
        [TestCase(92, ExpectedResult = new[] { "3.6666666666666666666666666667", "A-" })]
        [TestCase(93, ExpectedResult = new[] { "3.6666666666666666666666666667", "A-" })]
        [TestCase(94, ExpectedResult = new[] { "4", "A" })]
        [TestCase(95, ExpectedResult = new[] { "4", "A" })]
        [TestCase(96, ExpectedResult = new[] { "4", "A" })]
        [TestCase(97, ExpectedResult = new[] { "4", "A" })]
        [TestCase(98, ExpectedResult = new[] { "4", "A" })]
        [TestCase(99, ExpectedResult = new[] { "4", "A" })]
        [TestCase(100, ExpectedResult = new[] { "4", "A" })]
        public string[] Gpa(int? score)
        {
            _test.Method<decimal>(
                "Gpa",
                BindingFlags.Public | BindingFlags.Instance,
                new Param<int>("score"),
                new Param<string>("letterGrade") { Out = true }
            );

            string letterGrade;
            decimal gpa;
            if (score == null)
            {
                for (int points = 0; points <= 59; points++)
                {
                    gpa = _object.Gpa(points, out letterGrade);
                    Assert.AreEqual(0m, gpa);
                    Assert.AreEqual("F", letterGrade);
                }
                return new[] { "0-59", "F" };
            }

            gpa = _object.Gpa(score.Value, out letterGrade);
            return new[] { gpa.ToString(), letterGrade };


            /*            string s = "";
                        for (int i = 60; i <= 100; i++)
                        {
                            var gpa = _object.Gpa(i, out letterGrade);
                            //var gpa = (int)(_object.Gpa(i, out letterGrade) * 3 + 0.5m);
                            //string x = gpa/ % 3 == 0 ? gpa / 3 + "m" : gpa + "m/3";
            s += $"[TestCase({i}, ExpectedResult=new[] {{ \"{gpa}\", \"{letterGrade}\"}})]\n";
        }
        Assert.Fail(s);*/

        }
    }
}
