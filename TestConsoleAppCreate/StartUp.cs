namespace _08_MIlitaryElit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var privates = new List<Private>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var soldierInfo = input.Split();

                var soldierType = soldierInfo[0];

                string id = soldierInfo[1];
                string firstName = soldierInfo[2];
                string lastName = soldierInfo[3];
                double salary = double.Parse(soldierInfo[4]);
                switch (soldierType)
                {
                    case "Private":
                        var @private = new Private(id, firstName, lastName, salary);
                        privates.Add(@private);
                        Console.WriteLine(@private.ToString());
                        break;

                    case "LeutenantGeneral":
                        LeutenantGeneral ltGeneral = new LeutenantGeneral(id, firstName, lastName, salary);
                        for (int i = 5; i < soldierInfo.Length; i++)
                        {
                            var privateId = soldierInfo[i];
                            ltGeneral.Privates.Add(privates.First(p => p.Id == privateId));
                        }

                        Console.WriteLine(ltGeneral.ToString());
                        break;

                    case "Engineer":
                        var corps = soldierInfo[5];

                        if (corps == "Airforces" || corps == "Marines")
                        {
                            var engineer = new Engineer(id, firstName, lastName, salary, corps);
                            for (int i = 6; i < soldierInfo.Length; i += 2)
                            {
                                var repairPart = soldierInfo[i];
                                var repairHours = soldierInfo[i + 1];
                                var repair = new Repair(repairPart, int.Parse(repairHours));
                                engineer.Repairs.Add(repair);
                            }

                            Console.WriteLine(engineer.ToString());
                        }
                        break;

                    case "Commando":
                        corps = soldierInfo[5];

                        if (corps == "Airforces" || corps == "Marines")
                        {
                            var commando = new Commando(id, firstName, lastName, salary, corps);

                            for (int i = 6; i < soldierInfo.Length; i+=2)
                            {
                                var codeName = soldierInfo[i];
                                var state = soldierInfo[i + 1];

                                if (state== "inProgress"||state== "Finished")
                                {
                                    var mission = new Mission(codeName, state);

                                    commando.Missions.Add(mission);
                                }                                
                            }

                            Console.WriteLine(commando.ToString());
                        }
                        break;

                    case "Spy":
                        var codeNumber = int.Parse(soldierInfo[4]);
                        var spy = new Spy(id, firstName, lastName, codeNumber);
                        Console.WriteLine(spy.ToString());
                        break;

                    default:
                        Console.WriteLine("Stana Greshka");
                        break;
                }
            }
        }
    }
}
