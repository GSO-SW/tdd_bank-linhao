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
        public void Auszahlen_Guthaben_Auszahlen()
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

        [TestMethod]
        public void Aufloesen_Guthaben_komplett_auszahlen_Konto_schließen()
        {
            //ARRANGE
            Konto k = new Konto(435978);

            //ACT

            k.Aufloesen();

            //ASSERT

            Assert.AreEqual(0, k.Guthaben);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Auszahlen_Guthaben_auszahlen_mehr_als_hat_ErzeugtAusnahme()
        {
            //ARRANGE

            Konto k = new Konto(4567890);

            //ACT

            k.Auszahlen(k.Guthaben + 1);

            //ASSERT

            Assert.AreEqual(4567890, k.Guthaben);
        }

    }

}