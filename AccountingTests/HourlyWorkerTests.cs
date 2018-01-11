using NUnit.Framework;
using AccountingModel.AccountingTypes;

namespace SalaryTests
{
    [TestFixture]
    public class HourlyWorkerTests
    {
        [TestCase("Алексей", "Волконский", 100, 100, 
            TestName = "Hourly Wage 4 Params Constructor")]
        [Test]
        public void HourlyWageConstructor4Params(string firstname, 
            string surname, double hp, double hw)
        {
            HourlyWorker worker = new HourlyWorker(firstname, surname, hp, hw);
        }

        [TestCase("Алексей", TestName = "Hourly Wage Set Firstname")]
        [Test]
        public void HourlyWageFirstnameSet(string firstname)
        {
            HourlyWorker worker = new HourlyWorker();
            worker.Firstname = firstname;
            Assert.AreEqual(firstname, worker.Firstname);
        }

        [TestCase("Волконский", TestName = "Hourly Wage Set Surname")]
        [Test]
        public void HourlyWageSurnameSet(string surname)
        {
            HourlyWorker worker = new HourlyWorker();
            worker.Surname = surname;
            Assert.AreEqual(surname, worker.Surname);
        }

        [TestCase(50, TestName = "Hourly Wage Set HourPrice")]
        [Test]
        public void HourlyWageHourPriceSet(double hourprice)
        {
            HourlyWorker worker = new HourlyWorker();
            worker.HourPrice = hourprice;
            Assert.AreEqual(hourprice, worker.HourPrice);
        }

        [TestCase(200, TestName = "Hourly Wage Set HoursWorked")]
        [Test]
        public void HourlyWageHoursWorkedSet(double hourworked)
        {
            HourlyWorker worker = new HourlyWorker();
            worker.HoursWorked = hourworked;
            Assert.AreEqual(hourworked, worker.HoursWorked);
        }

        [TestCase(-1, TestName = "(Negative) Hourly Wage Set HourseWorked")]
        [Test]
        public void NegativeHourlyWageHoursWorkedSet(double hours)
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                HourlyWorker worker = new HourlyWorker();
                worker.HoursWorked = hours;
            });
        }

        [TestCase(-1, TestName = "(Negative) Hourly Wage Set HourPrice")]
        [Test]
        public void NegativeHourlyWageHourPriceSet(double hourprice)
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                HourlyWorker worker = new HourlyWorker();
                worker.HourPrice = hourprice;
            });
        }

        [TestCase("Алексей", TestName = "Hourly Wage Get Firstname")]
        [Test]
        public void HourlyWageFirstnameGet(string firstname)
        {
            HourlyWorker worker = new HourlyWorker("Алексей", "Волконский", 100, 100);
            Assert.AreEqual(firstname, worker.Firstname);
        }

        [TestCase("Волконский", TestName = "Hourly Wage Get Surname")]
        [Test]
        public void HourlyWageSurnameGet(string surname)
        {
            HourlyWorker worker = new HourlyWorker("Алексей", "Волконский", 100, 100);
            Assert.AreEqual(surname, worker.Surname);
        }

        [TestCase(100, TestName = "Hourly Wage Get HourPrice")]
        [Test]
        public void HourlyWageHourPriceGet(double hourprice)
        {
            HourlyWorker worker = new HourlyWorker("Алексей", "Волконский", 100, 100);
            Assert.AreEqual(hourprice, worker.HourPrice);
        }

        [TestCase(200, TestName = "Hourly Wage Get HoursWorked")]
        [Test]
        public void HourlyWageHoursWorkedGet(double hourworked)
        {
            HourlyWorker worker = new HourlyWorker("Алексей", "Волконский", 100, 200);
            Assert.AreEqual(hourworked, worker.HoursWorked);
        }
    }
}
