﻿namespace _08_MIlitaryElit
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName,
            double salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps { get; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
