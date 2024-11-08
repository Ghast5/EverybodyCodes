namespace Day1
{
    public class Battle
    {
        public int CountTotalNeededPotions(string input, int memberOfGroup)
        {
            int potions = 0;

            for (int i = 0; i < input.Length - (memberOfGroup - 1); i += memberOfGroup)
            {
                string set = input.Substring(i, memberOfGroup);

                int numberOfX = CountXLetters(set);
                potions += ExtraPotions(numberOfX, memberOfGroup);

                potions += CountNumberOfPotions(set);
            }

            return potions;
        }

        public int CountNumberOfPotions(string input) => input.Sum(letter => Potions(letter));

        private int Potions(char letter) => letter switch
        {
            'B' => 1,
            'C' => 3,
            'D' => 5,
            _ => 0
        };

        public int CountXLetters(string set) => set.Count(letter => letter == 'x');

        private int ExtraPotions(int numberOfX, int memberOfGroup) => (memberOfGroup, numberOfX) switch
        {
            (3, 0) => 6,
            (3, 1) => 2,
            (2, 0) => 2,
            _ => 0
        };
    }
}
