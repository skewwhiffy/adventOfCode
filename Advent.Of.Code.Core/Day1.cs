using System.Linq;

namespace Advent.Of.Code.Core
{
    public class Day1
    {
        public int Sum(string rawData, bool halfWayRound)
        {
            var rawList = rawData
                .Select(c => int.Parse(c.ToString()))
                .ToList();
            var sum = 0;
            var offset = halfWayRound ? rawList.Count / 2 : 1;
            for (var i = 0; i < rawList.Count; i++)
            {
                var current = rawList[i];
                var next = rawList[(i + offset) % rawList.Count];
                if (current == next)
                {
                    sum += current;
                }
            }
            return sum;
        }
    }
}
