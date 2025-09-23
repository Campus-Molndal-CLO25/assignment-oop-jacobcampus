using System;
using System.Collections.Generic;
using System.Text;

public class Room
{
    String direction {  get; set; }
    String loot { get; set; }
    List<string> itemsadd = new List<string>();

    public void startRoom()
    {
        Console.WriteLine("du står vid en ruin och kan bara gå norr");
        direction = Console.ReadLine();
        if (direction == "gå norr") 
        { 
            Console.WriteLine("du har kommit in i en mörk skog och hittar en svärd och kan bara gå syd");
            loot = Console.ReadLine();
            if(loot=="ta svärd") 
            { 
                itemsadd.Insert(0, "svärd");
            }
            else
            {
                return;
            }

        }
        else
            Environment.Exit(0);
        direction = Console.ReadLine();
        if (direction == "gå syd")
        {
            Game game = new Game();
            game.Start();
        }



    }
}

