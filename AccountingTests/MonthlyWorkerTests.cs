using NUnit.Framework;
using AccountingModel.AccountingTypes;

namespace SalaryTests
{
    [TestFixture]
    public class MonthlyWorkerTests
    {
        [TestCase("Алексей", "Волконский", 10000, 2, 5000, 
            TestName = "Monthly Wage 5 Params Constructor")]
        [Test]
        public void MonthlyWageConstructor5Params(string firstname, string surname, 
            double rew, double rate, double bounty)
        {
            MonthlyWorker worker = 
                new MonthlyWorker(firstname, surname, rew, rate, bounty);
        }

        [TestCase("Алексей", TestName = "Monthly Wage Set Firstname")]
        [Test]
        public void MonthlyWageFirstnameSet(string firstname)
        {
            MonthlyWorker worker = new MonthlyWorker();
            worker.Firstname = firstname;
            Assert.AreEqual(firstname, worker.Firstname);
        }

        [TestCase("Волконский", TestName = "Monthly Wage Set Surname")]
        [Test]
        public void MonthlyWageSurnameSet(string surname)
        {
            MonthlyWorker worker = new MonthlyWorker();
            worker.Surname = surname;
            Assert.AreEqual(surname, worker.Surname);
        }

        [TestCase(10, TestName = "Monthly Wage Set Bounty")]
        [Test]
        public void MonthlyWageBountySet(double bounty)
        {
            MonthlyWorker worker = new MonthlyWorker();
            worker.Bounty = bounty;
            Assert.AreEqual(bounty, worker.Bounty);
        }

        [TestCase(2, TestName = "Monthly Wage Set Rate")]
        [Test]
        public void MonthlyWageRateSet(double rate)
        {
            MonthlyWorker worker = new MonthlyWorker();
            worker.Rate = rate;
            Assert.AreEqual(rate, worker.Rate);
        }

        [TestCase(10000, TestName = "Monthly Wage Set Reward")]
        [Test]
        public void MonthlyWageRewardSet(double rew)
        {
            MonthlyWorker worker = new MonthlyWorker();
            worker.Reward = rew;
            Assert.AreEqual(rew, worker.Reward);
        }

        [TestCase(-1, TestName = "(Negative) Monthly Wage Set Bounty")]
        [Test]
        public void NegativeMonthlyWageBountySet(double bounty)
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                MonthlyWorker worker = new MonthlyWorker();
                worker.Bounty = bounty;
            });
        }

        [TestCase(-1, TestName = "(Negative) Monthly Wage Set Rate")]
        [Test]
        public void NegativeMonthlyWageRateSet(double rate)
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                MonthlyWorker worker = new MonthlyWorker();
                worker.Rate = rate;
            });
        }

        [TestCase(-1, TestName = "(Negative) Monthly Wage Set Reward")]
        [Test]
        public void NegativeMonthlyWageRewardSet(double rew)
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                MonthlyWorker worker = new MonthlyWorker();
                worker.Reward = rew;
            });
        }

        [TestCase(10000, TestName = "Monthly Wage Get Reward")]
        [Test]
        public void MonthlyWageRewardGet(double rew)
        {
            MonthlyWorker worker = 
                new MonthlyWorker("Алексей", "Волконский", 10000, 2, 5000);
            Assert.AreEqual(rew, worker.Reward);
        }

        [TestCase(2, TestName = "Monthly Wage Get Rate")]
        [Test]
        public void MonthlyWageRateGet(double rate)
        {
            MonthlyWorker worker = 
                new MonthlyWorker("Алексей", "Волконский", 10000, 2, 5000);
            Assert.AreEqual(rate, worker.Rate);
        }

        [TestCase(500, TestName = "Monthly Wage Get Bounty")]
        [Test]
        public void MonthlyWageBountyGet(double bounty)
        {
            MonthlyWorker worker = 
                new MonthlyWorker("Алексей", "Волконский", 10000, 2, 500);
            Assert.AreEqual(bounty, worker.Bounty);
        }

        [TestCase("Алексей", TestName = "Monthly Wage Get Firstname")]
        [Test]
        public void MonthlyWageFirstnameGet(string firstname)
        {
            MonthlyWorker worker = 
                new MonthlyWorker("Алексей", "Волконский", 10000, 2, 500);
            Assert.AreEqual(firstname, worker.Firstname);
        }

        [TestCase("Волконский", TestName = "Monthly Wage Get Surname")]
        [Test]
        public void MonthlyWageSurnameGet(string surname)
        {
            MonthlyWorker worker = 
                new MonthlyWorker("Алексей", "Волконский", 10000, 2, 500);
            Assert.AreEqual(surname, worker.Surname);
        }
    }
}
