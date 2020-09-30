using System;
using System.Collections.Generic;
using System.Text;

namespace TjuvOchPolis
{
    class Game
    {
        public static Person[,] Gamebaord = new Person[100, 25];

        public static void EmptyBoard()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            foreach (var item in Person.PersonList)
            {
                Gamebaord[item.CurentPositionX, item.CurentPositionY]= item;
            }
        }
        private static void GenerateGameBoard()
        {
            
        }
        

    }
}
