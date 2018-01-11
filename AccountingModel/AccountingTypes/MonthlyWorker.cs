using System;
using AccountingModel.Utility;

namespace AccountingModel.AccountingTypes
{
    /// <summary>
    /// Сотрудник с месячной з.п (окладом) 
    /// </summary>
    public class MonthlyWorker: Worker
    {
        public MonthlyWorker()
        {

        }

        /// <summary>
        /// Конструктор, принимающий имя, фамилию, оклад, ставку и премию
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="surname"></param>
        /// <param name="reward"></param>
        /// <param name="rate"></param>
        /// <param name="bounty"></param>
        public MonthlyWorker(string firstname, string surname, 
            double reward, double rate, double bounty)
        {
            Firstname = firstname;
            Surname = surname;
            Reward = reward;
            Rate = rate;
            Bounty = bounty;
        }

        private double _reward;

        /// <summary>
        /// Property оклада
        /// </summary>
        public double Reward
        {
            get
            {
                return _reward;
            }

            set 
            {
                if (!(Validator.ValidateNumber(value) 
                    && (value > 7500) && (value <= 150000)))
                {
                    throw new ArgumentException("Invalid reward");
                }
                _reward = value; 
            }
        }

        private double _rate;

        /// <summary>
        /// Ставка
        /// </summary>
        public double Rate
        {
            get
            {
                return _rate;
            }

            set 
            {
                if (!(Validator.ValidateNumber(value) 
                    && (value > 0) && (value <= 2.5)))
                {
                    throw new ArgumentException("Invalid rate");
                }
                _rate = value; 
            }
        }

        private double _bounty;

        /// <summary>
        /// Премия
        /// </summary>
        public double Bounty
        {
            get { return _bounty; }
            set 
            {
                if (!(Validator.ValidateNumber(value) 
                    && (value >= 0) && (value <= 50000)))
                {
                    throw new ArgumentException("Invalid bounty");
                }
                _bounty = value; 
            }
        }

        /// <summary>
        /// Расчет месячной зарплаты
        /// </summary>
        /// <returns></returns>
        public override double GetSalaryValue()
        {
            return ((_reward * _rate) + _bounty);
        }
    }
}
