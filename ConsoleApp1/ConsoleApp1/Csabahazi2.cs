// 1. feladat
// Math.Clamp(float, float, float);





float fourth = Clamp1(151, 120, 150);
Console.WriteLine($"{fourth}");

float Clamp1 (float one, float two, float three)
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

float Ceiling1 (float five)
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



bool Prim2 (int sixteen)
    {
    for (int seventeen = 2; seventeen <= sixteen; seventeen++) // összes számot 2 és n/2 között, osztó-e; n/2 felett felelsleges osztót keresni
        {
        if (sixteen % seventeen ==0)
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


int eighteen (int nineteen, int twenty)
    {
    int twentyone;
    if (nineteen > twenty)      // a tanár itt az if helyett egyszerűen a math.min-t használta
        twentyone = twenty/2;
    else
        twentyone = nineteen/2;

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



int pita (int pitaa, int pitab, int pitac)
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

