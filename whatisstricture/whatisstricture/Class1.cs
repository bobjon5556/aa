using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace whatisstricture
{
    internal class Class1
    {

    }

    public class TrumpCard
    {

        private int[] trumpCardSet;//내가 사용할 카드세트
        private string[] trumpCardMark;//트럼프카드 마크

        

        public void SetupTrumpCards()
        { 
        trumpCardSet = new int[52];
            for(int i=0; i<trumpCardSet.Length; i++)
            {
                trumpCardSet[i] = i+1;
                Console.Write("{0}",trumpCardSet[i]);
                //ioop 카드를 셋업하는 루프
                //Setuptrumpcard()
            }
            trumpCardMark = new string[4] { "♥", "♠", "◈", "♣" };
        }

        public void ShuffleCards(int howmanyloop)
        {
            for (int i = 0; i < howmanyloop; i++)
            { 
            trumpCardSet=ShuffleOnce(trumpCardSet);
            }
        
        }
        public void ShuffleCards()
        {
            ShuffleOnce(trumpCardSet);
        }
        public void reroll()
        {
            ShuffleOnce(trumpCardSet);
        }

        public void RollCard() //한장의 카드를 한장 뽑아서 보여줌
        {
            int card = trumpCardSet[0];
            string cardMark = trumpCardMark[(card-1)/13];
            string cardnumber = Math.Ceiling(card%13.1).ToString();

            switch(cardnumber)
            {
                case "11":
                    cardnumber= "J";
                    break;
                case "12":
                    cardnumber = "Q";
                    break;
                case "13":
                    cardnumber = "K";
                    break;
                default:
                    /*없음*/
                    break;

            }
            

            Console.WriteLine("지금 뽑은 카드는{0}{1}{2}",cardMark,cardnumber,card);
            Console.WriteLine(" -------");
            Console.WriteLine("|{0}{1}    |",cardMark,cardnumber);
            Console.WriteLine("|       |");
            Console.WriteLine("|       |");
            Console.WriteLine("|    {0}{1}|",cardnumber,cardMark);
            Console.WriteLine(" -------");
        }
    public void printcheck()
        {
            Console.WriteLine("main 메서드에서 호출이 가능한가?");
        }

       
        
        
        public int[] ShuffleOnce(int[] intArray)
        {
            Random random = new Random();
            
            
            int aindex=random.Next(0, intArray.Length);
            int bindex=random.Next(0, intArray.Length);

            int temp = intArray[aindex];

            intArray[aindex] = intArray[bindex];
            intArray[bindex] = temp;

            return intArray;
        }
    }





}//Trumpcard



