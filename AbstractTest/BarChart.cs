using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AbstractTest
{
    public abstract class BarChart
    {
        private string m_sInput;

        private int m_ilength = 0;

        private bool m_bWhile = true;

        public List<int> bars = new List<int>();

        public void addBar()
        {
            int idx = 0;
            
            while(m_bWhile)
            {
                Console.WriteLine("請輸入數字");
                //輸入
                m_sInput = Console.ReadLine();

                if (int.TryParse(m_sInput, out m_ilength))
                {
                    //lInput[idx] = m_ilength;
                    bars.Add(m_ilength);
                    idx++;
                 
                    //預設3筆資料離開
                    if (idx == 3)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("輸入失敗請重新輸入");
                }
            }           
        }



        public abstract void plot();
    }
}
