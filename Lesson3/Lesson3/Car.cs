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

        public Car()
        {
            _speed = 0;
            _type = "noname";
        }

        public abstract void Drive(); //абстрактный - что бы наследник мог определить

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
        public  Vaz ()
            :base()
        {
            _type = "VAZ 2107";
        }

        public override void Drive()
        {
            _speed = 60;
        }
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

}
