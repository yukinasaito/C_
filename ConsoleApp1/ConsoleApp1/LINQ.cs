using System;
using System.Collections.Generic;

namespace ConsoleApplication5 
{
    class Program
	{
        static void Main(string[] args)
        {
            List<TestResult> results = new List<TestResult>()
            {
                new TestResult(){ Name = "Suzuki Ichiro",Math = 80, Physics = 60},
                new TestResult(){ Name = "Akagawa Jiro", Math = 70, Physics = 90},
                new TestResult(){ Name = "Mikawa Saburo",Math = 90, Physics = 100},
            };
            //ここで、受験者全員の数学平均を求めたい
         }       
	}



}
