namespace RockPaperScissors.Core
{
    public class Logic
    {
        public static int CheckNumber(string a)
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
            Result result = GetRoundResult(player.Move, NPC.Move);
            switch (result)
            {
                case Result.Lose:
                    Notification.ShowMessage(MessageType.SumMove, player.Move, NPC.Move);
                    Notification.ShowMessage(MessageType.ResultMoveWin, NPC.Name, NPC.Move);
                    break;
                case Result.Win:
                    Notification.ShowMessage(MessageType.SumMove, player.Move, NPC.Move);
                    Notification.ShowMessage(MessageType.ResultMoveWin, player.Name, player.Move);
                    break;
                case Result.Draw:
                    Notification.ShowMessage(MessageType.SumMove, player.Move, NPC.Move);
                    Notification.ShowMessage(MessageType.ResultMoveDraw,null,null);
                    break;
                default:
                    break;
            }
        }
        public static Result GetRoundResult(Choice player, Choice NPC)
        {
            switch (player)
            {
                case Choice.Stein:
                    return NPC == Choice.Schere ? Result.Win : NPC == Choice.Papier ? Result.Lose : Result.Draw;
                case Choice.Papier:
                    return NPC == Choice.Stein ? Result.Win : NPC == Choice.Schere ? Result.Lose : Result.Draw;
                case Choice.Schere:
                    return NPC == Choice.Papier ? Result.Win : NPC == Choice.Stein ? Result.Lose : Result.Draw;
                default: 
                    return Result.Draw;
            }
        }
    }
}
