using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTut20
{
    public static class Extensions
    {
        public static void PrintDeck(this IEnumerable<Card> cards, string title)
        {
            Console.WriteLine($"\n\n\n###### {title} ######");
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
