using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static poker.Card;

namespace poker
{
    internal class Card
    {


        public enum Suit { None, 다이아, 하트, 클로버, 스페이드 }
        public enum Value
        {
            None, Ace, Two, Three, Four, Five, Six, Seven, Eight,
            Nine, Ten, Jack, Queen, King
        }


        public Suit mySuit { get; set; }

        public Value myValue { get; set; }


    }

    public class cradmark
    {
        public void cardmark()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("\u2663  클로버");
            Console.WriteLine("\u2660 스페이드");
            Console.WriteLine("\u2666 다이아");
            Console.WriteLine("\u2665 하트");
         }
     }
}

