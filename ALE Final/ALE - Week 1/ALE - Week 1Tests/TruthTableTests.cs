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
    public class TruthTableTests
    {
        // SIMPLIFIED

        [TestMethod]
        public void TruthTableSimplifiedTautology()
        {
            string input = ">(&(a,b),&(a,b))";

            Service check = new Service();
            check.Proposition(input);
            var truthTable = check.GetSimplifiedTableService();

            Assert.AreEqual(1, truthTable.TableRows.Count);
            Assert.AreEqual("((a&b)>(a&b))", truthTable.Description.Last());
            Assert.AreEqual("*", truthTable.TableRows[0].OutputValues[0]);
            Assert.AreEqual("*", truthTable.TableRows[0].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[0].FinalResult);
        }

        [TestMethod]
        public void TruthTableSimplifiedNormalProposition()
        {
            string input = "=(>(a,b),c)";

            Service check = new Service();
            check.Proposition(input);
            var truthTable = check.GetSimplifiedTableService();

            Assert.AreEqual(6, truthTable.TableRows.Count);
            Assert.AreEqual("((a>b)=c)", truthTable.Description.Last());

            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[1]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[2]);
            Assert.AreEqual("0", truthTable.TableRows[0].FinalResult);

            Assert.AreEqual("0", truthTable.TableRows[1].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[1].OutputValues[1]);
            Assert.AreEqual("0", truthTable.TableRows[1].OutputValues[2]);
            Assert.AreEqual("0", truthTable.TableRows[1].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[2].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[2].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[2].OutputValues[2]);
            Assert.AreEqual("0", truthTable.TableRows[2].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[3].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[3].OutputValues[1]);
            Assert.AreEqual("0", truthTable.TableRows[3].OutputValues[2]);
            Assert.AreEqual("0", truthTable.TableRows[3].FinalResult);

            Assert.AreEqual("0", truthTable.TableRows[4].OutputValues[0]);
            Assert.AreEqual("*", truthTable.TableRows[4].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[4].OutputValues[2]);
            Assert.AreEqual("1", truthTable.TableRows[4].FinalResult);

            Assert.AreEqual("*", truthTable.TableRows[5].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[5].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[5].OutputValues[2]);
            Assert.AreEqual("1", truthTable.TableRows[5].FinalResult);
        }

        [TestMethod]
        public void TruthTableSimplifiedSimpleProposition()
        {
            string input = ">(a,b)";

            Service check = new Service();
            check.Proposition(input);
            var truthTable = check.GetSimplifiedTableService();

            Assert.AreEqual(3, truthTable.TableRows.Count);
            Assert.AreEqual("(a>b)", truthTable.Description.Last());

            Assert.AreEqual("1", truthTable.TableRows[0].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[1]);
            Assert.AreEqual("0", truthTable.TableRows[0].FinalResult);

            Assert.AreEqual("0", truthTable.TableRows[1].OutputValues[0]);
            Assert.AreEqual("*", truthTable.TableRows[1].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[1].FinalResult);

            Assert.AreEqual("*", truthTable.TableRows[2].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[2].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[2].FinalResult);
        }

        [TestMethod]
        public void TruthTableSimplifiedBigProposition()
        {
            string input = "=(&(~(b), a),|(=(c,d),>(e,f)))";

            Service check = new Service();
            check.Proposition(input);
            var truthTable = check.GetSimplifiedTableService();

            Assert.AreEqual(58, truthTable.TableRows.Count);
            Assert.AreEqual("((~(b)&a)=((c=d)|(e>f)))", truthTable.Description.Last());

            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[1]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[2]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[3]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[4]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[5]);
            Assert.AreEqual("0", truthTable.TableRows[0].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[53].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[53].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[53].OutputValues[2]);
            Assert.AreEqual("*", truthTable.TableRows[53].OutputValues[3]);
            Assert.AreEqual("0", truthTable.TableRows[53].OutputValues[4]);
            Assert.AreEqual("0", truthTable.TableRows[53].OutputValues[5]);
            Assert.AreEqual("1", truthTable.TableRows[53].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[57].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[57].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[57].OutputValues[2]);
            Assert.AreEqual("1", truthTable.TableRows[57].OutputValues[3]);
            Assert.AreEqual("1", truthTable.TableRows[57].OutputValues[4]);
            Assert.AreEqual("*", truthTable.TableRows[57].OutputValues[5]);
            Assert.AreEqual("1", truthTable.TableRows[57].FinalResult);
        }

        // TRUTH TABLE

        [TestMethod]
        public void TruthTableSimpleProposition()
        {
            string input = "|(a,b)";

            Service check = new Service();
            check.Proposition(input);
            var truthTable = check.GetTableService();

            Assert.AreEqual(4, truthTable.TableRows.Count);
            Assert.AreEqual("(a|b)", truthTable.Description.Last());

            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[1]);
            Assert.AreEqual("0", truthTable.TableRows[0].FinalResult);

            Assert.AreEqual("0", truthTable.TableRows[1].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[1].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[1].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[2].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[2].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[2].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[3].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[3].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[3].FinalResult);
        }


        [TestMethod]
        public void TruthTableBigProposition()
        {
            string input = "=(&(~(b), a),|(=(c,d),>(e,f)))";

            Service check = new Service();
            check.Proposition(input);
            var truthTable = check.GetTableService();

            Assert.AreEqual(64, truthTable.TableRows.Count);
            Assert.AreEqual("((~(b)&a)=((c=d)|(e>f)))", truthTable.Description.Last());

            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[1]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[2]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[3]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[4]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[5]);
            Assert.AreEqual("0", truthTable.TableRows[0].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[62].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[62].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[62].OutputValues[2]);
            Assert.AreEqual("1", truthTable.TableRows[62].OutputValues[3]);
            Assert.AreEqual("1", truthTable.TableRows[62].OutputValues[4]);
            Assert.AreEqual("0", truthTable.TableRows[62].OutputValues[5]);
            Assert.AreEqual("0", truthTable.TableRows[62].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[63].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[63].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[63].OutputValues[2]);
            Assert.AreEqual("1", truthTable.TableRows[63].OutputValues[3]);
            Assert.AreEqual("1", truthTable.TableRows[63].OutputValues[4]);
            Assert.AreEqual("1", truthTable.TableRows[63].OutputValues[5]);
            Assert.AreEqual("0", truthTable.TableRows[63].FinalResult);
        }

        [TestMethod]
        public void TruthTableTatology()
        {
            string input = ">(&(a,b),&(a,b))";

            Service check = new Service();
            check.Proposition(input);
            var truthTable = check.GetTableService();

            Assert.AreEqual(4, truthTable.TableRows.Count);
            Assert.AreEqual("((a&b)>(a&b))", truthTable.Description.Last());

            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[0].FinalResult);

            Assert.AreEqual("0", truthTable.TableRows[1].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[1].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[1].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[2].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[2].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[2].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[3].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[3].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[3].FinalResult);
        }

        [TestMethod]
        public void TruthTableNormalProposition()
        {
            string input = "=(>(a,b),c)";

            Service check = new Service();
            check.Proposition(input);
            var truthTable = check.GetTableService();

            Assert.AreEqual(8, truthTable.TableRows.Count);
            Assert.AreEqual("((a>b)=c)", truthTable.Description.Last());

            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[1]);
            Assert.AreEqual("0", truthTable.TableRows[0].OutputValues[2]);
            Assert.AreEqual("0", truthTable.TableRows[0].FinalResult);

            Assert.AreEqual("0", truthTable.TableRows[1].OutputValues[0]);
            Assert.AreEqual("0", truthTable.TableRows[1].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[1].OutputValues[2]);
            Assert.AreEqual("1", truthTable.TableRows[1].FinalResult);

            Assert.AreEqual("0", truthTable.TableRows[2].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[2].OutputValues[1]);
            Assert.AreEqual("0", truthTable.TableRows[2].OutputValues[2]);
            Assert.AreEqual("0", truthTable.TableRows[2].FinalResult);

            Assert.AreEqual("0", truthTable.TableRows[3].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[3].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[3].OutputValues[2]);
            Assert.AreEqual("1", truthTable.TableRows[3].FinalResult);

            Assert.AreEqual("1", truthTable.TableRows[7].OutputValues[0]);
            Assert.AreEqual("1", truthTable.TableRows[7].OutputValues[1]);
            Assert.AreEqual("1", truthTable.TableRows[7].OutputValues[2]);
            Assert.AreEqual("1", truthTable.TableRows[7].FinalResult);
        }
    }
}