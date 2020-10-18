using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Homework4
{
    class Manager
    {

        static void Main(string[] args)
        { 


            //PC방 시스템 만들기
            /*
            long start = System.DateTime.Now.Ticks;
            Thread.Sleep(3000);
            long stop = System.DateTime.Now.Ticks;
            Console.WriteLine((double)(stop - start) / 10000000.0F + "초");

            */

            string temp;
            Console.Write("등록할 컴퓨터의 수량을 입력하세요: ");
            temp = Console.ReadLine();
            int count = Convert.ToInt32(temp);
            List<PCInfo> list = new List<PCInfo>();

            for (int i=0; i<count; i++)
            {
                PCInfo t = new PCInfo();
                Console.WriteLine("PC " + i + "번");
                Console.Write("컴퓨터의 기종(CPU)을 입력하세요 : ");
                temp = Console.ReadLine();
                string cpu = Convert.ToString(temp);
                Console.Write("메모리의 양을 입력하세요(GB) : ");
                temp = Console.ReadLine();
                int mem = Convert.ToInt32(temp);

                //delegate로 접근할 것
                t.setPCInfo(i, cpu, mem);
                list.Add(t);
            }

            while (true)
            {
                Console.WriteLine("=================");
                Console.WriteLine("1. 컴퓨터 사용 시작 [0-2]");
                Console.WriteLine("2. 컴퓨터 사용 종료 [0-2]");
                Console.WriteLine("3. 매출정보 출력");
                Console.WriteLine("4. 프로그램 종료");
                Console.WriteLine("=================");
                Console.Write("메뉴의 번호를 입력하세요(1-4) : ");
                temp = Console.ReadLine();
                int n = Convert.ToInt32(temp);
                int cN;

                switch (n)
                {
                    case 1: // 사용 시작
                        Console.Write("컴퓨터의 번호를 입력하세요 : ");
                        temp = Console.ReadLine();
                        cN = Convert.ToInt32(temp);
                        list[cN].start(System.DateTime.Now.Ticks);
                        break;
                    case 2: // 사용 종료
                        Console.Write("컴퓨터의 번호를 입력하세요 : ");
                        temp = Console.ReadLine();
                        cN = Convert.ToInt32(temp);
                        int cost = list[cN].stop(System.DateTime.Now.Ticks);
                        Console.WriteLine("사용금액은 " + cost + "원 입니다.");
                        break;
                    case 3: // 정보 출력
                        
                        break;
                    case 4: // 프로그램 종료
                        return;
                }
            }
        }
    }
}
