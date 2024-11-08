using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Day2
{
    public class Runic
    {
        private readonly string day = "Day2";

        public int CountTotalRunicWords(string[] data)
        {
            int sum = 0;
            string[] words = RunesSymbolConverter(data);

            foreach (string word in words)
                sum += CountRunes(data[2], word);

            return sum;
        }

        private string[] RunesSymbolConverter(string[] data) => data[0][6..].Trim().Split(',');

        public int CountRunes(string sentece, string pattern) => Regex.Matches(sentece, pattern).Count;
    }
}
