﻿/*

int aa1 = 1, aa2 = 3, aa3 = 3, aa4 = 7, aa5 = 5;
float aa6 = (float)(aa1 + aa2 + aa3 + aa4 + aa5) / 5;
Console.WriteLine(aa6);

//.......

Console.Write("Add meg a kör sugarát: ");
string aa7 = Console.ReadLine();
float aa8 = float.Parse(aa7);
float aa9 = 3.14f;
float aa_kerulet = 2*aa8*aa9;
float aa_terulet = aa8*aa8*aa9;
Console.WriteLine("A kerülete: " + aa_kerulet + " a területe pedig: " + aa_terulet);

//int-et irtam, float kell, javitva, Writeline- nagy L, előtte pont, float f lefelejtve, “ nem jó, " a jó

//.........

Console.WriteLine("Adj meg egy egész számot: ");
string aaa9 = Console.ReadLine();
int number = int.Parse(aaa9);

int aa10 = 0;
for (int aa11 = 1; aa11 <= number; aa11++)
{
    aa10 += aa11;
}

Console.WriteLine("számok összege: " + aa10);

// belekeveredtem mit és hova. Alap és kód megvolt, mégis, plusz kapcsos / Ha egy változót csak a cikluson belül hozok létre, akkor csak ott létezik

//...........,

Console.WriteLine ("Adj meg egy egész számot: ");
string aa12=Console.ReadLine();
int number1 =int.Parse(aa12);

for (int aa13=1; aa13<=number1; aa13++)
{

if (aa13 % 3 == 0 && aa13 % 5 == 0)
{
Console.WriteLine("fizzbuzz");
}

else if (aa13 % 3 == 0)
{
Console.WriteLine("fizz");
}

else if (aa13 % 5 == 0)
{
Console.WriteLine("buzz");
}

else
{
Console.WriteLine(aa13);
}

}

//a megoldás bool-t használ, lássuk így jó?

//....................

for (int aa14=1; aa14<=10; aa14++)
{
 for (int aa15=1; aa15<=10; aa15++)
  {
//      Console.WriteLine (aa14 + aa14aa15);

Console.WriteLine($"{aa14} x {aa15} = {aa14*aa15}");
  }
 }

//.........................

*/