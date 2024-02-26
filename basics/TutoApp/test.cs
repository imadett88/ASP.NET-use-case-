// les types des variables dans C# :

class Program
{
    static void Main(string[] args)
    {
        // Déclaration des variables
        int entier = 10;
        float flottant = 3.14f;
        char caractere = 'A';
        bool vrai = true;
        bool faux = false;
        string chaine = "Bonjour";
        int[] tableau = { 1, 2, 3, 4, 5 };

        // Définition d'une structure Personne
        struct Personne
    {
        public string Nom;
        public int Age;
    }

    // Initialisation d'une variable de type Personne
    Personne personne1;
    personne1.Age = 25;
        personne1.Nom = "Jean";

        // Définition d'une énumération Jours
        enum Jours { Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche };

    // Initialisation d'une variable de type Jours
    Jours jour = Jours.Lundi;

    // Les pointeurs ne sont pas couramment utilisés en C#, ils sont gérés de manière sécurisée par le Garbage Collector
    // et ne sont généralement pas nécessaires dans le code C# standard.

    // Pas d'affichage dans la console dans cette version du code
}
}



//___________________________________________________________________________________________________________________________________________________________

class Program
{
    static void Main(string[] args)
    {
        // Opérateurs arithmétiques
        int a = 10;
        int b = 5;
        int resultatAddition = a + b;
        int resultatSoustraction = a - b;
        int resultatMultiplication = a * b;
        int resultatDivision = a / b;
        int resultatModulo = a % b;

        // Opérateurs de comparaison
        bool estEgal = (a == b);
        bool estDifferent = (a != b);
        bool estSuperieur = (a > b);
        bool estInferieur = (a < b);
        bool estSuperieurOuEgal = (a >= b);
        bool estInferieurOuEgal = (a <= b);

        // Opérateurs logiques
        bool condition1 = true;
        bool condition2 = false;

        bool resultatEt = condition1 && condition2;
        bool resultatOu = condition1 || condition2;
        bool resultatNon = !condition1;

        // Opérateurs d'incrémentation et de décrémentation
        int x = 5;
        int y = 10;

        x++;
        y--;

        // Opérateur ternaire
        int age = 20;
        string message = (age >= 18) ? "Majeur" : "Mineur";
    }
}


//________________________________________________________________________________________________________________________________________________________________________________________________

using System;

class Program
{
    static void Main(string[] args)
    {
        // Instruction conditionnelle if
        int x = 10;
        if (x > 5)
        {
            Console.WriteLine("x est supérieur à 5");
        }

        // Instruction conditionnelle if-else
        int y = 3;
        if (y > 5)
        {
            Console.WriteLine("y est supérieur à 5");
        }
        else
        {
            Console.WriteLine("y est inférieur ou égal à 5");
        }

        // Instruction conditionnelle if-else if-else
        int z = 7;
        if (z > 10)
        {
            Console.WriteLine("z est supérieur à 10");
        }
        else if (z > 5)
        {
            Console.WriteLine("z est supérieur à 5 mais inférieur ou égal à 10");
        }
        else
        {
            Console.WriteLine("z est inférieur ou égal à 5");
        }

        // Boucle for
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"for : {i}");
        }

        // Boucle while
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine($"while : {j}");
            j++;
        }

        // Boucle do-while
        int k = 0;
        do
        {
            Console.WriteLine($"do-while : {k}");
            k++;
        } while (k < 5);
    }
}


//________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________

using System;

class Program
{
    static void Main(string[] args)
    {
        // Appel de la méthode Conditionnelle
        Conditionnelle();

        // Appel de la méthode Boucles
        Boucles();
    }

