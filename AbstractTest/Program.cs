using System;

namespace AbstractTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalBarChart horBarChart = new HorizontalBarChart();

            horBarChart.addBar();

            horBarChart.plot();

            //Console.WriteLine("Hello World!");
        }
    }
}
