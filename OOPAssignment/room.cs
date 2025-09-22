using System;
using System.Globalization;
class room

{
    String direction { get; set; }
    public int roomnumber { get; set; }
    String yesno { get; set; }
    List<string> itemsadder = new List<string>();


    public void roomoutput()
    {
        Console.WriteLine("du står vid en gammal ruin du kan bara gå norr");
        Console.WriteLine("vill du gå norr?");
        direction = Console.ReadLine();
        rum1(direction);
        


    }
    private void rum1(String x)
    {
        if (x == "gå norr") {
            Console.WriteLine("du är i rum " + roomnumber++);
            Console.WriteLine(" du går norr och kommer till en skog i skogen det finns konstiga ljud i skogen det ligger ett svärd på marken ");
         
            yesno = Console.ReadLine();
            if (yesno == "ta svärd") 
            {
            Console.Write("du tog svärdet och kan välja mellan att gå syd och väst ");
                itemsadder.Add("Svärd");
                direction = Console.ReadLine();

            }
            else
            {
            Console.WriteLine("du tog inte svärd och kan välja mellan att gå syd och väst ");
                direction = Console.ReadLine();
            }
            rum2(direction);
        }
        else
        {
         Console.WriteLine("du står kvar vid ruinen");
            return;
        }
    }
    private void rum2(String y)
    {
        if (y == "gå väst")
        {
            Console.WriteLine("du gick väst");
            String titta = Console.ReadLine();
            if (titta == "titta")
                Console.WriteLine("du är i en mörk källare med en fackla framför dig");
        }
        else {
            Console.WriteLine("du gick syd");
        }
    }
    
}


