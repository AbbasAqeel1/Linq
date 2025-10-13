using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTut20
{
    public class Card
    {

        public enum Suites
        {
            HEARTS = 0,
            DIAMONDS,
            CLUBS,
            SPADES
        };

        public int Value {  get; set; }
        public Suites suite { get; set; }

        public string NamedValue
        {
            get
            {
                string name = string.Empty;

                switch (Value)
                {
                    case (11):
                        name = "Jack";
                        break;
                    case (12):
                        name = "Queen";
                        break;
                    case (13):
                        name = "King";
                        break;
                    case (14):
                        name = "Ace";
                        break;
                    default:
                        name = Value.ToString();
                        break;
                
                }
                return name;

            }
        }

        public string Name
        {
            get
            {
                return NamedValue + " of " + suite.ToString();
            }
        }

        public bool IsRed => suite == Suites.HEARTS || suite == Suites.DIAMONDS;
          
        public Card(int value, Suites suite)
        {
            Value = value;
            this.suite = suite;
        }
    }
}
