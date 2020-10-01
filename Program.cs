using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TjuvOchPolis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Personlist= GeneratePeople(30,30,30);
            while (true)
            {
                Console.Clear();
                Game.GenerateGameBoard(Personlist);
                Game.Move(Personlist);
               // Console.ReadLine();
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
