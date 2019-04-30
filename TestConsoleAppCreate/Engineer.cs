namespace _08_MIlitaryElit
{
    using System.Collections.Generic;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<Repair>();
        }

        public List<Repair> Repairs { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Repairs:");
            foreach (var repair in this.Repairs)
            {
                sb.AppendLine(repair.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
