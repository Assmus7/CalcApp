using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIncome
{
    class MoneyEntry
    {
        private int _amount;     //Приватное поле

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        public MoneyEntry()
        {
            _amount = 0;
            EntryDate = DateTime.Now;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="amount"> сумма записи </param>
        /// <param name="date">Дата записи</param>
        public MoneyEntry(int amount, DateTime date)
        {
            _amount = amount;
            EntryDate = date;
        }

        /// <summary>
        /// Инициализация объект с помощью строк
        /// </summary>
        /// <param name="amount">Сумма записи</param>
        /// <param name="date">Дата записи</param>
        public void InitWithString(string amount, string date)
        {
            int.TryParse(amount, out int _amount);
            DateTime.TryParse(date, out DateTime dt);
            EntryDate = dt;
        }

        public override string ToString()
        {
            return string.Format("{0} от {1}", _amount, EntryDate.Date);
        }

        /// <summary>
        /// Является ли запись доходом
        /// </summary>
        public bool IsDebit
        {
            get
            {
                return _amount <= 0;
            }

            set
            {
                if (value && _amount < 0)
                    _amount = -_amount;
            }
        }
        
        /// <summary>
        /// Сумма записи
        /// </summary>
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public DateTime EntryDate { get;set; }

    }
}
