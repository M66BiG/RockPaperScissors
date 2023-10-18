namespace RockPaperScissors.Engine
{
    internal class Game
    {
        public static void Start()
        {

            var player = Player.SetPlayerData();
            var NPC = Player.SetNPCData();
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
