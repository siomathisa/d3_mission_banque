using lib_banque;
using System.Security.Cryptography;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuperieur()
        {
            Compte c1 = new Compte(1,"compte_a",500,-250);
            Compte c2 = new Compte(2, "compte_b", 1500, -500);
            string attendu = c2.GetNom;
            string actuel1 = c1.Superieur(c2);
            string actuel2 = c2.Superieur(c1);
            Assert.AreEqual(attendu, actuel1);
            Assert.AreEqual(attendu, actuel2);
        }

        [TestMethod]
        public void TestDebiter()
        {
            Compte c3 = new Compte(3, "compte_c", 500, -250);
            Compte c4 = new Compte(4, "compte_d", 1500, -500);
            float attendu3 = 300;
            float attendu4 = 700;
            c3.Debiter(200);
            c4.Debiter(800);
            float actuel3 = c3.GetSolde;
            float actuel4 = c4.GetSolde;
            Assert.AreEqual(attendu3, actuel3);
            Assert.AreEqual(attendu4, actuel4);

            float attendu5 = 300;
            float attendu6 = 700;
            c3.Debiter(10000);
            c4.Debiter(10000);
            float actuel5 = c3.GetSolde;
            float actuel6 = c4.GetSolde;
            Assert.AreEqual(attendu5, actuel5);
            Assert.AreEqual(attendu6, actuel6);

        }

        [TestMethod]
        public void TestTransferer()
        {
            Compte c5 = new Compte(5, "compte_e", 1000, -500);
            Compte c6 = new Compte(6, "compte_f", 50, -100);
            float attendu7 = 150;
            float attendu8 = 900;
            c5.Transferer(100, c6);
            float actuel7 = c6.GetSolde;
            float actuel8 = c5.GetSolde;
            Assert.AreEqual(attendu7, actuel7);
            Assert.AreEqual(attendu8, actuel8);

            float attendu9 = 150;
            float attendu10 = 900;
            c5.Transferer(10000, c6);
            float actuel9 = c6.GetSolde;
            float actuel10 = c5.GetSolde;
            Assert.AreEqual(attendu9, actuel9);
            Assert.AreEqual(attendu10, actuel10);


        }
    }
}