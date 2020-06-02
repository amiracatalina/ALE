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
    public class ServiceTests
    {
        [TestMethod]
        public void GetVariablesTest()
        {
            string input = "=(&(~(b), a),|(=(c,d),>(e,f)))";
            Proposition check = new Proposition(input);
            Assert.AreEqual(6, check.GetVariables().Count());
        }

        [TestMethod]
        public void HexTest()
        {
            string input = "&(a,b)";
            string output = "08";

            Service check = new Service();
            check.Proposition(input);
            var truthTableHex = check.TruthTableHexService();

            Assert.AreEqual(output, truthTableHex);
        }

        [TestMethod]
        public void NormalizedTest()
        {
            string input = "=(>(a,b),c)";
            string output = "(~(a)&~(b)&c) | (~(a)&b&c) | (a&~(b)&~(c)) | (a&b&c)";

            Service check = new Service();
            check.Proposition(input);
            var normalized = check.GetNormalizedService();

            Assert.AreEqual(output, normalized);
        }

        [TestMethod]
        public void NormalizedPrefixTest()
        {
            string input = "=(>(a,b),c)";
            string output = "|(|(|(&(&(~(a), ~(b)), c), &(&(~(a), b), c)), &(&(a, ~(b)), ~(c))), &(&(a, b), c))";

            Service check = new Service();
            check.Proposition(input);
            var normalizedPrefix = check.GetNomarlizedPrefixService();

            Assert.AreEqual(output, normalizedPrefix);
        }

        [TestMethod]
        public void NormalizedSimplifiedTest()
        {
            string input = "=(>(a,b),c)";
            string output = "(~(a)&c) | (b&c)";

            Service check = new Service();
            check.Proposition(input);
            var normalizedSimplified = check.GetNormalizedSimplifiedService();

            Assert.AreEqual(output, normalizedSimplified);
        }

        [TestMethod]
        public void NandifyNormalPropositionTest()
        {
            string input = "|(|(a,b),c)";
            string output = "%(%(%(%(a, a), %(b, b)), %(%(a, a), %(b, b))), %(c, c))";

            Service check = new Service();
            check.Proposition(input);
            string nandify = check.GetNandifyService();
            Assert.AreEqual(output, nandify);
        }

        [TestMethod]
        public void NandifyNegationTest()
        {
            string input = "~(a)";
            string output = "%(a, a)";

            Service check = new Service();
            check.Proposition(input);
            string nandify = check.GetNandifyService();
            Assert.AreEqual(output, nandify);
        }

        [TestMethod]
        public void NandifyBigPropositionTest()
        {
            string input = "=(&(~(b), a),|(=(c,d),>(e,f)))";
            string output = "%(%(%(%(%(%(b, b), a), %(%(b, b), a)), %(%(%(b, b), a), %(%(b, b), a))), %(%(%(%(%(%(c, c), %(d, d)), " +
                "%(c, d)), %(%(%(c, c), %(d, d)), %(c, d))), %(%(e, %(f, f)), %(e, %(f, f)))), %(%(%(%(%(c, c), %(d, d)), %(c, d)), " +
                "%(%(%(c, c), %(d, d)), %(c, d))), %(%(e, %(f, f)), %(e, %(f, f)))))), %(%(%(%(b, b), a), %(%(b, b), a)), %(%(%(%(%(c, c), " +
                "%(d, d)), %(c, d)), %(%(%(c, c), %(d, d)), %(c, d))), %(%(e, %(f, f)), %(e, %(f, f))))))";

            Service check = new Service();
            check.Proposition(input);
            string nandify = check.GetNandifyService();
            Assert.AreEqual(output, nandify);
        }
    }
}