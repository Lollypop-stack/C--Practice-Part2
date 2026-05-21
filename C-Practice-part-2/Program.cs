using System;

namespace Project{
    class Program{
        static void Main(){
            Robot bot = new Robot();
            // bot.name = "Sasun";
            // bot.weight = 900;
            // bot.coordinates = new byte[]{1, 4, 8};

            bot.setValues("Chuschka", 90, new byte[]{1,1,1});
            bot.printValues();
        }
    }
}