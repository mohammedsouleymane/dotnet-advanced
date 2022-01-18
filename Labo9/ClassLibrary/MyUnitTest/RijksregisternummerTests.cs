using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
namespace MyUnitTest
{
    [TestClass]
    public class RijksregisternummerTests
    {
        [TestMethod]
        [DataRow(2001, 07, 10, Gender.Male, 453, "01071045325")]
        [DataRow(1990, 10, 07, Gender.Male, 453, "90100745336")]
        [DataRow(1990, 10, 07, Gender.Male, 452, "90100745336")]
        [DataRow(1990, 10, 07, Gender.Female, 452, "90100745237")]
        public void GenerateRRnr(int year, int month, int day, Gender gender, int daynr,string rrnr)
        {
            var rrn = new Rijksregisternummer(year, month, day, gender, daynr );
            Assert.AreEqual(rrnr, rrn.RRnr);
        }


        [TestMethod]
        [DataRow("01.07.10-453.25", 2001)]
        [DataRow("90.10.07-453.36", 1990)]
        [DataRow("00.10.07-453.18",2000)]
        public void GetYear(string rrnr, int year)
        {
            var rrn = new Rijksregisternummer(rrnr);
            Assert.AreEqual(year, rrn.Jaar);
        }

        [TestMethod]
        [DataRow("01.07.10-453.25",07)]
        [DataRow("05.03.17-453.65",03)]
        public void GetMonth(string rrnr, int month)
        {
            var rrn = new Rijksregisternummer(rrnr);
            Assert.AreEqual(month, rrn.Maand);
        }
    }
}
