using System;
using System.Collections.Generic;
using System.Threading;
namespace TjuvOchPolis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            List<Person> Personlist= GeneratePeople(30,30,30);
            while (true)
            {
                Game.GenerateGameBoard(Personlist);
                Game.Muggin(Personlist);
                Game.Move(Personlist);
                Console.Clear();
            }
        }
        static List<Person> GeneratePeople(int numberOfCitizens, int numberOfThiefs, int numberOfPolices)
        {
            Citizen.GenerateCitizens(numberOfCitizens);
            Thief.GenerateThiefs(numberOfThiefs);
            Police.GeneratePolices(numberOfPolices);
            return Person.PersonList;
        }
    }
}
