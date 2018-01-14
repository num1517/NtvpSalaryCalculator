namespace AccountingModel.AccountingTypes
{
    /// <summary>
    /// Абстрактный класс сотрудник
    /// </summary>
    public abstract class Worker
    {
        private string _firstname;
        private string _surname;

        /// <summary>
        /// Имя
        /// </summary>
        public string Firstname
        {
            get
            {
                return _firstname;
            }

            set
            {
                if (!Utility.Validator.ValidateString(value))
                {
                    throw new System.ApplicationException("Wrong firstname");
                }
                _firstname = value;
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                if (!Utility.Validator.ValidateString(value))
                {
                    throw new System.ApplicationException("Wrong surname");
                }
                _surname = value;
            }
        }

        /// <summary>
        /// Расчет зарплаты
        /// </summary>
        /// <returns></returns>
        public abstract double GetSalaryValue();
    }
}