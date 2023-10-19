namespace RockPaperScissors.Engine
{
    internal class Game
    {
        public static void Start()
        {
            var player = Player.PlayerCreate(MessageType.SetName);
            var NPC = Player.PlayerCreate(MessageType.SetNPC);
            Notification.ShowMessage(MessageType.Welcome,player.Name,null);
            while (true)
            {
                Moves.MakeMove(player);
                Moves.SetNPCMove(NPC);
                Logic.ShowResult(player, NPC);
                
            }
        }
    
    }
}
