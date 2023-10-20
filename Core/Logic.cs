namespace RockPaperScissors.Core
{
    public class Logic
    {
        public int CheckNumber(string a)
        {
            if (int.TryParse(a, out int inputNum))
            {
                return inputNum;
            }
            else
            {
                //Error
                return 4;
            }
        }
        public static void ShowResult(Player player, Player NPC)
        {
            Logic logic = new();
            Result result = logic.GetRoundResult(player.Move, NPC.Move);
            switch (result)
            {
                case Result.Lose:
                    Notification.ShowMessage(MessageType.SumMove, player.Move, NPC.Move);
                    Notification.ShowMessage(MessageType.ResultMoveWin, NPC.Name, NPC.Move);
                    NPC.Points++;
                    break;
                case Result.Win:
                    Notification.ShowMessage(MessageType.SumMove, player.Move, NPC.Move);
                    Notification.ShowMessage(MessageType.ResultMoveWin, player.Name, player.Move);
                    player.Points++;
                    break;
                case Result.Draw:
                    Notification.ShowMessage(MessageType.SumMove, player.Move, NPC.Move);
                    Notification.ShowMessage(MessageType.ResultMoveDraw,null,null);
                    break;
                default:
                    break;
            }
        }
        public Result GetRoundResult(SSP player, SSP NPC) =>
            player switch
            {
                SSP.Stein => NPC == SSP.Schere ? Result.Win : NPC == SSP.Papier ? Result.Lose : Result.Draw,
                SSP.Papier => NPC == SSP.Stein ? Result.Win : NPC == SSP.Schere ? Result.Lose : Result.Draw,
                SSP.Schere => NPC == SSP.Papier ? Result.Win : NPC == SSP.Stein ? Result.Lose : Result.Draw,
                _ => Result.Draw,
            };
        
    }
}
