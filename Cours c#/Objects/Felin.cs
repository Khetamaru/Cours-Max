using Cours_c_.Interfaces;

namespace Cours_c_.Objects
{
    public class Felin : IAnimal
    {
        private string _nom;
        private int _age;
        private double _poid;

        public Felin(string nom, int age, double poid) 
        {
            _nom = nom;
            _age = age;
            _poid = poid;
        }

        void IAnimal.Courir()
        {
            Console.WriteLine("Cours");
        }

        void IAnimal.Dormir()
        {
            Console.WriteLine("Dors");
        }

        void IAnimal.Marcher()
        {
            Console.WriteLine("Marche");
        }

        internal void Description()
        {
            Console.WriteLine("Nom : " + _nom + " / Age : " + _age + " / Poid : " + _poid + " Kg");
        }
    }
}
