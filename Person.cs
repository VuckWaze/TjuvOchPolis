using System;
using System.Collections.Generic;

namespace TjuvOchPolis
{
    class Person
    {
        public int CurentPositionX { get; set; }
        public int CurentPositionY { get; set; }
        public int Direction { get; set; }

        public static List<Person> PersonList = new List<Person>();
        public Person(int curentpositionX, int curentpositionY, int direction)
        {
            CurentPositionX = curentpositionX;
            CurentPositionY = curentpositionY;
            Direction = direction;
        }
        public static void FillCityWithPeople()
        {
            Citizen.CreateCitizens(3);
            
        }
        public static void Move(List<Person> Personlist, int i, int j)//Stoppa in lista med persiner och fp dom att röra sig
        {
            foreach (var Person in PersonList)
            {
                if (Person.Direction == 1)//Om Direction är=1 går personen åt höger
                {
                    if (Person.CurentPositionY==i)//Går åt höger
                    {
                        Person.CurentPositionY = 0;
                    }
                    else
                    {
                        Person.CurentPositionY++;
                    }
                }
                if (Person.Direction==2)//Vänster
                {
                    //if ()
                    {

                    }
                }

            }
            //if (C.CurentPositionY == i)
            //    C.CurentPositionY = 0;
            //else
            //    C.CurentPositionY++;
        }

    }
}
