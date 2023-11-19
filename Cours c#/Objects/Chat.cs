
namespace Cours_c_.Objects
{
    public class Chat : Felin
    {
        public Chat(string nom, int age, double poid) : base(nom, age, poid)
        {
        }

        internal void Griffer()
        {
            Console.WriteLine("Griffure");
        }
    }
}
