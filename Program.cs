// Sous-programme AfficherAccueil
// Affiche un message de bienvenue avec la date et l'heure actuelle
// Aucun paramètre, aucune valeur de retour
void AfficherAccueil()
{
    Console.WriteLine("==============================================");
    Console.WriteLine("  Bienvenue dans le convertisseur de minutes  ");
    Console.WriteLine($"  Nous sommes le {DateTime.Now}");
    Console.WriteLine("==============================================");
}

// Sous-programme ConvertisseurMinutes
// Convertit un nombre de minutes au format H:M
// Paramètre d'entrée :
//   - minutes : nb de minutes à convertir
// Pas de valeur de retour (affichage direct)
void convertisseurMinutes(int minutes)
{
    int Heures = (minutes / 60);
    int Minutes = minutes - (Heures * 60);
    Console.WriteLine($"lheure est {Heures}:{Minutes}");
}

// Programme principal
AfficherAccueil();
Console.WriteLine("Donner les minutes");
int m = Convert.ToInt32(Console.ReadLine());
convertisseurMinutes(m);