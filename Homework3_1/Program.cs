using System;
using System.Collections.Generic;

namespace Homework3_1
{
    class Driver
    {
        static void Main(string[] args)
        {
            Car Genesis = new Car();
            Genesis.Name = "제네시스";
            Genesis.Value = 40000000;
            Car Opirus = new Car();
            Opirus.Name = "오필러스";
            Opirus.Value = 30000000;
            Car Rio = new Car();
            Rio.Name = "리오";
            Rio.Value = 15000000;

            List<Car> cars = new List<Car>();
            cars.Add(Genesis);
            cars.Add(Opirus);
            cars.Add(Rio);
        }
    }
}
