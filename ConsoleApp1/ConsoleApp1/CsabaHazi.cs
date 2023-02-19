/*

int aa1 = 1, aa2 = 3, aa3 = 3, aa4 = 7, aa5 = 5;
float aa6 = (float)(aa1 + aa2 + aa3 + aa4 + aa5) / 5; // vagy a másik oldalon írom, hogy 5f
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


/* 
//. 2. házi

// 1. feladat
// Math.Clamp(float, float, float);





float fourth = Clamp1(151, 120, 150);
Console.WriteLine($"{fourth}");

float Clamp1(float one, float two, float three)
{

    if (one >= three)
    {
        return three;
    }

    else if (one <= two)
    {
        return two;
    }
    else
    {
        return one;
    }

}


// --------------------------------------------------------------------

// 2. feladat
// float Math.Ceiling (float)
// float Math.Round (float)

float seven = Ceiling1(5f);
Console.WriteLine(seven);

float Ceiling1(float five)
{
    float six = five % 1;
    if (six == 0)             //eredetileg ezt kihagytam, mert ha kerek 5, akkor nincs hova felkerekíteni, csak akkor, ha legalább 5.001...
    {
        return five;
    }

    five = five - six + 1; // ez miért unreachable? return ((five - six) + 1);   azért volt, mert az if () után kitettem egy ;-t !!!!
    return five;           // ez miért unreachable? return ((five - six) + 1);   azért volt, mert az if () után kitettem egy ;-t !!!!
}



float ten = Round1(5.49f);
Console.WriteLine(ten);

float Round1(float eight)
{
    float nine = eight % 1; // eggeyl osztva megmarad a szám és a maradék
    if (nine < 0.5f)
    {
        return (eight - nine);
    }
    return ((eight - nine) + 1);
}


// --------------------------------------------------------------------


// 3. feladat
// a bemeneti szám prímszám-e (prím - csak önmagával és eggyel osztható)

Console.Write("Adj meg egy számot ");
string thirteen = Console.ReadLine();
int fourteen = int.Parse(thirteen);
int fifteen = Prim(fourteen);
if (fifteen == 0 && fourteen != 1)
    Console.WriteLine($"A(z) {thirteen} prímszám!");
else
    Console.WriteLine($"A(z) {thirteen} NEM prímszám!");

int Prim(int eleven)
{
    for (int twelve = 2; twelve < eleven; twelve++)
    {
        if (eleven % twelve == 0)
            return (eleven / twelve);
    }
    return (0);
}



// a bemeneti szám prímszám-e (prím - csak önmagával és eggyel osztható) - TANÁRI? EGYSZERŰBB MEGOLDÁS



bool Prim2(int sixteen)
{
    for (int seventeen = 2; seventeen <= sixteen; seventeen++) // összes számot 2 és n/2 között, osztó-e; n/2 felett felelsleges osztót keresni
    {
        if (sixteen % seventeen == 0)
            return false;
    }
    return true;
}


// --------------------------------------------------------------------


// 4. feladat
// függvény, paraméterben kapott egész számnak kiszámolja a legnagyobb közös osztóját


int twentythree = eighteen(12, 16);
Console.WriteLine("");
Console.WriteLine($"Legnagyobb közös osztó:{twentythree}");


int eighteen(int nineteen, int twenty)
{
    int twentyone;
    if (nineteen > twenty)      // a tanár itt az if helyett egyszerűen a math.min-t használta
        twentyone = twenty / 2;
    else
        twentyone = nineteen / 2;

    for (int twentytwo = twentyone; twentytwo > 1; twentytwo--)
    {
        if (nineteen % twentytwo == 0 && twenty % twentytwo == 0)
        {
            return twentytwo;
        }
    }
    return 1;
}



// --------------------------------------------------------------------


// 5. feladat
// függvény, 3 int paraméterrel hogy pitagoraszi számhármas-e, bármilyen sorrendben adjuk be is a számokat
// Pithagoraszi számhármas: 3 olyan szám, ha háromszög oldalainak vesszük, akkor a háromszög derékszögű lesz
// ezekere igaz, hogy "a" a négyzeten + "b" a négyzeten = "C" a négyzeten
// pl: 3, 4, 5 --> (3x3) + (4x4) = (5x5) - kisebbik befogó * nagyobbik befogó = átfogó  <---keressük meg



int pitaGyros = pita(3, 4, 6);
Console.WriteLine("");
if (pitaGyros == 1)
    Console.WriteLine("Pitagoraszi számhármas");
else
    Console.WriteLine("NEM Pitagoraszi számhármas");



int pita(int pitaa, int pitab, int pitac)
{
    int atfogo = Math.Max(Math.Max(pitaa, pitab), pitac);    // lesnem kellett hogyan ágyaazuk egymásba
    int befogo1 = Math.Min(Math.Min(pitaa, pitab), pitac);
    int befogo2 = pitaa + pitab + pitac - atfogo - befogo1;    // miért nincs math alatt közeépső érték?
    if (befogo1 * befogo1 + befogo2 * befogo2 == atfogo * atfogo)
    {
        return 1;
    }
    return 0;
}

*/


// 3. házi