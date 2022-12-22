//福山 陸
//C#
//.NET6.0
using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //開始時刻、終了時刻、判定時刻を受け取る
            int StartTimeInput = 0;
            int EndTimeInput = 0;
            int TargetTimeInput = 0;

            //各値の入力
            Console.WriteLine("Input in the range of 0 to 23");

            //開始時刻の入力
            do{
                Console.Write("Please input start time >> ");
                StartTimeInput = int.Parse(Console.ReadLine());
            } while (StartTimeInput < 0 || StartTimeInput > 23);

            //終了時刻の入力
            do{
                Console.Write("Please input end time >> ");
                EndTimeInput = int.Parse(Console.ReadLine());
            } while (EndTimeInput < 0 || EndTimeInput > 23);

            //判定時刻の入力 
            do{
                Console.Write("Please input evaluate time >> ");
                TargetTimeInput = int.Parse(Console.ReadLine());
            } while (TargetTimeInput < 0 || TargetTimeInput > 23);

            CheckTime(StartTimeInput, EndTimeInput, TargetTimeInput);
        }
        static void CheckTime(int StartTimeInput, int EndTimeInput, int TargetTimeInput)
        {
            int StartTimeCalc = StartTimeInput;
            int EndTimeCalc = EndTimeInput;
            int TargetTimeCalc = TargetTimeInput;

            if (EndTimeInput < StartTimeInput)
            {
                //日を跨ぐ際の場合分け
                if (EndTimeInput > TargetTimeInput)
                {
                    TargetTimeCalc += 24;
                }
                EndTimeCalc += 24;
            }

            if (StartTimeInput == EndTimeInput)
            {
                //同刻(まる一日とみなす)
                Console.WriteLine(TargetTimeInput+ " o'clock is included from " + StartTimeInput + " o'clock to " + EndTimeInput + " o'clock");
            }
            else
            {
                if (TargetTimeCalc >= StartTimeCalc && TargetTimeCalc < EndTimeCalc)
                    Console.WriteLine(TargetTimeInput + " o'clock is included from " + StartTimeInput + " o'clock to " + EndTimeInput + " o'clock");
                else
                    Console.WriteLine(TargetTimeInput + " o'clock is not included from " + StartTimeInput + " o'clock to " + EndTimeInput + " o'clock");
            }
        }
    }
}