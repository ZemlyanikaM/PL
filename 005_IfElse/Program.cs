Console.Write("Enter username:");
string username = Console.ReadLine();

if(username.ToLower() == "mariya")
{
    Console.WriteLine("Ура, ура");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}