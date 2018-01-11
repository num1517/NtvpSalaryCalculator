namespace AccountingModel.AccountingTypes
{
    /// <summary>
    /// Абстрактный класс сотрудник
    /// </summary>
    public abstract class Worker
    {
        private string _firstName;
        private string _surName;

        /// <summary>
        /// Имя
        /// </summary>
        public string Firstname
        {
            get
            {
                return _firstName;
            }

            set
            {
                if (!Utility.Validator.ValidateString(value))
                {
                    throw new System.ApplicationException("Wrong firstname");
                }
                _firstName = value;
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname
        {
            get
            {
                return _surName;
            }

            set
            {
                if (!Utility.Validator.ValidateString(value))
                {
                    throw new System.ApplicationException("Wrong surname");
                }
                _surName = value;
            }
        }

        /// <summary>
        /// Расчет зарплаты
        /// </summary>
        /// <returns></returns>
        public abstract double GetSalaryValue();
    }
}