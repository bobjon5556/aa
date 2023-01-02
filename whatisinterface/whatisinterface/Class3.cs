using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatisinterface
{
    public class Class3
    {
        public void Collectoin()
        {
            /*
             * 컬렉션 사용하기
             * 배열처럼 특정 항목의 집합을 리스트(List)또는 컬렉션이라고 한다.(컨테이너 라고 부르기도 한다)
             * 컬렉션은 배열, 리스트, 사전을 사용하여 관련 개체의 그룹을 만들고 관리한다.
             * 
             * 배열과 컬렉션
             * C#에서 배열(Array)과 컬렉션(Collectoin)그리고 리스트(List)는 학습 레벨에서 동일하게 취급한다.
             * 컬렉션 클래스는 데이터 항목의 집합을 메모리상에서 다루는 클래스로, 문자열 같은 간단한 형태도 있다. 또한 특정 클래스 형식의 집합 같은 복잡한 형태도 있다.
             * 
             * 3가지의 자주 쓰는 컬렉션 소개
             * 
             * -배열:일반적으로 숫자처럼 간단한 데이터 형식을 저장한다.
             * -리스트:간단한 데이터형식을 포함한 개체들을 저장한다.(클래스를 인스턴스화해서 올린 인스턴스들)
             * -사전(Dictionary):키와 값의 쌍으로 관리되는 개체들을 저장한다.
             * 
             * 일반적으로 기본형 그룹을 배열로 보고, 새로운 타입(클래스)의 그룹을 컬렉션으로 비교하기도 한다.
             * 
             * -배열:정수형, 문자열등 집합을 나타낸다.
             * -컬렉션:개체의 집합을 나타낸다. 리스트, 집합(Sst, 수하에서 배운 그것)매브 사전도 컬렉션과 같은 개념으로 사용한다.
             * 
             * 데이터를 그룹으로 묶어 관리할때는 일반적으로 배열로 관리한다. 배열은 크기가 고정되어 있다. 그래서 새로운 데이터를 추가할 수 없다.
             * 이러한 배열의 문제를 제거한 것이 컬렉션이다.
             * -컬렉션은 반복하여 사용할 수 있는 형식 안정성으로 크기를 동적으로 변경할 수 있다는 장점이 있다.
             * -컬렉션은 데이터를 조회, 정렬, 중복제거, 이름과 값을 관리하는 등 여러 장점이 있다.
             * 
             * 닷넷에서는 컬렉션과 관련한 여러 클래스를 제공한다.
             * -stack 클래스
             * -Queue클래스
             * -ArrayList클래스등등이 있다.
             * 
             * 리스트=> Linked list 를 줄여서 말하는 것.
             * 링크드 리스트란?
             * 
             */

            /*
             * 딕셔너리(Dictionary)
             * 키와 값이 순서쌍으로 되어 있어 트리 형태의 구조를 지니는 컬렉션의 일종
             * (2진으로 되어 있는 형태를red black tree->자가 2진 균형 탐색 트리라고도 한다.
             *                            ㅁ
             *                          ↙ ↘ 
             *                         ㅁ      ㅁ
             *                      ↙ ↘     ↙ ↘   
             *                    ㅁ     ㅁ  ㅁ    ㅁ
             *               ( 이런형태가 2진 균형 탐색 트리 이다)
             *이런 구조의 장점은 선형에 비해 탐색이 매우 빠르다는 것
             *간단히 예를 들면 선형 구조의 경우 99번 서치 해야 찾는 것을 이진 트리의 경우 2의 7승(128) 즉 7번이면 금방 찾을 수 있다.
             *이러한 형태는 무작위 입출력에 굉장히 효율적이다.
             *예를들어 대량으로 몬스터 잡는 게임은 몬스터 드랍아이템의 경우 드랍 테이블을 찾을 떄 효율적이다.
             *
             *
             */
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            inventory.Add("빨간포션", 10);
            inventory.Add("강철검", 1);

            Console.WriteLine("빨간포션의 개수는 {0}이다", inventory["빨간포션"]);

            List<int> intlist = new List<int>();
            intlist.Add(1);
            intlist.Add(2);
            intlist.Add(3);
            intlist.Add(4);

            intlist.Sort();
            intlist.Reverse();

            foreach (int number in intlist)
            { 
            Console.WriteLine(number);
            }
        }//콜렉션 클래스

        

        struct node //링크드 리스트 특징(데이터가 삭제되고 삽입될 떄 사용)
        {

            int _index;
            int number;
            int _adressNext;
            int _adressPrev;
        }
        //싱글 링크드 리스트는 순환 구조로 되어 있다. (넥스트만 있다고 보면 된다)
     
    }
    
}

