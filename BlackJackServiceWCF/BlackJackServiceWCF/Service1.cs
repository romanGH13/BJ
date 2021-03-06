﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackJackServiceWCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Game : IGame
    {
        int maxPlayerCount = 3;
        static List<Player> Players = null;
        static List<Card> Deck = null;

        public Game()
        {

            Players = new List<Player>();
            Deck = CreateDeck();
        }

        public int Connect(string playerName)
        {
            if (Players.Count >= maxPlayerCount)
                return -1;
            Player p = new Player(playerName);
            Players.Add(p);
            Players[Players.Count - 1].Id = Players.Count;
            return Players.Count;
        }

        public Card GiveCard(int playerId)
        {
            Card card = Deck[Deck.Count - 1];
            Deck.RemoveAt(Deck.Count - 1);
            return card;
        }

        public void Pass(int playerId)
        {
            for(int i=0;i<Players.Count;i++)
            {
                if(Players[i].Id == playerId)
                {
                    Players[i].isPass = true;
                    break;
                }
            }
        }

        public void Ready(int playerId)
        {
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Id == playerId)
                {
                    Players[i].isReady = true;
                    break;
                }
            }
        }

        public void Exit(int playerId)
        {
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Id == playerId)
                {
                    Players.RemoveAt(i);
                    break;
                }
            }
        }
        public List<Card> CreateDeck()
        {
            
            string[] Names = {"sa","sk","sq","sj","s10","s9","s8","s7","s6",
                             "ca","ck","cq","cj","c10","c9","c8","c7","c6",
                             "da","dk","dq","dj","d10","d9","d8","d7","d6",
                             "ha","hk","hq","hj","h10","h9","h8","h7","h6"};
            Random rnd = new Random();
            string[] MyRandomArray = Names.OrderBy(x => rnd.Next()).ToArray();
            List<Card> Deck = new List<Card>();
            for (int i = 0; i < 36; i++)
            {
                String title = MyRandomArray[i].Substring(1);
                Suit suit = Suit.HEARTS;
                switch (MyRandomArray[i].Substring(0, 1))
                {
                    case "s":
                        suit = Suit.SPADES;
                        break;
                    case "c":
                        suit = Suit.CLUBS;
                        break;
                    case "d":
                        suit = Suit.DIAMONDS;
                        break;
                    case "h":
                        suit = Suit.HEARTS;
                        break;
                }
                Deck.Add(new Card(title, suit));
            }
            return Deck;
        }
    }
}
