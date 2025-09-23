public class Program
{
 
    private bool gameOver = false;
    private Dictionary<string, Room> allrooms;

    static void Main() 
    {
        Game game = new Game();
        game.Start();

    }
}
public class Game
{
    public void Start()
    {
        Room startRoom = new Room();
        startRoom.startRoom();
        

        
        Room castle = new Room();

    }
    public void Forest() 
    {
        Room Startforest = new Room();
        Startforest.Startforest();
    }
   
}
