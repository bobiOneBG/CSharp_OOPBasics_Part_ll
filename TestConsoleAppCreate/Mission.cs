namespace _08_MIlitaryElit
{
    public class Mission
    {
        public Mission(string codeName, string state)
        {
            this.codeName = codeName;
            this.State = state;
        }

        public string codeName { get; private set; }
        public string State { get; private set; }

        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {this.codeName} State: {this.State}";
        }
    }
}