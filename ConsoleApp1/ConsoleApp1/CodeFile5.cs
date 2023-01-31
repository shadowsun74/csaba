/*
// vezérlési szerkezetek

Console.WriteLine("irj be egy számot: ");
string st = Console.ReadLine();
int number = int.Parse(st);

bool isEven; //Páros-e?

isEven = number % 2 == 0;

if (isEven)
{
    Console.WriteLine("PÁROS");
}
else
{
    Console.WriteLine("PÁRATLAN");
}

// nulla, pozitív, negatív

if (number > 0)
{
    Console.WriteLine("POZITÍV");
}
else if (number < 0)
{
    Console.WriteLine("NEGATÍv");
}
else
{
    Console.WriteLine("NULLA");
}

string pairity;
if (isEven)
{
    pairity("PÁROS");
}
else
{
    pairity("PÁRATLAN");
}
Console.WriteLine(pairity);

string pairity2 = isEven ? "PÁROS" : "PÁRATLAN"; // egy sorban csinálom meg azt, amit fent több sorban. Ezt nevezzük feltételes operéátornak. 3 bemenete van.

// ------------------------------------CIKLUS

int i = 0;
while (i < 10)
{
        Console.WriteLine(i);
    i++; // i = i + 1;
}

*/