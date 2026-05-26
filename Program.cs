// Sous-programme ConvertisseurMinutes
// Convertit un nombre de minutes au format H:M
// Paramètre d'entrée :
//   - minutes : nb de minutes à convertir
// Pas de valeur de retour (affichage direct)
void convertisseurMinutes(int minutes)
{
    int Heures = (minutes / 60);
    int Minutes =  minutes - (Heures * 60);
    Console.WriteLine($"lheure est {Heures}:{Minutes}" );
}
    
Console.WriteLine("Donner les minutes");
int m = Convert.ToInt32(Console.ReadLine());

convertisseurMinutes(m);