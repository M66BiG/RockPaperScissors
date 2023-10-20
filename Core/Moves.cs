namespace RockPaperScissors.Core
{
    public class Moves
    {
        public static void MakeMove(dynamic messageType, Player player)
        {
            Moves move = new();
            if(player.Type == PlayerType.Human)
            {
                
                Notification.ShowMessage(messageType, null, null);
                player.Move = move.GetMove(player);
            }
            else
            {
                Random random = new();
                player.Move = (SSP)random.Next(1, 4);
            }
        }
        public SSP GetMove(Player player)
        {
            Logic logic = new();
            int inputNum = logic.CheckNumber(Console.ReadLine());
            if (Enum.IsDefined(typeof(SSP), inputNum))
            {
                return (SSP)inputNum;
            }
            else
            {
                // Throw Error
                return GetMove(player);
            }
        }
    }
}
