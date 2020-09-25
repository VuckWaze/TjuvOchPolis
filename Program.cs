using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TjuvOchPolis
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.FillCityWithPeople();
            GameBoard();
            Console.ReadLine();

        }

        private static void GameBoard()
        {
            List<Person> Personlist = Person.PersonList;
            int x = 50;
            int y = 20;
            string[,] gameboard = new string[x, y];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    //string c="";
                    foreach (var item in Personlist)
                    {
                        if (item.CurentPositionX == j && item.CurentPositionY == i)
                        {
                            Console.Write("M");

                            //c = "M";
                            //break;
                        }
                        else
                        {
                            //c = "-";
                            Console.Write("-");
                            break;
                        }
                    }
                   // Console.Write(c);

                }
                Console.WriteLine();
            }

            Console.ReadLine();
            Console.Clear();

           
        }
        
    }
}
