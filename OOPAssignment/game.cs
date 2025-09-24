using System;
using System.Collections.Generic;//avänds för listan

public class Program
{
    

    static void Main() 
    {
        Console.WriteLine("du leter efter en diamant vin spelet genom att hitta den");
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
        Room skogen = new Room("skog rum2", "du står i en mörk skog. och kan gå öster och syd för att gå tillbaks ", new List<Item>());
        Room mörkskog = new Room("mörkskog rum3", "du är i en mörkare skog och ser ett svärd gå norr och väster för att kommatillbaks.", new List<Item> { svärd, });
        Room slott = new Room("slott rum4", "du är i ett slott och kan gå norr eller syd för att kommatillbaks", new List<Item>());
        Room bossroom = new Room("slott rum5", "du är i ett slott och ser en diamant och kan bara gå  syd för att kommatillbaks", new List<Item>());


        rooms["start"] = start;
        rooms["skog"] = skogen;
        rooms["mörkskog"] = mörkskog;
        rooms["slott"] = slott;
        rooms["bossroom"] = bossroom;

        //chatgpts idee
        start.Exits["norr"] = "skog";
        skogen.Exits["syd"] = "start";
        skogen.Exits["öster"] = "mörkskog";
        mörkskog.Exits["väster"] = "skog";
        mörkskog.Exits["norr"] = "slott";
        slott.Exits["syd"] = "mörkskog";
        slott.Exits["norr"] = "bossroom";
        slott.Exits["syd"] = "slott";



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
        else if (input.Contains("ta s"))
        {
            //Console.WriteLine("du tog " + Item.Name);
            Console.WriteLine("du tog svärd");
        }
        //denna else if statsen hjälpte chatgpt till med för att navigerea rummen
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
        else if (input.Contains("ta d"))
        {
            Console.WriteLine("grattis du har vunnit ");
            gameOver = true;
        }


    }
}

