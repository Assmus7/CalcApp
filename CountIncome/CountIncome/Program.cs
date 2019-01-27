﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyEntry me = new MoneyEntry();

            Console.WriteLine("Привет!!");

            Console.Write("Введите сумму: ");        
            string amount = Console.ReadLine();
            
            Console.Write("Введите дату: ");
            string date = Console.ReadLine();

            me.InitWithString(amount, date);

            Console.WriteLine("Ваша запись: ");
            Console.WriteLine(me.ToString());

            if (me.IsDebit)
            {
                Console.WriteLine("У вас новый доход.");
            }
            else
                Console.WriteLine("У вас новый расход.");

            Console.ReadKey();

            
        }
    }
}
