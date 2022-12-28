using System.Collections;

namespace _20221228
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("게임을 시작합니다");
            Game game = new Game();
            game.Play();
        }//main

        class Player
        {
            protected Hand hand;

            public Player()
            {
                hand = new Hand();
            }

            public virtual Hand Deal(Deck deck)
            {
                DealCards(2, deck);
                Console.WriteLine();

                bool playing = true;
                while (playing)
                {
                    Console.Write("히트 하시겠습니까? 스테이 하시겠습니까? 히트는 h 스테이는 s를 누르십시오: ");
                    string response = Console.ReadLine();
                    switch (response.ToUpper())
                    {
                        case "H":
                            DealCards(1, deck);
                            playing = !hand.IsBusted();
                            break;
                        case "S":
                            playing = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }

                return hand;
            }

            public void DealCards(int num, Deck deck)
            {
                string cardString = (num == 1) ? "카드" +
                    "" : "카드";
                Console.WriteLine("게임을 시작합니다." + cardString);
                for (int i = 0; i < num; i++)
                {
                    hand.AddCard(deck.GetCard());
                }
                Console.WriteLine(this.ToString());
            }

            public override string ToString()
            {
                return hand.ToString();
            }

        }//player

        class Card
        {
            public int Value { get; }

            public Card(int value)
            {
                this.Value = value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }//card

        class Dealer : Player
        {
            public Dealer() : base() { }

            public override Hand Deal(Deck deck)
            {
                while (hand.Total() < 17)
                {
                    DealCards(1, deck);
                }
                return hand;
            }
        }//딜러

        class Deck
        {
            Random random;
            public Deck()
            {
                random = new Random();
            }

            public Card GetCard()
            {
                int rank = random.Next(1, 11);
                Card c = new Card(rank);
                return c;
            }
        }//덱

        class Game
        {
            Deck deck;
            public Game()
            {
                deck = new Deck();
            }

            public void Play()
            {
                Player player = new Player();
                Hand playerHand = player.Deal(deck);

                if (playerHand.IsBusted())
                {
                    Console.WriteLine("범위를 벗어났습니다.");
                    Console.WriteLine("Game Over!");
                    return;
                }
                else
                {
                    Console.WriteLine("Player stays at {0}", playerHand.Total());
                }

                Console.WriteLine();
                Console.WriteLine("Dealer Playing");

                Dealer dealer = new Dealer();
                Hand dealerHand = dealer.Deal(deck);

                Console.WriteLine();
                if (dealerHand.IsBusted())
                {
                    Console.Write("Dealer busted!");
                    Console.WriteLine("Player Wins!");
                    return;
                }

                Console.WriteLine();
                if (playerHand.Total() > dealerHand.Total())
                {
                    Console.WriteLine("Player's {0} beats Dealer's {1}", playerHand.Total(), dealerHand.Total());
                    Console.WriteLine("Player Wins!");
                }
                else
                {
                    Console.WriteLine("Dealer's {1} beats Player's {0}", playerHand.Total(), dealerHand.Total());
                    Console.WriteLine("Game Over!");
                }
            }
        }//게임

        class Hand
        {
            ArrayList cards;
            public Hand()
            {
                cards = new ArrayList();
            }

            public void AddCard(Card card)
            {
                cards.Add(card);
            }

            public bool IsBusted()
            {
                return this.Total() > 21;
            }

            public int Total()
            {
                int total = 0;
                foreach (Card card in cards)
                {
                    total += card.Value;
                }
                return total;
            }
            public override string ToString()
            {
                string s = "손패: ";
                foreach (Card card in cards)
                {
                    s += card + " ";
                }
                s += "\n총합: ";
                s += Total();
                return s;
            }
        }//hand

    }//internal
}//namespace
