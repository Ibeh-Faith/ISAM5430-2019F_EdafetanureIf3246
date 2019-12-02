using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Xunit;

namespace ISAM5430.FA19.HW08.Tests
{
    public class Map2Tests
    {
        private Map2 _object;
        public Map2Tests()
        {
            _object = new Map2();
        }

        [Fact]
        [Trait("Category", "Loop")]
        public void Word0()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, int> { { "a", 0 }, { "b", 0 } };
            var actual = _object.Word0(new[] { "a", "b", "a", "b" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "a", 0 }, { "b", 0 }, { "c", 0 } };
            actual = _object.Word0(new[] { "a", "b", "a", "c", "b" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "a", 0 }, { "b", 0 }, { "c", 0 } };
            actual = _object.Word0(new[] { "c", "b", "a" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "c", 0 } };
            actual = _object.Word0(new[] { "c", "c", "c", "c" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int>();
            actual = _object.Word0(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
        });
#endif
        }

        [Fact]
        [Trait("Category", "Loop")]
        public void WordLen()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, int> { { "bb", 2 }, { "a", 1 } };
            var actual = _object.WordLen(new[] { "a", "bb", "a", "bb" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "that", 4 }, { "and", 3 }, { "this", 4 } };
            actual = _object.WordLen(new[] { "this", "and", "that", "and" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "code", 4 }, { "bug", 3 } };
            actual = _object.WordLen(new[] { "code", "code", "code", "bug" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int>();
            actual = _object.WordLen(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "z", 1 } };
            actual = _object.WordLen(new[] { "z" });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
    });
#endif
        }

        [Fact]
        [Trait("Category", "Loop")]
        public void Pairs()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "b", "g" }, { "c", "e" } };
            var actual = _object.Pairs(new[] { "code", "bug" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "m", "n" } };
            actual = _object.Pairs(new[] { "man", "moon", "main" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "g", "d" }, { "m", "n" }, { "n", "t" } };
            actual = _object.Pairs(new[] { "man", "moon", "good", "night" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string>();
            actual = _object.Pairs(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "a" }, { "b", "b" } };
            actual = _object.Pairs(new[] { "a", "b" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "d" }, { "c", "s" } };
            actual = _object.Pairs(new[] { "are", "codes", "and", "cods" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "e" }, { "b", "a" }, { "c", "e" }, { "t", "a" } };
            actual = _object.Pairs(new[] { "apple", "banana", "tea", "coffee" });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Fact]
        [Trait("Category", "Loop")]
        public void WordCount()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, int> { { "a", 2 }, { "b", 2 }, { "c", 1 } };
            var actual = _object.WordCount(new[] { "a", "b", "a", "c", "b" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "a", 1 }, { "b", 1 }, { "c", 1 } };
            actual = _object.WordCount(new[] { "c", "b", "a" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "c", 4 } };
            actual = _object.WordCount(new[] { "c", "c", "c", "c" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int>();
            actual = _object.WordCount(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "", 1 }, { "and", 1 }, { "this", 2 } };
            actual = _object.WordCount(new[] { "this", "and", "this", "" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "x", 2 }, { "X", 1 }, { "y", 1 }, { "Y", 1 } };
            actual = _object.WordCount(new[] { "x", "y", "x", "Y", "X" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "0", 1 }, { "1", 1 }, { "123", 2 } };
            actual = _object.WordCount(new[] { "123", "0", "123", "1" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "a", 4 }, { "b", 5 }, { "d", 3 }, { "e", 1 }, { "f", 1 }, { "one", 1 }, { "x", 2 }, { "z", 2 }, { "two", 2 } };
            actual = _object.WordCount(new[] { "d", "a", "e", "d", "a", "d", "b", "b", "z", "a", "a", "b", "z", "x", "b", "f", "x", "two", "b", "one", "two" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "banana", 2 }, { "apple", 3 }, { "tea", 1 }, { "coffee", 1 } };
            actual = _object.WordCount(new[] { "apple", "banana", "apple", "apple", "tea", "coffee", "banana" });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Fact]
        [Trait("Category", "Loop")]
        public void FirstChar()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "s", "saltsoda" }, { "t", "teatoast" } };
            var actual = _object.FirstChar(new[] { "salt", "tea", "soda", "toast" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "aaaAA" }, { "b", "bb" }, { "c", "cccCC" }, { "d", "d" } };
            actual = _object.FirstChar(new[] { "aa", "bb", "cc", "aAA", "cCC", "d" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string>();
            actual = _object.FirstChar(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "appleaardvark" }, { "b", "bellsbellsbells" }, { "s", "saltsun" }, { "z", "zen" } };
            actual = _object.FirstChar(new[] { "apple", "bells", "salt", "aardvark", "bells", "sun", "zen", "bells" });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Fact]
        [Trait("Category", "Loop")]
        public void WordAppend()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = "a";
            var actual = _object.WordAppend(new[] { "a", "b", "a" });
            Assert.Equal(expected, actual);

            expected = "aa";
            actual = _object.WordAppend(new[] { "a", "b", "a", "c", "a", "d", "a" });
            Assert.Equal(expected, actual);

            expected = "a";
            actual = _object.WordAppend(new[] { "a", "", "a" });
            Assert.Equal(expected, actual);

            expected = "";
            actual = _object.WordAppend(new string[0]);
            Assert.Equal(expected, actual);

            expected = "ba";
            actual = _object.WordAppend(new[] { "a", "b", "b", "a", "a" });
            Assert.Equal(expected, actual);

            expected = "baa";
            actual = _object.WordAppend(new[] { "a", "b", "b", "b", "a", "c", "a", "a" });
            Assert.Equal(expected, actual);

            expected = "baaba";
            actual = _object.WordAppend(new[] { "a", "b", "b", "b", "a", "c", "a", "a", "a", "b", "a" });
            Assert.Equal(expected, actual);

            expected = "andornot";
            actual = _object.WordAppend(new[] { "not", "and", "or", "and", "this", "and", "or", "that", "not" });
            Assert.Equal(expected, actual);

            expected = "";
            actual = _object.WordAppend(new[] { "a", "b", "c" });
            Assert.Equal(expected, actual);

            expected = "thisandthat";
            actual = _object.WordAppend(new[] { "this", "or", "that", "and", "this", "and", "that" });
            Assert.Equal(expected, actual);

            expected = "xxyyzzxx";
            actual = _object.WordAppend(new[] { "xx", "xx", "yy", "xx", "zz", "yy", "zz", "xx" });
            Assert.Equal(expected, actual);
