namespace _08_MIlitaryElit
{
    using System.Collections.Generic;
    using System.Text;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<Private>();
        }

        public List<Private> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (var @private in this.Privates)
            {
                sb.AppendLine(@private.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
