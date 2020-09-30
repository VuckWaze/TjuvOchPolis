using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace TjuvOchPolis
{
    class Citizen : Person
    {
        //public int CurentPositionX { get; set; }
        //public int CurentPositionY { get; set; }
        //public int MoveX { get; set; }
        //public int MoveY { get; set; }
        //public static List<Citizen> Citizens = new List<Citizen>();
        public Citizen(int curentpositionX, int curentpositionY, int direction)
            : base(curentpositionX, curentpositionY, direction)
        {
            //blabla bla test
            CurentPositionX = curentpositionX;
            CurentPositionY = curentpositionY;
            Direction = direction;
        }
        public static void CreateCitizens(int a)//Skapar x-antal medborgare med Readline, slumpar startpositioner, Lägger till i listan Person
        {
            for (int i = 0; i < a; i++)//slumpa startpositioner
            {
                Random r = new Random();
                int x=r.Next(1,11);
                Random r1= new Random();
                int y= r1.Next(1,6);

                Random r2 = new Random();
                int z = r2.Next(1, 9);
                PersonList.Add(new Citizen(x, y, z));
            }
        }

    }
}
