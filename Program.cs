void convertisseurMinutes(int minutes)
{
    int Heures = (minutes / 60);
    int Minutes =  minutes - (Heures * 60);
    Console.WriteLine($"lheure est {Heures}:{Minutes}" );
}
    
Console.WriteLine("Donner les minutes");
int m = Convert.ToInt32(Console.ReadLine());

convertisseurMinutes(m);