    // Méthode illustrant les instructions conditionnelles
    static void Conditionnelle()
    {
        // Instruction conditionnelle if
        int x = 10;
        if (x > 5)
        {
            Console.WriteLine("x est supérieur à 5");
        }

        // Instruction conditionnelle if-else
        int y = 3;
        if (y > 5)
        {
            Console.WriteLine("y est supérieur à 5");
        }
        else
        {
            Console.WriteLine("y est inférieur ou égal à 5");
        }

        // Instruction conditionnelle if-else if-else
        int z = 7;
        if (z > 10)
        {
            Console.WriteLine("z est supérieur à 10");
        }
        else if (z > 5)
        {
            Console.WriteLine("z est supérieur à 5 mais inférieur ou égal à 10");
        }
        else
        {
            Console.WriteLine("z est inférieur ou égal à 5");
        }
    }

    // Méthode illustrant les boucles
    static void Boucles()
    {
        // Boucle for
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"for : {i}");
        }

        // Boucle while
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine($"while : {j}");
            j++;
        }

        // Boucle do-while
        int k = 0;
        do
        {
            Console.WriteLine($"do-while : {k}");
            k++;
        } while (k < 5);
    }
}



//___________________________________________________________________________________________________________________________________________________________________________________________________

using System;

class Program
{
    static void Main(string[] args)
    {
        // Déclaration et initialisation d'un tableau
        int[] numbers = { 4, 2, 8, 1, 6 };

        // Méthode Array.Sort() - Trie les éléments du tableau dans l'ordre croissant
        Array.Sort(numbers); // numbers deviendra { 1, 2, 4, 6, 8 }

        // Méthode Array.Reverse() - Inverse l'ordre des éléments du tableau
        Array.Reverse(numbers); // numbers deviendra { 8, 6, 4, 2, 1 }

        // Méthode Array.IndexOf() - Recherche un élément spécifique dans un tableau et renvoie son index
        int index = Array.IndexOf(numbers, 6); // index sera 1

        // Méthode Array.Exists() - Vérifie si un élément satisfait une condition spécifique
        bool exists = Array.Exists(numbers, element => element > 3); // exists sera true

        // Méthode Array.Copy() - Copie une plage d'éléments d'un tableau source vers un tableau cible
        int[] targetArray = new int[3];
        Array.Copy(numbers, 1, targetArray, 0, 3); // targetArray deviendra { 6, 4, 2 }

        // Méthode Array.Clear() - Efface une plage d'éléments d'un tableau et les initialise à leur valeur par défaut
        Array.Clear(numbers, 1, 3); // numbers deviendra { 8, 0, 0, 0, 1 }

        // Méthode Array.Resize() - Redimensionne un tableau
        Array.Resize(ref numbers, 5); // numbers deviendra { 8, 0, 0, 0, 1 }

        // Méthode Array.Fill() - Remplit tous les éléments du tableau avec une valeur spécifique
        Array.Fill(numbers, 10); // numbers deviendra { 10, 10, 10, 10, 10 }

        // Affichage du contenu du tableau après les opérations
        Console.WriteLine("Contenu du tableau après les opérations :");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}


//__________________________________________________________________________________________________________________________________________________________________________________________________

// POO : 

using System;

class Personne
{
    // Champs de la classe
    public string Nom;
    public int Age;

    // Constructeur par défaut
    public Personne()
    {
        Nom = "John Doe";
        Age = 30;
    }

    // Constructeur surchargé
    public Personne(string nom, int age)
    {
        Nom = nom;
        Age = age;
    }

    // Constructeur par copie
    public Personne(Personne personne)
    {
        Nom = personne.Nom;
        Age = personne.Age;
    }

    // Méthode pour afficher les informations de la personne
    public void AfficherInfo()
    {
        Console.WriteLine($"Nom : {Nom}, Age : {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Utilisation du constructeur par défaut
        Personne personne1 = new Personne();
        personne1.AfficherInfo(); // Affichera "Nom : John Doe, Age : 30"

        // Utilisation du constructeur surchargé
        Personne personne2 = new Personne("Alice", 25);
        personne2.AfficherInfo(); // Affichera "Nom : Alice, Age : 25"

        // Utilisation du constructeur par copie
        Personne personne3 = new Personne(personne2);
        personne3.AfficherInfo(); // Affichera "Nom : Alice, Age : 25"
    }
}
