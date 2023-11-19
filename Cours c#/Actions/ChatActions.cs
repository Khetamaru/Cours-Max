using Cours_c_.Interfaces;
using Cours_c_.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_c_.Actions
{
    public static class ChatActions
    {
        public static void ExpositionChat(Chat chat)
        {
            (chat as IAnimal).Marcher();
            (chat as IAnimal).Dormir();
            (chat as IAnimal).Courir();
            chat.Description();
            chat.Griffer();
        }
    }
}
