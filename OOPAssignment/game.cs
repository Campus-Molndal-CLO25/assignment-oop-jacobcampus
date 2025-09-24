using System;
using System.Collections.Generic;

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
    public bool gameOver = false;
    public void Start()
    {
        CreateWorld();
        Console.WriteLine(currentRoom.Name);
        Console.WriteLine(currentRoom.Description);



    }
    private void CreateWorld()
    {
        
        var svärd = new Item("svärd", "ett silver svärd.");
        var diamant = new Item("diamant", "en stort diamant – victory");

        Room start = new Room("start", "du står vid en ruin.", new List<Item>());
        Room skogen = new Room("skog", "du står i en mörk skog.", new List<Item>());
        Room mörkskog = new Room("grotta", "du är i en mörkare skog och ser ett svärd.", new List<Item> { svärd, });
        
        currentRoom = start;
    }
   
    
   
}
