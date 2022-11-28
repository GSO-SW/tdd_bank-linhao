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
            int guthaben = 45679876;
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
            int betrag = 5000;
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
            int betrag = 586585;

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

            //Assert.AreEqual(4567890, k.Guthaben);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Konto_KannNichtMitNegativemBetragErstelltWerden()
        {
            // Arrange
            int guthaben = -1;
            // Act
            Konto k = new Konto(guthaben);
        }

        [TestMethod]
        public void KontoNr_KannAbgefragtWerden()
        {
            // Arrange
            Konto k = new Konto(0);
            int nummer_soll = 1;
            // Act
            int nummer_ist = k.KontoNr;
            //Arrange
            Assert.AreEqual(nummer_soll, nummer_ist);
        }

        [TestMethod]
        public void KontoNr_WirdAutomatischVergeben()
        {
            // Arrange
            Konto k1 = new Konto(0);
            Konto k2 = new Konto(0);
            Konto k3 = new Konto(0);
            int kontoNummer_soll = 3;
            // Act
            int kontoNummer_ist = k3.KontoNr;
            // Assert
            Assert.AreEqual(kontoNummer_soll, kontoNummer_ist);
        }

    }

}