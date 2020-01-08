using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractTest
{
    class HorizontalBarChart : BarChart
    {
        public override void plot()
        {
            Console.WriteLine("輸出");

            //文字 + **
            for (int idx = 0; idx < bars.Count; idx++)
            {
                Console.Write(bars[idx]+" ");

                for(int i = 0; i < bars[idx]; i++)
                {
                    Console.Write("*");
                }
                //換行
                Console.WriteLine(" ");
            }
        }
    }
}
