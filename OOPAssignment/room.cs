using System;
 class room
 {
    String direction { get; set; }

    public void roomoutput()
    { 
        Console.WriteLine("du står vid en gammal ruin du kan bara gå norr");
        Console.WriteLine("vill du gå norr?");
        direction = Console.ReadLine();
        north(direction);
        Console.WriteLine("du");


    }
    static void north(String x)
    {
        if (x == "gå norr")
         Console.WriteLine("du går norr och kommer till en skog i skogen det finns konstiga ljud i skogen");
        else
         Console.WriteLine("du står kvar vid ruinen");
        Environment.Exit(0);

    }
}

