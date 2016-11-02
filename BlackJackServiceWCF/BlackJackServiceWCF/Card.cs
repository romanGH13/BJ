using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlackJackServiceWCF
{
    public enum Suit
    {
        [XmlEnum(Name = "Spades")]
        SPADES,
        [XmlEnum(Name = "Clubs")]
        CLUBS,
        [XmlEnum(Name = "Diamonds")]
        DIAMONDS,
        [XmlEnum(Name = "Hearts")]
        HEARTS
    };
    [DataContractAttribute]
    public class Card
    {
        public string Title { set; get; }
        public Suit Suit { set; get; }
        public int Value { set; get; }


        public Card(string title, Suit suit)
        {
            this.Title = title;
            this.Suit = suit;
            switch (this.Title)
            {
                case "a":
                    this.Value = 11;
                    break;
                case "k":
                    this.Value = 4;
                    break;
                case "q":
                    this.Value = 3;
                    break;
                case "j":
                    this.Value = 2;
                    break;
                default:
                    this.Value = Convert.ToInt32(this.Title);
                    break;
            }
            string letter = "";
            switch (this.Suit)
            {
                case Suit.SPADES:
                    letter = "s";
                    break;
                case Suit.CLUBS:
                    letter = "c";
                    break;
                case Suit.DIAMONDS:
                    letter = "d";
                    break;
                case Suit.HEARTS:
                    letter = "h";
                    break;
            }
        }
    }
}
