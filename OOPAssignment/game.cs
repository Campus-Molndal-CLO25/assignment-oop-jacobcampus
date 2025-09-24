using System;
using System.Collections.Generic;//avänds för listan

public class Program
{
    

    static void Main() 
    {
        Game game = new Game();
        game.Start();

    }
}
public class Game
{
    public Dictionary<string, Room> rooms = new Dictionary<string, Room>();
    public List<Item> inventory = new List<Item>();
    public Room currentRoom;
    public string Description;
    public bool gameOver = false;
    public void Start()
    {
        CreateWorld();
     
        while (!gameOver)
        {
            Console.WriteLine(currentRoom.Description);
            Console.Write("> ");
            string input = Console.ReadLine().ToLower();
            Input(input);


        }


    }
    private void CreateWorld()
    {

        var svärd = new Item("svärd", "ett silver svärd.");
        var diamant = new Item("diamant", "en stort diamant =victory");

        Room start = new Room("start rum1", "du står vid en ruin och kan bara gå norr", new List<Item>());
        Room skogen = new Room("skog rum2", "du står i en mörk skog. och kan gå öster och syd ", new List<Item>());
        Room mörkskog = new Room("grotta rum3", "du är i en mörkare skog och ser ett svärd.", new List<Item> { svärd, });

        rooms["start"] = start;
        rooms["skog"] = skogen;
        rooms["mörkskog"] = mörkskog;

        //chatgpts idee
        start.Exits["norr"] = "skog";
        skogen.Exits["syd"] = "start";
        skogen.Exits["öster"] = "mörkskog";
        mörkskog.Exits["väster"] = "skog";


        currentRoom = start;
    }


    private void Input(String input)
    {
        if (input == "hjälp")
        {

            Console.WriteLine("du kan gå i en riktning du kan skriva inventory för att visa inverntory du kan ta item");

        }
        else if (input == "titta")
        {
            Console.WriteLine(currentRoom.Name);
            Console.WriteLine(currentRoom.Description);

        }
        else if (input == "inventory")
        {
            Console.Write(inventory);
        }
        else if (input.Contains("ta"))
        {
            //Console.WriteLine("du tog " + Item.Name);
        }
        //denna else if statsen hjälpte chatgpt till med 
        else if (input.StartsWith("gå "))
        {
            string riktning = input.Substring(3); // plockar ut t.ex. "norr"
            if (currentRoom.Exits.ContainsKey(riktning))
            {
                string nästaRumNamn = currentRoom.Exits[riktning];
                currentRoom = rooms[nästaRumNamn];
                Console.WriteLine("Du går " + riktning + "...");
            }
            else
            {
                Console.WriteLine("Du kan inte gå åt det hållet.");
            }
        }


    }
}

