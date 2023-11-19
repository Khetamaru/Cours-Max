using Cours_c_.Interfaces;
using Cours_c_.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_c_.Actions
{
    public static class FelinActions
    {
        public static void ExpositionFelin(Felin felin)
        {
            (felin as IAnimal).Marcher();
            (felin as IAnimal).Dormir();
            (felin as IAnimal).Courir();
            felin.Description();
        }
    }
}
