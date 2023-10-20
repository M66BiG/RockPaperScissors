#pragma warning disable CS8625
namespace RockPaperScissors.Core
{
    public class Player : IPlayer
    {
        public virtual string? Name { get; set; }
        public int Points { get; set; } = 0;
        public SSP Move { get; set; }
        public PlayerType Type { get; set; }

        public static Player PlayerCreate(MessageType messageType, PlayerType type)
        {
            Notification.ShowMessage(messageType, null, null);
            Player Neu = new()
            {
                Name = Console.ReadLine(),
                Type = type
            };
            return Neu;
        }
    }
}