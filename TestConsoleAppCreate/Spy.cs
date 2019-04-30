using System.Text;

namespace _08_MIlitaryElit
{
    public class Spy : Soldier
    {
        public Spy(string id, string firstName, string lastName, int codeNumber) :
            base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Code Number: {this.CodeNumber}");

            return sb.ToString().Trim();
        }
    }
}
