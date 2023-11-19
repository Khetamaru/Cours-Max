using Cours_c_.Actions;
using Cours_c_.Objects;

internal class Program
{
    private static void Main(string[] args)
    {
        Chat chat = new Chat("Matou", 6, 20.4);

        AnimalActions.ExpositionAnimal(chat);
        FelinActions.ExpositionFelin(chat);
        ChatActions.ExpositionChat(chat);
    }
}