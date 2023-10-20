using RockPaperScissors.Core;

namespace RockPaperScissors.Engine
{
    internal class Game
    {
        public static void Start()
        {
            var player = Player.PlayerCreate(MessageType.SetName, PlayerType.Human);
            var NPC = Player.PlayerCreate(MessageType.SetNPC, PlayerType.NPC);
            Notification.ShowMessage(MessageType.Welcome,player.Name,null);
            while (player.Points != 3 && NPC.Points != 3)
            {
                Moves.MakeMove(MessageType.MakeMove, player);
                Moves.MakeMove(null, NPC);
                Logic.ShowResult(player, NPC);
            }
            Stop(MessageType.Quit);
        }
        public static void Stop(MessageType messageType)
        {
            Logic logic = new();
            Notification.ShowMessage(messageType, null, null);
            int inputNum = logic.CheckNumber(Console.ReadLine());
            if (Enum.IsDefined(typeof(Choice), inputNum))
            {
                if ((Choice)inputNum == Choice.Ja)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Start();
                }
            }
            else
            {
                // Throw Error
                Stop(MessageType.Quit);
            }
        }
    
    }
}
