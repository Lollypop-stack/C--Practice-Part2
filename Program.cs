using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main()  // Модификатор static обозначает принадлежность к классу а не к объекту
        {
            // Robot bot = new Robot(); // Пустые скобки - стандартный пустой конструктор
            /* bot.name = "Sasun";  // Можно так только если поля в Robot имеют публичный модификатор доступа
            bot.weight = 900;
            bot.coordinates = new byte[] { 1, 4, 8 }; */

            /*  bot.setValues("Chuschka", 90, new byte[] { 1, 12, 213 });
             bot.printValues();
             // Console.WriteLine(bot.weight); // Будет: 90 при публичном создании 
             bot.Weight = 123;
             Console.WriteLine(bot.Weight); // Будет: 123 при public int Weight {get; set;} */

            // Наследование классов:
            // int damage = 12;
            Robot bot = new Robot();
            // int damage = 123; //можно также получать числовое значение из других классов либо при вызове других методов
            // int health = 123;
            Killer killer = new Killer("Chuschka", -90, new byte[] { 1, 12, 213 }, 100); // Передача данных напрямую в скобки возможна засчет создания кастомного публичного метода Killer(sting name,...){this.name = name}... и то, если у Killer есть наследование класса Robot


            // Операторы is и as:
            List<Robot> robots = new List<Robot>();
            robots.Add(new Robot("Buchka", 0, new byte[] { 121, 112, 3 }));
            robots.Add(new Robot("Chuschka", -90, new byte[] { 1, 12, 213 }));
            robots.Add(new Robot("Nana", 0, new byte[] { 121, 112, 3 }));

            Robot newRobot = null;
            foreach (Robot elem in robots)
            {
                if (elem?.Name == "Nana")
                {
                    newRobot = elem as Robot; //Это оператор безопасного приведения типа. Провал -> Null
                }
                Console.WriteLine(elem?.Name);
            }
            Console.WriteLine(newRobot is Robot); // проверка на тип данных
        }
    }
}