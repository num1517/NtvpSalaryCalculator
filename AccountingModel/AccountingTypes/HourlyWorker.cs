using System;
using AccountingModel.Utility;

namespace AccountingModel.AccountingTypes
{
    /// <summary>
    /// сотрудник с почасовой оплатой
    /// </summary>
    public class HourlyWorker: Worker
    {
        public HourlyWorker()
        {

        }

        /// <summary>
        /// Конструктор, принимающий имя и фамилию
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="surname"></param>
        public HourlyWorker(string firstname, string surname)
        {
            if (!(Validator.ValidateString(firstname) 
                && Validator.ValidateString(surname)))
            {
                throw new ArgumentException();
            }

            Firstname = firstname;
            Surname = surname;
        }

        /// <summary>
        /// Конструктор, принимающий имя, фамилию, ставку за час, отработанное кол-во часов
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="surname"></param>
        /// <param name="hourPrice"></param>
        /// <param name="hoursWorked"></param>
        public HourlyWorker(string firstname, string surname,
            double hourPrice, double hoursWorked)
        {
            if (!(Validator.ValidateString(firstname) 
                && Validator.ValidateString(surname)))
            {
                throw new ArgumentException();
            }
            
            Firstname = firstname;
            Surname = surname;
            HourPrice = hourPrice;
            HoursWorked = hoursWorked;
        }

        /// <summary>
        /// Цена часа
        /// </summary>
        private double hourPrice;
        /// <summary>
        /// Property цены часа
        /// </summary>
        public double HourPrice
        {
            get
            {
                return hourPrice;
            }

            set 
            {
                if (!(Validator.ValidateNumber(value) 
                    && (value >= 30) && (value <= 1000)))
                {
                    throw new ArgumentException("Invalid hourPrice");
                }
                hourPrice = value; 
            }
        }
        /// <summary>
        /// Отработанные часы
        /// </summary>
        private double hoursWorked;
        /// <summary>
        /// Property отработанных часов
        /// </summary>
        public double HoursWorked
        {
            get
            {
                return hoursWorked;
            }

            set 
            {
                if (!(Validator.ValidateNumber(value) 
                    && (value >= 80) && (value <= 300)))
                {
                    throw new ArgumentException("Invalid hoursWorked");
                }
                hoursWorked = value; 
            }
        }

        /// <summary>
        /// Расчет почасовой зарплаты
        /// </summary>
        /// <returns></returns>
        public override double GetSalaryValue()
        {
            return (hourPrice * hoursWorked);
        }

        /// <summary>
        /// Преобразование объекта в строку
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Firstname + " " + Surname + " worked "
                + hoursWorked + " hours. One emp hour costs " + hourPrice 
                + ". At mounth emp salary is " + GetSalaryValue() + "."; 
        }
    }
}
