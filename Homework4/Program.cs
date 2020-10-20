using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Threading;

namespace Homework4
{
    class MyException : Exception
    { // 사용자 정의 exception
        public int ErrorNo { get; set; }
    }
    class Manager
    {
        static public int Handler(int num)
        {// event를 위한 메소드
            return num;
        }
        static void Main(string[] args)
        { 
            int count;
            Console.Write("등록할 컴퓨터의 수량을 입력하세요: ");
            string temp = Console.ReadLine();
            try
            {
                if (Convert.ToInt32(temp) >= 10)
                    throw new MyException() { ErrorNo = Convert.ToInt32(temp) };
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
           
            List<PCInfo> list = new List<PCInfo>();

            count = Convert.ToInt32(temp);
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
                SETPCINFO callback = new SETPCINFO(t.setPCInfo);
                callback(i, cpu, mem);
                list.Add(t);
            }
;
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
                        StartTime callbackst = new StartTime(list[cN].start);
                        callbackst(System.DateTime.Now.Ticks);
                        break;
                    case 2: // 사용 종료
                        Console.Write("컴퓨터의 번호를 입력하세요 : ");
                        temp = Console.ReadLine();
                        cN = Convert.ToInt32(temp);
                        StopTime callbackstop = new StopTime(list[cN].stop);
                        int cost = callbackstop(System.DateTime.Now.Ticks);
                        Console.WriteLine("사용금액은 " + cost + "원 입니다.");
                        break;
                    case 3: // 정보 출력
                        int cnt=0;
                        for(int i=0; i<list.Count; i++)
                        {
                            list[i].eventCall += new GetTotal(Handler);
                            cnt += list[i].getTotal();
                        }
                        Console.WriteLine("총 매출은 " + cnt + "원 입니다.");
                        break;
                    case 4: // 프로그램 종료
                        return;
                }
            }
        }
    }
}
