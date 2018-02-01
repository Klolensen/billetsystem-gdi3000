using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class BilTest
    {

        [TestMethod]
        public void BilPris()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(240, pris);

        }

        [TestMethod]
        public void BilKøretøj()
        {
            //Arrange
            Bil Bil = new Bil();
            //Act
            string whatthefuckeverbro = Bil.Kørertøj();
            //Assert
            Assert.AreEqual("Bil", whatthefuckeverbro);
        }

        [TestMethod]
        public void BilNummerPlade()
        {
            Bil Bil = new Bil();

            Bil.Nummerplade = "HøjereTaxonomiskVærdi";

            string nummerplade = Bil.Nummerplade;

            Assert.Fail(nummerplade);

        }

        [TestMethod]
        public void BilRabat()
        {
            Bil bil = new Bil();
            
           int rabat = bil.PrisMedRabat();

            Assert.AreEqual(228,rabat);
            
        }

        [TestMethod]
        public void BilWeekendRabat()
        {
            Bil bil = new Bil();

            int rabat = bil.PrisMedWeekendRabat();

            Assert.AreEqual(192, rabat);

        }
    }


}