using OOPAssignment;
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
        Console.WriteLine("rum 1 du står vid en ruin och kan bara gå norr");
        direction = Console.ReadLine();
        if (direction == "gå norr") 
        { 
            Console.WriteLine("du har kommit in i en mörk skog och hittar en svärd och kan bara gå öster");
            loot = Console.ReadLine();
            if(loot=="ta svärd") 
            { 
                itemsadd.Insert(0, "svärd");
            }
            else if (loot == "gå öster")
            {
                Game game = new Game();
                game.Forest();
            }

        }
        else
            Environment.Exit(0);
        direction = Console.ReadLine();
        if (direction == "gå öster")
        {
            Game game = new Game();
            game.Forest();
        }



    }
    public void Startforest() 
    {
        Console.WriteLine("du har kommit till rum2");
        String titta = Console.ReadLine();
        if (titta == "titta") 
        {
            Console.WriteLine("du har kommit till en mörkare och mer skrämmande skog du kan gå norr");
            direction = Console.ReadLine();
            if (direction == "gå norr")
            {
                Console.WriteLine("du gick norr ");
            }
            else if (direction == "gå väster")
            {
                startRoom();
            }
            else if (direction == "Inventory") 
            {
                Inventory invhelp = new Inventory();
                invhelp.invdisplay();
            }

        }
    }
}

