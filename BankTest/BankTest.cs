using Bank;

namespace BankTest
{
    [TestClass]
    public class KontoTest
    {
        [TestMethod]
        public void Konto_Erstellt_Neues_Konto_Objekt_mit_Startguthaben()
        {
            //ARRANGE
            Random r = new Random();
            int guthaben = r.Next(300,6000);
            //ACT
            Konto k = new Konto(guthaben);
            //ASSERT
            Assert.AreEqual(guthaben, k.Guthaben);
            Assert.AreEqual(false, (k.Guthaben < 0));
        }

        [TestMethod]
        public void Auszahlen_Alle_Guthaben_Auszahlen()
        {
            //arrange


            Konto k = new Konto(6000);
            Random r = new Random();
            int betrag = r.Next(300,6000);
            // act
            k.Auszahlen(betrag);

            //assert
            Assert.AreEqual((6000-betrag), k.Guthaben);
        }
        [TestMethod]
        public void Einzahlen_Guthaben_Einzahlen()
        {
            //arrange
            Konto k = new Konto(0);
            Random r = new Random();
            int betrag = r.Next(300, 6000);

            //act

            k.Einzahlen(betrag);

            //assert
            Assert.AreEqual(betrag, k.Guthaben);
        }
    }

}