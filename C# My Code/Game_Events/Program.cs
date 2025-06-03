namespace Game_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Audio audio = new Audio();
            Rendering rendering = new Rendering();
            Player p1 = new Player("p1");
            Player p2 = new Player("p2");

            GameManger.starttrigger();
            Console.WriteLine("Play Now");
            Console.ReadLine();
            GameManger.endtrigger();

        }
    }
}
