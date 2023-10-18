namespace RockPaperScissors.Core
{
    public class Moves
    {
        public static void MakeMove(Player player)
        {
            Notification.ShowMessage(MessageType.MakeMove,null,null);
            player.Move = GetMove(player);
        }
        public static Choice GetMove(Player player)
        {
            int inputNum = Logic.CheckNumber(Console.ReadLine());
            if (Enum.IsDefined(typeof(Choice), inputNum))
            {
                return (Choice)inputNum;
            }
            else
            {
                // Throw Error
                return GetMove(player);
            }
        }
        public static void SetNPCMove(Player NPC)
        {
            Random random =new();
            NPC.Move = (Choice)random.Next(1, 4);
        }
    }
}
