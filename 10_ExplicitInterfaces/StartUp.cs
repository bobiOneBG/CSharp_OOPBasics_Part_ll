namespace _10_ExplicitInterfaces
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var citizens = new List<Citizen>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] citizenInfo = input.Split();

                string name = citizenInfo[0];
                string country = citizenInfo[1];
                string age = citizenInfo[2];

                citizens.Add(new Citizen(name, country, age));
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}
