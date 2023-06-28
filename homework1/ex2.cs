// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число");

int num = Convert.ToInt32 (Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else {
    string str = num.ToString();
    Console.WriteLine(str[2]);
}


