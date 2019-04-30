namespace _08_MIlitaryElit
{
    public class Soldier : ISoldier
    {
        public Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string Id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public override string ToString()
        {
            return $"Name: {this.firstName} {this.lastName} Id: {this.Id}";
        }
    }
}
