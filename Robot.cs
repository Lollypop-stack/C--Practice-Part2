using System;
namespace Project
{
    class Robot
    {
        /* // public - модификатор доступа, который позволяет использовать этот класс в других частях программы
        // public/protected - внутри класса и наследников этого класса/private
        public string name = " ";
        public int weight;
        public byte[] coordinates = Array.Empty<byte>(); */

        /* Аксессоры get и set */
        // 
        private string name = " ";
        public string Name { get { return name; } private set { } }
        protected int weight; // Работаем c аксессором этого значения (Лучше всегда private)
        protected byte[] coordinates = Array.Empty<byte>();

        // Создание аксессора: 
        public int Weight
        {
            get // Срабатывает при попытке получения данных из какого-либо поля
            {
                return this.weight;
            }
            set // Срабатывает каждый раз при попытке задать значение для Weight
            {
                if (value < 0)
                    this.weight = 0;
                if (value > 0)
                    this.weight = value; // Параметр который по умолчанию переносится и задается (Value)
            }
        }

        public Robot(string name, int weight, byte[] coordinates)
        {
            this.name = name;
            Weight = weight;
            this.coordinates = coordinates;
        }
        public Robot() { } // Также возможно прописать несколько конструкторов под несколько вариаций
        /* public void setValues(string name, int weight, byte[] coordinates)
        {
            // this.name = name;
            // this.weight = weight;
            // this.coordinates = coordinates;

            this.name = name;
            Weight = weight;
            this.coordinates = coordinates;
        } */
        protected int Length(byte[] Array)
        {
            int length = 0;
            foreach (byte el in Array)
            {
                length++;
            }
            return length;
        }
        public void printValues(int damage)
        {
            Console.WriteLine(name + " - Name, " + Weight + " - Weight, ");
            foreach (byte elem in coordinates)
            {
                Console.Write("|" + elem + "| ");
            }
            Console.Write("\n");
        }
    }
}