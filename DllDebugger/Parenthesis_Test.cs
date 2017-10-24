using EGifter_ParenthesisExtension;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EGifter_Parenthesis.Tests
{
    [TestFixture]
    public class Parenthesis_Test
    {
        private string[] values = new string[] { "()()()()", "((45+)*a3)", "(((())())", ")(" };
        [TestCase]
        public void TestValues()
        {
            List<bool> results = new List<bool>();
            foreach (var val in values)
                results.Add(val.IsClosed());
            Assert.AreEqual(new bool[] { true, false, false, false }, results.ToArray());
        }
    }
}
