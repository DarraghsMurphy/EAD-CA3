using PredictName;
using PredictName.Pages;

namespace PredictonTests
{
    [TestClass]
    public class PredictionTests
    {

        [TestMethod]
        public void TestConvertPercentage()
        {
            Country country = new Country() { Country_Id = "GB", Probability = 0.2420f };
            Assert.AreEqual(country.ConvertToPercentage(0.24f), 24);
        }

        [TestMethod]
        public void TestGetCountry()
        {
            Country country = new Country() { Country_Id = "FR", Probability = 0.811f };
            Assert.AreEqual(country.GetCountry("FR"), "France");
            Assert.AreEqual(country.GetCountry("SE"), "Sweden");
            Assert.AreEqual(country.GetCountry("GR"), "Greece");
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestInvalidCountry()
        {
            Country country = new Country() { Country_Id = "GB", Probability = 0.571f };
            country.GetCountry("AB");
        }
    }
}