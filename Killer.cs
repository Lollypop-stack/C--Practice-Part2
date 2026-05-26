using System;
namespace Project
{
    /* class Killer : Robot  // Вариант для существующего метода-сборщика данных (setValues)
    {
        public Killer(string name, int weight, byte[] coordinates)
        {
            setValues(name, weight, coordinates);
        }
    } */

    class Killer : Robot
    {
        public int Health { get; set; }
        public Killer(string name, int weight, byte[] coordinates, int health) // инициализатор конструктора
        : base(name, weight, coordinates)
        {
            Health = health;
            printValues(Health); //или base.printValues(Health)
        }
        // protected модификатор доступа, позволяющий всем дочерним класса одного класса обращаться к полям, созданным в этом родительском классе

    }
}