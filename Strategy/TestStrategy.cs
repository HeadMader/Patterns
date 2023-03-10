namespace Patterns.Strategy
{
    class TestStrategy
    {
        public static void Test()
        {
            var worker = new Worker();
            worker.DoWork(new HardWork());
            worker.DoWork(new EasyWork());
            Console.ReadKey();

            var secondWorker = new SecondWorker(new HardWork());
            secondWorker.DoWork();
            Console.ReadKey();
        }
    }
}
