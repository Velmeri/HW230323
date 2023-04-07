using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW230323
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Car с двигателем "Type-1" мощностью 10 л.с.
            Car car = new Car(new Engine("Type-1", 10));

            // Создание клона объекта класса Car
            Car carClone = (Car)car.Clone();

            // Вывод клона на консоль
            Console.WriteLine(carClone);

            // Я такой-себе поэт :D
            Console.ReadKey(true);
        }
    }
}
