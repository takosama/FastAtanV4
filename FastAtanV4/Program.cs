﻿using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        Stopwatch sw = new Stopwatch();
        for (int i = 0; i < 10000000; i++)
        {
            i++;
            i--;
        }
        double ans = 0;
        for (int c = 0; c < 10; c++)
        {
            sw.Start();

            for (int i = 0; i < 10000000; i++)
            {
              //  ans = Math.Atan(i * 0.01);
                ans = Atan.Compute (i*0.01);

        //        Console.WriteLine((i*0.01) +"誤差= " + (ans-ans1));

                //      ans = Math.Cos(0.01 * i);
                //   ans = Cos.Compute(0.01f * i);


            }

            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine(ans);
            Console.WriteLine();
            sw.Reset();
        }
    }
}

static class Atan
{

    public static double Compute(double x)
    {
        if (x > -2.0 && x < 2.0)
            return Math.Atan(x);
        if (x < 0)
            return -1.57079633 - 1.0 / x + 0.33333333 / (x * x * x);
        else
            return 1.57079633 - 1.0 / x + 0.33333333 / (x * x * x);
    }
}


