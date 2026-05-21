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

        private string name = " ";
        private int weight;
        private byte[] coordinates = Array.Empty<byte>();

        public void setValues(string _name, int _weight, byte[] _coordinates){
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
        }
        protected int Length(byte[] Array){
            int length = 0;
            foreach(byte el in Array){
                length++;
            }
            return length;
        }
        public void printValues(){
            Console.WriteLine(name + " - Name, " + weight + " - Weight, ");
            foreach(byte elem in coordinates)
            {
                Console.Write("|" + coordinates[elem] + "| ");
            }
        }
    }
}