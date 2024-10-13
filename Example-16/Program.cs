double DaireAlan(double yariCap)
{
    return Math.PI * yariCap * yariCap;
}

Console.Write("Yarıçap: ");
double cap = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Alan: " + DaireAlan(cap));