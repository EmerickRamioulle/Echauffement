namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        //

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Bonjour, Mon nom est Emerick et mon jeu préféré est Ultrakill");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Qu'elle est ton nom ? ");
            string name = Console.ReadLine();
        Console.WriteLine("Qu'elle est ton age ? ");
            int age = Convert.ToInt32(Console.ReadLine());


        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age < 18)
        {
            Console.WriteLine("Tu es mineur");
        }
        else
        {
            Console.WriteLine("Tu es majeur");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
            Console.WriteLine("Combien d'euro as-tu ? ");
                float money = float.Parse(Console.Readline());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
            Console.WriteLine("Choisis une des armes ! ");
            Console.WriteLine("Arme 1 50.50 euros");
            Console.WriteLine("Arme 2 40.65 euros");
            Console.WriteLine("Arme 3 90.47 euros");
            Console.WriteLine("Arme 4 77.12 euros");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
            Console.WriteLine("choisis l'une de ces 4 armes en indiquant un nombre entre 1 et 4 ! ");
                int choix = Convert.ToInt32(Console.ReadLine()); 
                float prix = 0;
            if (choix == 1) prix = 50.50f;
            else (choix == 2) prix = 40.65f;
            else (choix == 3) prix = 90.47f;
            else (choix == 4) prix = 77.12f;

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
            if (money >= prix) ;
        {
            Console.WriteLine("Achat effectué avec succès !");
        }
            else
        {
            Console.WriteLine("Votre achat n'a pas pu être effectuer.");
        }

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}