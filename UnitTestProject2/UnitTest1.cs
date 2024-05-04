using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewTypographer;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string inputText = "   Тестовая строка   ";
            string outputText = "Тестовая строка";
            Form1 form = new Form1();
            string test1 = form.RemoveExtraSpaces(inputText);
            Assert.AreEqual(outputText, test1, "RemoveExtraSpaces is not correct");
        }
        public void TestMethod2()
        {
            string inputText = "Тестовая строка +-";
            string outputText = "Тестовая строка ±";
            Form1 form = new Form1();
            string test1 = form.ReplaceSymbols(inputText);
            Assert.AreEqual(outputText, test1, "Replace Symbols is not correct");
        }
        public void TestMethod3()
        {
            string inputText = "Тестовая строка...";
            string outputText = "Тестовая строка…";
            Form1 form = new Form1();
            string test1 = form.ReplaceThreeDotsWithEllipsis(inputText);
            Assert.AreEqual(outputText, test1, "ReplaceThreeDotsWithEllipsis is not correct");
        }
        public void TestMethod4()
        {
            string inputText = "5 - 4=1";
            string outputText = "5 - 4 = 1";
            Form1 form = new Form1();
            string test1 = form.MathSignsEqual(inputText);
            Assert.AreEqual(outputText, test1, "MathSignsEgual is not correct");
        }
        public void TestMethod5()
        {
            string inputText = "Сороквашина Ю.А. ";
            string outputText = "Сороквашина Ю. А.";
            Form1 form = new Form1();
            string test1 = form.ReplacePoint(inputText);
            Assert.AreEqual(outputText, test1, "ReplacePoint is not correct");
        }
        public void TestMethod6()
        {
            string inputText = "09.08.2005";
            string outputText = "09.08.2005";
            Form1 form = new Form1();
            string test1 = form.ReplacePoint(inputText);
            Assert.AreEqual(outputText, test1, "ReplacePoint is not correct");
        }
        public void TestMethod7()
        {
            string inputText = "Сороквашина Ю.А. ";
            string outputText = "Сороквашина Ю. А.";
            Form1 form = new Form1();
            string test1 = form.ReplacePoint(inputText);
            Assert.AreEqual(outputText, test1, "ReplacePoint is not correct");
        }
        public void TestMethod8()
        {
            string inputText = "метод,добавляющий пробелы ";
            string outputText = "метод, добавляющий пробелы";
            Form1 form = new Form1();
            string test1 = form.ReplacePoint(inputText);
            Assert.AreEqual(outputText, test1, "ReplacePoint is not correct");
        }
        public void TestMethod9()
        {
            string inputText = "1234,5678 ";
            string outputText = "1234,5678";
            Form1 form = new Form1();
            string test1 = form.ReplacePoint(inputText);
            Assert.AreEqual(outputText, test1, "ReplacePoint is not correct");
        }
        public void TestMethod10()
        {
            string inputText = "1234. 5678 ";
            string outputText = "1234.5678";
            Form1 form = new Form1();
            string test1 = form.RemoveSpaceAroundDot(inputText);
            Assert.AreEqual(outputText, test1, "RemoveSpaceAroundDot is not correct");
        }
        public void TestMethod11()
        {
            string inputText = "1234, 5678 ";
            string outputText = "1234,5678";
            Form1 form = new Form1();
            string test1 = form.RemoveSpaceAroundComma(inputText);
            Assert.AreEqual(outputText, test1, "RemoveSpaceAroundComma is not correct");
        }
    }
}
