﻿using CSharpAsynchExample.ConsolePrinter;
using CSharpAsynchExample.ExampleBase;

namespace CSharpAsynchExample
{
    internal class Example01 : ThreadAnalysis, IExample
    {
        private int ratio = 1;

        protected override async Task Main()
        {
            var task01 = Work01();

            var timeElapsed = 0;
            var interval = ratio*10;
            var name = "Main";
            for (int i = 0; i < 12; i++)
            {
                Task.Delay(ratio * 50).Wait();
                timeElapsed += interval;
                MethodLogger.WriteLine(name + " :" + timeElapsed);
            }
        }

        private async Task Work01()
        {
            await Work02();
        }

        private async Task Work02()
        {
            var timeElapsed = 0;
            var interval = ratio * 10;
            var name = "Work02";
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(interval);
                timeElapsed += interval;
                MethodLogger.WriteLine(name + " :" + timeElapsed);
            }
        }
    }
}
