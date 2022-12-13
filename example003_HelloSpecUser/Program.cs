Console.WriteLine("Enter yor name");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша")
{
    Console.WriteLine("Урааа! Это же Маша пришла!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}