#if !DEBUG
});
#endif
        }

        [Fact]
        [Trait("Category", "Loop")]
        public void WordMultiple()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, bool> { { "a", true }, { "b", true }, { "c", false } };
            var actual = _object.WordMultiple(new[] { "a", "b", "a", "c", "b" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, bool> { { "a", false }, { "b", false }, { "c", false } };
            actual = _object.WordMultiple(new[] { "c", "b", "a" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, bool> { { "c", true } };
            actual = _object.WordMultiple(new[] { "c", "c", "c", "c" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, bool>();
            actual = _object.WordMultiple(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, bool> { { "and", false }, { "this", true } };
            actual = _object.WordMultiple(new[] { "this", "and", "this" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, bool> { { "a", true }, { "b", true }, { "d", true }, { "e", false }, { "x", false }, { "z", true } };
            actual = _object.WordMultiple(new[] { "d", "a", "e", "d", "a", "d", "b", "b", "z", "a", "a", "b", "z", "x" });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Fact]
        [Trait("Category", "Loop")]
        public void AllSwap()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new[] { "ac", "ab" };
            var actual = _object.AllSwap(new[] { "ab", "ac" });
            Assert.Equal(expected, actual);

            expected = new[] { "ay", "by", "cy", "cx", "bx", "ax", "azz", "aaa" };
            actual = _object.AllSwap(new[] { "ax", "bx", "cx", "cy", "by", "ay", "aaa", "azz" });
            Assert.Equal(expected, actual);

            expected = new[] { "ay", "by", "ax", "bx", "aj", "ai", "by", "bx" };
            actual = _object.AllSwap(new[] { "ax", "bx", "ay", "by", "ai", "aj", "bx", "by" });
            Assert.Equal(expected, actual);

            expected = new[] { "ay", "bx", "cy", "ax", "cx", "abb", "aaa" };
            actual = _object.AllSwap(new[] { "ax", "bx", "cx", "ay", "cy", "aaa", "abb" });
            Assert.Equal(expected, actual);

            expected = new[] { "every", "does", "ice", "easy", "it", "eaten" };
            actual = _object.AllSwap(new[] { "easy", "does", "it", "every", "ice", "eaten" });
            Assert.Equal(expected, actual);

            expected = new[] { "lily", "over", "water", "swims", "of", "list", "words", "wait" };
            actual = _object.AllSwap(new[] { "list", "of", "words", "swims", "over", "lily", "water", "wait" });
            Assert.Equal(expected, actual);

            expected = new[] { "42", "8", "16", "15", "23", "4" };
            actual = _object.AllSwap(new[] { "4", "8", "15", "16", "23", "42" });
            Assert.Equal(expected, actual);

            expected = new[] { "aaa" };
            actual = _object.AllSwap(new[] { "aaa" });
            Assert.Equal(expected, actual);

            expected = new string[0];
            actual = _object.AllSwap(new string[0]);
            Assert.Equal(expected, actual);

            expected = new[] { "a", "b", "c", "xx", "yy", "zz" };
            actual = _object.AllSwap(new[] { "a", "b", "c", "xx", "yy", "zz" });
            Assert.Equal(expected, actual);
#if !DEBUG
});
#endif
        }

        [Fact]
        [Trait("Category", "Loop")]
        public void FirstSwap()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new[] { "ac", "ab" };
            var actual = _object.FirstSwap(new[] { "ab", "ac" });
            Assert.Equal(expected, actual);

            expected = new[] { "ay", "by", "cy", "cx", "bx", "ax", "aaa", "azz" };
            actual = _object.FirstSwap(new[] { "ax", "bx", "cx", "cy", "by", "ay", "aaa", "azz" });
            Assert.Equal(expected, actual);

            expected = new[] { "ay", "by", "ax", "bx", "ai", "aj", "bx", "by" };
            actual = _object.FirstSwap(new[] { "ax", "bx", "ay", "by", "ai", "aj", "bx", "by" });
            Assert.Equal(expected, actual);

            expected = new[] { "ay", "bx", "cy", "ax", "cx", "aaa", "abb" };
            actual = _object.FirstSwap(new[] { "ax", "bx", "cx", "ay", "cy", "aaa", "abb" });
            Assert.Equal(expected, actual);

            expected = new[] { "every", "does", "ice", "easy", "it", "eaten" };
            actual = _object.FirstSwap(new[] { "easy", "does", "it", "every", "ice", "eaten" });
            Assert.Equal(expected, actual);

            expected = new[] { "lily", "over", "water", "swims", "of", "list", "words", "wait" };
            actual = _object.FirstSwap(new[] { "list", "of", "words", "swims", "over", "lily", "water", "wait" });
            Assert.Equal(expected, actual);

            expected = new[] { "42", "8", "16", "15", "23", "4" };
            actual = _object.FirstSwap(new[] { "4", "8", "15", "16", "23", "42" });
            Assert.Equal(expected, actual);

            expected = new[] { "aaa" };
            actual = _object.FirstSwap(new[] { "aaa" });
            Assert.Equal(expected, actual);

            expected = new string[0];
            actual = _object.FirstSwap(new string[0]);
            Assert.Equal(expected, actual);

            expected = new[] { "a", "b", "c", "xx", "yy", "zz" };
            actual = _object.FirstSwap(new[] { "a", "b", "c", "xx", "yy", "zz" });
            Assert.Equal(expected, actual);
#if !DEBUG
});
#endif
        }

        [Fact]
        [Trait("Category", "Loop")]
        public void CountUniqueCharacters()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            int expected, actual;

            expected = 0;
            actual = _object.CountUniqueCharacters("");
            Assert.Equal(expected, actual);

            expected = 0;
            actual = _object.CountUniqueCharacters(null);
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.CountUniqueCharacters(" ");
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.CountUniqueCharacters("  ");
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.CountUniqueCharacters("null");
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.CountUniqueCharacters("aaaa");
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.CountUniqueCharacters("zz");
            Assert.Equal(expected, actual);

            expected = 1;
            actual = _object.CountUniqueCharacters("bbb");
            Assert.Equal(expected, actual);

            expected = 2;
            actual = _object.CountUniqueCharacters("babb");
            Assert.Equal(expected, actual);

            expected = 3;
            actual = _object.CountUniqueCharacters("cacbc");
            Assert.Equal(expected, actual);

            expected = 4;
            actual = _object.CountUniqueCharacters("abccccd");
            Assert.Equal(expected, actual);

            expected = 6;
            actual = _object.CountUniqueCharacters("AFKPUZFKPUZKPUZPUZUZZ");
            Assert.Equal(expected, actual);

            expected = 10;
            actual = _object.CountUniqueCharacters("0123456789123456789234567893456789456789567896789789899");
            Assert.Equal(expected, actual);

            expected = 26;
            actual = _object.CountUniqueCharacters("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxabcdefghijklmnopqrstuvwabcdefghijklmnopqrstuvabcdefghijklmnopqrstuabcdefghijklmnopqrstabcdefghijklmnopqrsabcdefghijklmnopqrabcdefghijklmnopqabcdefghijklmnopabcdefghijklmnoabcdefghijklmnabcdefghijklmabcdefghijklabcdefghijkabcdefghijabcdefghiabcdefghabcdefgabcdefabcdeabcdabcaba");
            Assert.Equal(expected, actual);

            expected = '~' - '!'; // 93
            actual = _object.CountUniqueCharacters(@"7.3:;M,{p;4kQ@8Cvi)FQ|mgtQ(<(|kqqm]l7WHSqyo)ArR}EJi8x\'8?JChFmsqNAxb`J,?BSRV.dG""|)u\4Sw5fEMj5].$'{Y}wn=y>JtE*O+Y#Bj=v7]xHdy<z?+cFNP0,H(/iy?h]S,8:rhqqn,m>^U4s""}|@2|Y}yMY:[R{vs<sYb""(U8oUCaoKpr9hzAHLTP8?E/W6=.tHB`Y1}uG)@G6=*#gECh""VLn@)Ja`G^Z95jH)1:(h%w?,-:y6CF3qS-?zRAPe=6!Id/""P`wV,;}z\-b3mNL>!Lfd(KKUnhALlvtF|9JSIm'WS1`mm.`8ov}{{Hw%5CfBwR/d7<4U%vr2E01ui\e`()[tvwIT@E?''c]""#zWRw,4v%lVk7"":V[':ot8k=q^6]Wk+`Q0sm%4fzsbp+A\>>,fJ!Il+h/:_:tT?7bt;(,JRH>>y3Faz6AuRoB*7b%,^iSL&?CYFKA62_5""`+pvCL>Iw|#NrX]V#!jfro8Zmj;Pr+dqZ@G-p-f2K*S(=rekkh31rL.op7)V2lUm9/rS2Qdt8Y<i=1=x&Mb+uS|.3V:Y$0!]Sdl.!2Z;$<v:1BR_w/Qb*Kud1d@Y7+q)X\7VC/wqqH'YZb{n$X`r]<T(m){;p""$vIn_S,y=h5^o_D<*LgOU\I|I<(/g;2]!oE.1i$Hc)<v^|KsaQ|ORAKENJECK{3#VV]}:7+?I?jMAP?Ko3K6=`,^E!]eD^zfs9@)@LYKG]&4U{${+xR9PzdtJ}X:WDxiB$W)17,CW!m]Zv)Hz`[J,b6wSJ\@q?q#c;oQEykqm/_P-(:Rt1>ugN^^l]SeYiP9-kw@'U#!sg[z#dkL0*I`""z:5[2ceF&9$]GD@.xL@/=#!qa[)o(UP@m80Qccrp;YmNW=Y@L?6[*Rbw:AwT[t?Ngbm04lI5XMqb3P;E#fDf@r7<S68Bi>5E:@esMJ-^s!$Z_!eg'SRsPW/rKRZ{U'J:9LIqiFuWZcp?nZZSON<7j@ra1");
            Assert.Equal(expected, actual);
#if !DEBUG
        });
#endif
        }
    }
}
