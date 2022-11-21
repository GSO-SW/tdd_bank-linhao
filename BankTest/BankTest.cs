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
        }
    }
}