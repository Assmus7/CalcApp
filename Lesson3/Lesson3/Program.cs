using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        /// <summary>
        /// Программа для выбора машины
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите тип машины:");
                Console.WriteLine("VAZ - для выбора ВАЗ 2105");
                Console.WriteLine("Lambo - для выбора Lamborgini");
                Console.WriteLine("Ferrari - для выбора Ferrari");

                string type = Console.ReadLine();

                // переменная chosenCar класса Car вызывает метод GetCarByType() 
                Car viberiCar = GetCarByType(type); // которая выбирает какой класс нам нужен, в зависимости от выбора пользователя

                Console.WriteLine();
                Console.WriteLine("Вы выбрали:");
                Console.WriteLine(viberiCar.ToString());

                Console.WriteLine("Поехали!");
                viberiCar.Drive(); // Ссылка на класс Car, в котором есть метод Drive(), который реализует наследник, тем самым меняя переменную _speed
                Console.WriteLine(viberiCar.ToString()); // В итоге результат уже с измененной переменной _speed 

                if (viberiCar is ITurbo)
                {
                    Console.WriteLine("Машина турбирована");
                    ((Lamborgini)viberiCar).Turbo();
                }

                // Выход из цикла, если y\n
                Console.WriteLine("Еще раз?(y\\n)");
                string answer = Console.ReadLine();
                if (answer != "y")
                    break;
            

            Console.WriteLine();

            }
        }

        static Car GetCarByType(string type)
        {
            switch (type)
            {
                case "Vaz":
                    return new Vaz();

                case "Lambo":
                    return new Lamborgini();

                case "Ferrari":
                    return new Ferrari();
                default:
                    return null;
            }
        }
    }
}
