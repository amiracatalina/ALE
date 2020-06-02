using Microsoft.VisualStudio.TestTools.UnitTesting;
using ALE___Week_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ALE___Week_1.Tests
{
    [TestClass]
    public class PropositionTests
    {
        [TestMethod]
        public void PropositionTestNegation()
        {
            string input = "~(A)";
            string output = "~(A)";
            Proposition check = new Proposition(input);
            Assert.AreEqual(output, check.ToString());
        }

        [TestMethod]
        public void PropositionTestConjunction()
        {
            string input = "&(A,B)";
            string output = "(A&B)";
            Proposition check = new Proposition(input);
            Assert.AreEqual(output, check.ToString());
        }

        [TestMethod]
        public void PropositionTestDisjunction()
        {
            string input = "|(A,B)";
            string output = "(A|B)";
            Proposition check = new Proposition(input);
            Assert.AreEqual(output, check.ToString());
        }

        [TestMethod]
        public void PropositionTestImplication()
        {
            string input = ">(A,B)";
            string output = "(A>B)";
            Proposition check = new Proposition(input);
            Assert.AreEqual(output, check.ToString());
        }

        [TestMethod]
        public void PropositionTestBiimplication()
        {
            string input = "=(A,B)";
            string output = "(A=B)";
            Proposition check = new Proposition(input);
            Assert.AreEqual(output, check.ToString());
        }

        [TestMethod]
        public void PropositionTestNormalProposition()
        {
            string input = "=(A,|(C,B))";
            string output = "(A=(C|B))";
            Proposition check = new Proposition(input);
            Assert.AreEqual(output, check.ToString());
        }


        [TestMethod]
        public void PropositionTestBigProposition()
        {
            string input = "=(&(~(B), A),|(=(C,D),>(E,F)))";
            string output = "((~(B)&A)=((C=D)|(E>F)))";
            Proposition check = new Proposition(input);
            Assert.AreEqual(output, check.ToString());
        }

        [TestMethod]
        public void PropositionTestWithSpaces()
        {
            string input = "=( | (A ,B), &(C ,D))";
            string output = "((A|B)=(C&D))";
            Proposition check = new Proposition(input);
            Assert.AreEqual(output, check.ToString());
        }

        [TestMethod]
        public void PropositionTestErrorWhenWrongOperator()
        {
            string input = "+(A,B)";
            string output = "Ups, you did something wrong!";
            Proposition check = new Proposition(input);
            Assert.AreEqual(output, check.ToString());
        }

        [TestMethod]
        public void PropositionTestErrorWhenEmpty()
        {
            string input = "";
            string output = "Ups, you did something wrong!";
            Proposition check = new Proposition(input);
            Assert.AreEqual(output, check.ToString());
        }
    }
}