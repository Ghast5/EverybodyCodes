using Microsoft.VisualBasic;

namespace Day4
{
    public class HummerStrikes
    {
        public int GetHummerStrikes(string[] inputs, string part)
        {
            int strikes = 0;
            List<int> nailsLength = inputs.Select(x => int.Parse(x)).OrderBy(x => x).ToList();

            if (part.Equals("Part3"))
                strikes = CountStrikes(nailsLength.Count / 2, nailsLength);
            else
                strikes = CountStrikes(0, nailsLength);

            return strikes;
        }

        private int CountStrikes(int indexOfMin, List<int> numbers)
        {
            int strikes = 0;
            int optimalNailLength = numbers[indexOfMin];

            foreach (int nailLength in numbers)
            {
                if (nailLength <= optimalNailLength)
                    strikes += optimalNailLength - nailLength;
                else
                    strikes += nailLength - optimalNailLength;
            }

            return strikes;
        }
    }
}
