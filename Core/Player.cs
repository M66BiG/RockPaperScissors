#pragma warning disable CS8625
namespace RockPaperScissors.Core
{
    public class Player : IPlayer
    {
        public virtual string? Name { get; set; }
        public int Points { get; set; } = 0;
        public Choice Move { get; set; }
        public static Player SetPlayerData()
        {
            Notification.ShowMessage(MessageType.SetName, null, null);
            Player player = new()
            {
                Name = Console.ReadLine()
            };
            return player;
        }
        public static Player SetNPCData()
        {
            Notification.ShowMessage(MessageType.SetNPC, null, null);
            Player NPC = new()
            {
                Name = Console.ReadLine()
            };
            return NPC;
        }

    }
}