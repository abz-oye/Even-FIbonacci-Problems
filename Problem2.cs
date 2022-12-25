Console.WriteLine("How many test cases would you like to run? ");

int t = Convert.ToInt32(Console.ReadLine());
for (int a0 = 0; a0 < t; a0++)
{
    Console.WriteLine("\nEnter the integer: ");
    long n = Convert.ToInt64(Console.ReadLine());
    long[] fibSeq = new long[n];
    List<long> fibEven = new List<long>();
    List<long> fibSeqN = new List<long>();
    int total = 0;

    fibSeq[0] = 0;
    fibSeq[1] = 1;

    fibSeqN.Add(fibSeq[0]);
    fibSeqN.Add(fibSeq[1]);

    for (var i = 2; i < n; i++)
    {
        fibSeq[i] = fibSeq[i - 1] + fibSeq[i - 2];
        if (fibSeq[i] < n && fibSeq[i] > 0)
        {
            fibSeqN.Add(fibSeq[i]);
        }
    }

    //Console.WriteLine($"\nFibonacci Sequence Below {n}: ");
    //foreach (var y in fibSeqN)
    //{
    //    Console.WriteLine(y);
    //}


    for (var x = 2; x < fibSeqN.Count; x++)
    {
        if (fibSeqN[x] % 2 == 0)
        {
            fibEven.Add(fibSeqN[x]);
        }
    }

    //Console.WriteLine($"\nEVEN Numbers of the Fibonacci Sequence Below {n}: ");
    //foreach (int e in fibEven)
    //{
    //    Console.WriteLine(e);
    //}

    foreach (int v in fibEven)
    {
        total = total + v;
    }

    Console.WriteLine($"\nTotal = {total}");
}
Console.ReadLine();
