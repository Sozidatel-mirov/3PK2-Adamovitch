using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics;


internal class Program
{
    internal class Timing//Реализация класса Timing
    {
        TimeSpan duration;
        TimeSpan[] threads;
        public Timing()
        {
            duration = new TimeSpan(0);
            threads = new TimeSpan[Process.GetCurrentProcess().Threads.Count];
        }
        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            for (int i = 0; i < threads.Length; i++)
                threads[i] = Process.GetCurrentProcess().Threads[i].
                UserProcessorTime;
        }
        public void StopTime()
        {
            TimeSpan tmp;
            for (int i = 0; i < threads.Length; i++)
            {
                tmp = Process.GetCurrentProcess().Threads[i].
                UserProcessorTime.Subtract(threads[i]);
                if (tmp > TimeSpan.Zero)
                    duration = tmp;
            }
        }
        public TimeSpan Result()
        {
            return duration;
        }
    }
    static int SimpleSerch(int[] a, int x)//Простой поиск
    {
        int i = 0;

        while (i < a.Length && a[i] != x)
            i++;
        if (i < a.Length)
        {

            return i;
        }
        else
        {

            return -1;
        }
    }
    static int SearchBinary(int[] a, int x)//Бинарный поиск
    {
        int middle, left = 0, right = a.Length - 1;
        do
        {
            middle = (left + right) / 2;
            if (x > a.Length)
                left = middle + 1;
            else
                right = middle - 1;
        }
        while ((a[middle] != x) && (left <= right));
        if (a[middle] == x)
            return middle;

        else
            return -1;
    }
    private static void Main(string[] args)
    {
        //Генерация массива, списка и хеш-таблицы

        Random rand = new Random();
        int[] array = new int[500000];
        for (int num = 0; num < array.Length; num++)
        {
            array[num] = rand.Next(1, 4315);

        }

        List<int> list = new List<int>(500000);
        for (int j = 0; j < 500000; j++)
        {
            list.Add(rand.Next(1, 4315));
        }

        Hashtable hash = new Hashtable();
        for (int i = 0; i < 500000; i++)
        {
            hash.Add(i, rand.Next(1, 4315));
        }

        int zaglushka1 = 0;
        int zaglushka2 = 0;

        Stopwatch stpWatch = new Stopwatch();
        Timing timing = new Timing();
        Console.WriteLine("Поиск в массиве:");
        Console.WriteLine("Простой:");
        stpWatch.Start();
        timing.StartTime();
        zaglushka1 = SimpleSerch(array, 56);
        stpWatch.Stop();
        timing.StopTime();
        Console.WriteLine($"Stopwatch: {stpWatch.Elapsed} " + $"\nTiming: {timing.Result()}\n");
        stpWatch.Reset();

        stpWatch.Start();
        timing.StartTime();
        zaglushka2 = SearchBinary(array, 56);
        stpWatch.Stop();
        timing.StopTime();
        Console.WriteLine("Бинарный:");
        Console.WriteLine($"Stopwatch: {stpWatch.Elapsed} " + $"\nTiming: {timing.Result()}\n\n");
        stpWatch.Reset();

        Console.WriteLine("Поиск в списке:");
        Console.WriteLine("Простой:");
        stpWatch.Start();
        timing.StartTime();
        zaglushka1 = SimpleSearch(list, 56);
        stpWatch.Stop();
        timing.StopTime();
        Console.WriteLine($"Stopwatch: {stpWatch.Elapsed} " + $"\nTiming: {timing.Result()}\n");
        stpWatch.Reset();

        stpWatch.Start();
        timing.StartTime();
        zaglushka2 = SearchBinary(list, 56);
        stpWatch.Stop();
        timing.StopTime();
        Console.WriteLine("Бинарный:");
        Console.WriteLine($"Stopwatch: {stpWatch.Elapsed} " + $"\nTiming: {timing.Result()}\n\n");
        stpWatch.Reset();
        stpWatch.Reset();

        Console.WriteLine("Поиск в хеш-таблице:");
        stpWatch.Start();
        timing.StartTime();
        hash.ContainsValue(56);
        stpWatch.Stop();
        timing.StopTime();
        Console.WriteLine($"Stopwatch: {stpWatch.Elapsed} " + $"\nTiming: {timing.Result()}\n");
        stpWatch.Reset();




    }
    //Алгоритмы поиска для списков
    static int SimpleSearch(List<int> a, int x)
    {
        int i = 0;
        while (i < a.Count && a[i] != x) i++;
        if (i < a.Count)
        {
            return i;
        }
        else
        {
            return -1;
        }
    }
    static int SearchBinary(List<int> a, int x)
    {
        int middle, left = 0, right = a.Count - 1;
        do
        {
            middle = (left + right) / 2;
            if (x > a.Count)
                left = middle + 1;
            else
                right = middle - 1;
        }
        while ((a[middle] != x) && (left <= right));
        if (a[middle] == x)
            return middle;

        else
            return -1;
    }



    //Вывод
    //Бинарный поиск в массиве при большом количестве элементов быстрее простого, однако в списках он показал себя медленнее.
    //Поиск в хеш-таблице осуществляется намного быстрее(это показал класс timing. Stopwatch показывал почти те же значения.)

}


