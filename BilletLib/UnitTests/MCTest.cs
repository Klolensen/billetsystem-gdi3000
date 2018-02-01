using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class MCTest
    {

        [TestMethod]
        public void BilPris()
        {
            //Arrange
            MC mc = new MC();
            //Act
            int pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris);

        }

        public void BilKøretøj()
        {
            //Arrange
            MC mc = new MC();
            //Act
            string whatthefuckeverbro = mc.Kørertøj();
            //Assert
            Assert.AreEqual("MC", whatthefuckeverbro);

        }


    }
}