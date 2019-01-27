using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balance
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo di = new DirectoryInfo("Data");

            if (di.Exists)
                di.Delete(true);

            di.Create();

            StreamWriter sw = File.CreateText("Data\\money.txt");


            Console.WriteLine("Привет!");

            // Вводим доход
            int debitSum = 0;

            for (int i = 0; i < 2; i++)
            {
                string debit = ""; // переменная debit - строка
                Console.Write("Введите доход: ");
                debit = Console.ReadLine(); // считываем со строки инф

                int debitInt; // переменная debitint - число
                int.TryParse(debit, out debitInt); // из строки инф делаем число
                debitSum += debitInt; // считаем сумму дохода
            }

            sw.WriteLine("Ваш доход:" + debitSum.ToString());
            sw.WriteLine();

            // Вводим расход
            int creditSum = 0;

            for (int i = 0; i < 2; i++)
            {
                string credit = ""; // переменная debit - строка
                Console.Write("Введите расход: ");
                credit = Console.ReadLine(); // считываем со строки инф

                int creditInt; // переменная debitint - число
                int.TryParse(credit, out creditInt); // из строки инф делаем число
                creditSum += creditInt; // считаем сумму расхода
            }

            sw.WriteLine("Ваш расход:" + creditSum.ToString());
            sw.WriteLine();

            // считаем баланс
           
            int balance = debitSum - creditSum;
            sw.WriteLine("Ваш баланс: " + balance.ToString());
            
            if (balance > 0)
            {
                sw.WriteLine("Успех! Баланс > 0");
            }
            else
            {
                sw.WriteLine("Провал! Баланс < 0");
            }

            sw.Close();

            Console.ReadKey();
        }
    }
}
