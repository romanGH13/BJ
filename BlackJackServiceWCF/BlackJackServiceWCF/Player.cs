using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackServiceWCF
{
    public class Player
    {
        public int Id { set; get; }
        public List<Card> Cards { set; get; }
        public string Name { set; get; }
        public int points = 0;
        public bool isReady { set; get; }


        public Player(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Cards = new List<Card>();
            this.isReady = false;
        }

    }
}
