List<string> allowedSigns = ["kamień","papier","nożyce"];
string  GetCorectSign()
{
    string sign = Console.ReadLine()!;

//while(!firstSign.Equals( !firstSign.Equals(allowedSigns[0],stringComparison) && !firstSign.Equals(allowedSigns[1],stringComparison) && !firstSign.Equals(allowedSigns[2],stringComparison)))
while (!allowedSigns.Contains(sign, StringComparer.OrdinalIgnoreCase))
{
    Console.WriteLine("gracz pierwszy wybiera");
    sign = Console.ReadLine()!;
}
    return sign ;
}




const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;


Console.WriteLine("papier kamień nożyce");

Console.WriteLine($"pierwszy gracz,wybiera znak ({string.Join("/",allowedSigns)})");
string firstSign = Console.ReadLine()!;

//while(!firstSign.Equals( !firstSign.Equals(allowedSigns[0],stringComparison) && !firstSign.Equals(allowedSigns[1],stringComparison) && !firstSign.Equals(allowedSigns[2],stringComparison)))
while (!allowedSigns.Contains(firstSign, StringComparer.OrdinalIgnoreCase))
{
    Console.WriteLine("gracz pierwszy wybiera");
    firstSign = Console.ReadLine()!;
}

Console.WriteLine($"drugi gracz wybiera znak {string.Join("/",allowedSigns)}");
string secondSign = Console.ReadLine()!;


if (firstSign.Equals(secondSign, stringComparison))
{
    Console.WriteLine("remis");
}
else if ((firstSign.Equals  (allowedSigns[0], stringComparison) && secondSign.Equals  (allowedSigns[2] , stringComparison))
|| (firstSign.Equals (allowedSigns[1], stringComparison) && secondSign.Equals (allowedSigns[0], stringComparison))
|| (firstSign.Equals (allowedSigns[2], stringComparison) && secondSign.Equals (allowedSigns[1], stringComparison)))
{
    Console.WriteLine("pierwszy gracz wygrywa");
}
else
{
    Console.WriteLine("drugi gracz wygrywa");
}