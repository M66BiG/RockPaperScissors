using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Shared
{
    public interface INotification
    {
        void ShowMessage(MessageType messageType, object x, object y);

    }
}
