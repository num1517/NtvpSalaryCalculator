namespace AccountingModel.AccountingTypes
{
    /// <summary>
    /// Абстрактный класс сотрудник
    /// </summary>
    public abstract class Worker
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Firstname
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname
        {
            get;
            set;
        }

        /// <summary>
        /// Расчет зарплаты
        /// </summary>
        /// <returns></returns>
        public abstract double GetSalaryValue();
    }
}