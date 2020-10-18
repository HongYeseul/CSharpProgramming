using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Homework4
{
    delegate void PCINFO();
    delegate void SETPCINFO(int id, String cpu, int mem);
    delegate void StartTime(long time);
    delegate int StopTime(long time);
    delegate int GetTotal();

    class PCInfo
    {
        int iId;
        public String strCpu;
        int iMem;
        long IStart;
        long IStop;
        public int iTotal;
        public event EventHandler TOTAL;

        public PCInfo()
        {
            //멤버 변수 값 초기화
        }

        public void setPCInfo(int id, String cpu, int mem)
        {
            this.iId = id;
            this.strCpu = cpu;
            this.iMem = mem;
        }

        public void start(long time)
        {
            // 사용 시작 시간 설정
            this.IStart = time;
        }
        public int stop(long time)
        {
            int cost;
            this.IStop = time;
            // 사용 종료시간 받아서 구하고 요금 계산해서 반환
            cost = (int)((double)(IStop - IStart) / 10000000.0F)*500;
            return cost;
        }
        public int getTotal()
        {
            // 프로그램 시작 이후에 PC 객체를 사용한 금액의 합을 반환
            long time = System.DateTime.Now.Ticks;
            iTotal = (int)((double)(time - IStart) / 10000000.0F) * 500;
            return iTotal;
        }
    }
}
