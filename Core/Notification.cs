namespace RockPaperScissors.Core
{
    public class Notification : INotification
    {
        public void ShowMessage(MessageType messageType, object x, object y)
        {
            string messageText = GetMessage(messageType, x, y);
            Console.WriteLine(messageText);
        }

        private string GetMessage(MessageType messageType, object x, object y)
        {
            switch (messageType)
            {
                case MessageType.Welcome:
                    return "Willkommen im Spiel.";
                case MessageType.Quit:
                    return "Beende das Spiel";
                case MessageType.SetName:
                    return "Wie heißt du?";
                case MessageType.SetNPC:
                    return "Setze den Namen des NPC's";
                case MessageType.MakeMove:
                    return "Wähle zwischen Schere Stein und Papier";
                case MessageType.SumMove:
                    return $"Du hast {x} und dein Gegner hat {y} gewählt";
                case MessageType.ResultMoveWin:
                    return $"Der Move von {x} \"{y}\" hat gewonnen";
                case MessageType.ResultMoveDraw:
                    return "Gleichstand! Keiner hat diese Runde gewonnen.";
                case MessageType.ResultGame:
                    return "???????";
                case MessageType.Points:
                    return $"Du hast {x} Punkte. \t Dein Gegner hat {y} Punkte";
                default:
                    return "Unbekannte Eingabe.";
            }
        }
    }
}
