namespace RockPaperScissors.Core
{
    public class Notification : INotification
    {
        public static void ShowMessage(MessageType messageType, object x, object y)
        {
            string messageText = GetMessage(messageType, x, y);
            Console.WriteLine(messageText);
        }
        private static string GetMessage(MessageType messageType, dynamic x, object y) =>
        
            messageType switch
            {
                MessageType.Welcome => $"Willkommen im Spiel: {x}.",
                MessageType.Quit => "Beende das Spiel",
                MessageType.SetName => "Wie heißt du?",
                MessageType.SetNPC => "Setze den Namen des NPC's",
                MessageType.MakeMove => "Wähle zwischen:\n1: Stein \n2: Papier \n3: Schere",
                MessageType.SumMove => $"Du hast {x} gewählt und dein Gegner hat {y} gewählt",
                MessageType.ResultMoveWin => $"Der Move von {x} \"{y}\" hat gewonnen",
                MessageType.ResultMoveDraw => "Gleichstand! Keiner hat diese Runde gewonnen.",
                MessageType.ResultGame => "???????",
                MessageType.Points => $"Du hast {x} Punkte. \t Dein Gegner hat {y} Punkte",
                _ => "Unbekannte Eingabe.",
            };
        
    }
}
