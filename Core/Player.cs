#pragma warning disable CS8625
namespace RockPaperScissors.Core
{
    public class Player : IPlayer
    {
        public virtual string? Name { get; set; }

        public int Points { get; set; } = 0;


        public static Player SetPlayerData()
        {
            Notification n = new Notification();
            n.ShowMessage(MessageType.SetName, null, null);
            Player player = new Player();
            player.Name = Console.ReadLine();
            return player;
        }

        public static Player SetNPCData()
        {
            Notification n = new Notification();
            n.ShowMessage(MessageType.SetNPC, null, null);
            Player NPC = new Player();
            NPC.Name = Console.ReadLine();
            return NPC;
        }
    }

    

}