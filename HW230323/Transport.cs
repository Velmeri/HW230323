using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW230323
{
    // Интерфейс общего назначения,
    // Чтобы клонировать объекты без напряга.
    public interface ICloneable<T>
    {
        T Clone();
    }

    // Абстрактный класс Транспорт
    // С двигателем, что несет техники лучший поток.
    public abstract class Transport : ICloneable<Transport>
    {
        // Защищенное свойство - двигатель.
        protected Engine _Engine { get; set; }

        // Конструктор транспорта,
        // Который двигатель в свойство принимает.
        public Transport(Engine engine)
        {
            _Engine = engine;
        }

        // Абстрактный метод клонирования,
        // Чтобы каждый объект рождал братца-двойника.
        public abstract Transport Clone();

        // ToString переопределен, чтоб выводил,
        // Информацию о двигателе наш познаватель.
        public override string ToString()
        {
            return 
                $"Engine:\n" +
                $"\tType: {_Engine.Type}\n" +
                $"\tHorsepower: {_Engine.Horsepower}";
        }
    }

    // Класс Двигатель, 
    // Приносит силу технике, чтобы двигаться на ней.
    public class Engine
    {
        // Свойство - тип, чтоб знать, какой двигатель нам нужен.
        public string Type { get; set; }

        // Свойство - мощность, чтоб сила наша была сильной.
        public int Horsepower { get; set; }

        // Конструктор Двигателя, чтоб создавался с нужными свойствами.
        public Engine(string type, int horsepower)
        {
            Type = type;
            Horsepower = horsepower;
        }
    }

    // Класс машины наследуется от Транспорта,
    // Реализуя метод Clone() для клонирования без ошибок.
    class Car : Transport
    {
        // Конструктор машины с двигателем, чтоб ездила и гудела.
        public Car(Engine engine) : base(engine) { }

        // Метод Clone для создания братца-двойника машины,
        // Чтобы он был такой же, как и она сама.
        public override Transport Clone()
        {
            return new Car(this._Engine);
        }
    }

    class Ship : Transport
    {
        // Конструктор корабля с двигателем, чтоб плавала и мотала волны.
        public Ship(Engine engine) : base(engine) { }

        // Метод Clone для создания братца-двойника корабля,
        // Чтобы он был такой же, как и он сам по себе.
        public override Transport Clone()
        {
            return new Ship(this._Engine);
        }
    }

    class Airplane : Transport
    {
        // Конструктор самолета с двигателем, чтоб летал и шумел.
        public Airplane(Engine engine) : base(engine) { }

        // Метод Clone для создания братца-двойника самолета,
        // Чтобы он был такой же, как и он сам по себе.
        public override Transport Clone()
        {
            return new Airplane(this._Engine);
        }
    }
}
