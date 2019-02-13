using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public abstract class Car
    {
        protected int _speed; //что может машина
        protected string _type; // тип машины
        protected string _answer; // ответ пользователя

        public Car()
        {
            _speed = 0;
            _type = "noname";
            
        }

        
        
          //protected int _speed = 10;
        

        public abstract void Drive(); //абстрактный - что бы наследник мог определить
        // Получается можно создать много абстрактных классов и переопределить их в классе наследнике, что бы выводить пользователю то, что он выбрал

        public override string ToString()
        {
            return string.Format("Model: {0}; Max speed: {1}", _type, _speed);
        }
    }

    /// <summary>
    /// Класс для машины 1
    /// </summary>
    public class Vaz : Car
    {

        //Переопределение реализации базового(Car) класса
        public Vaz()
                : base()
        {
            _type = "VAZ 2107";
        }
        
        public override void Drive()
        {
            _speed = 60;
        }

        //public string Answer()
        //{
        //}
    }

    /// <summary>
    /// Класс для машины 2
    /// </summary>
    public class Lamborgini : Car, ITurbo
    {
        public Lamborgini()
            :base()
        {
            _type = "Gallardo";
        }

        public override void Drive()
        {
            Turbo();
            _speed = 260;
        }

        public void Turbo()
        {
        }
    }

    /// <summary>
    /// Класс для машины 3
    /// </summary>
    public class Ferrari : Car, IExtendedEngine 
    {
        public Ferrari()
            :base()
        {
            _type = "Ferrari";
        }

        public override void Drive()
        {
            ExtendEngine();
            _speed = 240;
        }

        public void ExtendEngine()
        {
        }
                
    }

    /// <summary>
    /// То, что есть у машины
    /// </summary>
    interface ITurbo
    {
        void Turbo();
    }

    /// <summary>
    /// расширенный двигатель
    /// </summary>
    interface IExtendedEngine
    {
        void ExtendEngine();
    }

    //public interface IAnswer
    //{
    //    string Answer();
    //}

}
