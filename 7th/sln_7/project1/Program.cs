using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열 : 같은 데이터 타입을 가진 데이터들의 집합 (고정)
            // 고정 - 메모리 공간을 미리 확보 => 늘리거나 줄일 수 없다. 
            // 195쪽 4번 답 : 3번

            /*int[] area = { 1, 2, 3, 4, 5, 65, 100 };*/
            /*int[] area = new int [] { 1, 2, 3, 4, 5, 65, 100 };*/
           /* int[] area = { 1, 23, 4, 5, 100 };
           
            foreach (var item in area)
            {
                Console.WriteLine("area : " + item);
            }*/


            // 리스트 :같은 데이터 타입을 가진 데이터들의 집합 (가변) - 중간 시험 X.
            // <> (제네릭) : 일반화 (무엇을 ?)
           /* List<int> lists = new List<int>() { 15,25,312};
            lists.Add(4100);
            lists.Remove(25);
            lists.RemoveAt(0); // 해당 인덱스 삭제
            lists.Insert(0, 2000); // 삽입
            foreach (var item in lists)
            {
                Console.WriteLine("lists : "+item);
            }*/


        }
    }
}
