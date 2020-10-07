using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] array = new float[10, 3];

            for(int i=0; i<10; i++)
            {
                Console.Write("키 입력 : ");
                array[i,0] = float.Parse( Console.ReadLine());
                Console.Write("몸무게 입력 : ");
                array[i,1] = float.Parse( Console.ReadLine());

                float sw = (float)((array[i,0] - 100) * 0.9);
                array[i,2] = (array[i,0] / sw )* 100;

            }

            for(int i=0; i<10; i++)
            {
                Console.WriteLine("키 : " + array[i, 0] + " 몸무게 : " + array[i, 1] + " 비만도 : " + array[i, 2]);
            }
        }
    }
}
