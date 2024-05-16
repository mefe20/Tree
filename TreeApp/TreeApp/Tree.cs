using System;

namespace TreeApp
{
    public class Tree
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int HitsRequired { get; set; }
        public int HitsRemaining { get; set; }
        public int NumberOfFruits { get; set; }
        public int DaysUntilSpellEnds { get; set; }
        public DateTime PlantingDate { get; set; }
        public int Age => (DateTime.Now - PlantingDate).Days / 365;

        public Tree(string name, string country, int hitsRequired, int hitsRemaining, int numberOfFruits, int daysUntilSpellEnds, DateTime plantingDate)
        {
            Name = name;
            Country = country;
            HitsRequired = hitsRequired;
            HitsRemaining = hitsRemaining;
            NumberOfFruits = numberOfFruits;
            DaysUntilSpellEnds = daysUntilSpellEnds;
            PlantingDate = plantingDate;
        }

        public override string ToString()
        {
            return $"{Name} from {Country} requires {HitsRequired} hits, {HitsRemaining} hits remaining, {NumberOfFruits} fruits, {DaysUntilSpellEnds} days until spell ends, planted on {PlantingDate.ToShortDateString()}";
        }
    }
}
