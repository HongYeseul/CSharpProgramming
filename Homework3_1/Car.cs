using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3_1
{
    class Car : Vehicle
    {
        private int cc;
        public int Cc
        {
            get
            {
                return cc;
            }
            set
            {
                cc = value;
            }
        }

        
        public override float TaxCalc()
        {
            if(this.cc >= 3000)
            {
                return (float)(Value * 0.05);
            }else if(this.cc >= 1500)
            {
                return (float)(Value * 0.13);
            }
            else
            {
                return (float)(Value * 0.01);
            }
        }
    }
}
