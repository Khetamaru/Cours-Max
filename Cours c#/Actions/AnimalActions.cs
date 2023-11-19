using Cours_c_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_c_.Actions
{
    public static class AnimalActions
    {
        public static void ExpositionAnimal(IAnimal animal)
        {
            animal.Dormir();
            animal.Courir();
            animal.Marcher();
        }
    }
}
