﻿/*
int u = feltétel ? 5 : 0; // ha egy feltétel igez, az első, ha nem, akkor a második


Console.WriteLine(15 + " *");
Console.WriteLine(15.ToString() + " *");
Console.WriteLine($"{15} *");
*/


/*
bool runLoop = true;
int summa = 0;
int numberCount = 0;

while (runLoop)
{
    string line = Console.ReadLine();

    bool success = int.TryParse(line, out int number);  // tryparse boolean lesz, 2 kimenet, az egyik az out, ha sikeres

    if (success)
    {
        summa += number;
        numberCount++;
    }

    else
    {
        // írhatjuk így is:  runLoop= false;
        break;  //vagy ezzel a módszerrel
    }
}

float mean = (float)summa / numberCount;
Console.WriteLine($"az eredmény: {mean}");

*/


/*

double pi = Math.PI; // lehetne float pi = (float)Math.PI, mivel a math PI egy double érték, a osszabb verzió miatt

const float pi2 = 3,14f //blokkoljuk a változót, ez konstans, nem tudja semmi felülírni innentől

double sqrt = Math.Sqrt(56); // gyök számítás (négyzetgyők)
double sq = Math.Pow(5, 1/6f); // gyök a sokadiknál
double vals = Math.Pow(5, 6) // vals változó, 5 az n-ediken


*/





/*
//......................................METÓDUSOK...2- SZAKASZ-.......................
// metódus a nagy kategória, ezen belül vannak a függvények, eljásárok

double a = Math.Pow(2, 6);
double aa = Math.Sqrt(9);

float number = 12.544f;
float b = Math.Abs(12.4f); // ABS - abszolút rövidítése (ha a szám negatív, visszaadja a pozitívat) az értéket cserélhetjük "number"-re is amit fent megadtunk
float e = Math.Sign(-10); //Előjel függvény (szintén "number" is lehet) fentről


float c = Math.Max(7, 4); // kiadja a nagyobbik értéket
float d = Math.Min(7, 4); // kiadja a kisebbik értéket

double f = Math.Ceiling(45.05); // Plafon - felfelé kerekítés -- 46 lesz
double g = Math.Floor(467.75); // Padló - lefelé kerekítés - 467 lesz
double h = Math.Round(33.6); // Kerekítés (normál)

// ------------------------------------------------

float a1 = Abs(-13.5f); // ugyanaz, mint fent a math, de magunk is leprogramozhatjuk
float a2 = Siign(-44); // ezt a tanári Siign után írjuk be, hatni fog rá, metóduskonál ez nem számít, lehet előtte vagy mögötte. Unity-n belül mindíg metóduson belül fogunk dolgozni

Mymethod(10);
Mymethod(12);

// ------------------------------------------------

//viszonylag egyszerű függvény, 1 bemenet, 1 kimenet
// definiáljuk, majdwe felsoroljuk a függvényben a paramétereket, sorban)
float Abs(float num)             // típus, azonosító, paraméterek
{                               // törzs
    if (num < 0)
        num = -num;   /// itt a num változó nem biztos, hogy jó

    return num;              // ez a visszatérés, 
}

// ez is ugyanaz, csak fenti egyszerűbb
float Abs1(float num1)             // típus, azonosító, paraméterek
{                               // törzs
    float result1 = num1;

    if (num1 < 0)
        result1 = -num1;

    return result1;              // ez a visszatérés, 
}

 //   ------------------------------------------------

float Max(float a, float b)
    {

    if (a < b)
    {
        return b;
    }
    else  /// des simán kihagyható az else ág, a "return a" kiírható csak simán a kapcsos zárójel után ebben az esetben
    {
        return a;
    }
   }


//   ------------------------------------------------
// float e = Math.Sign(-10); //Előjel függvény (szintén "number" is lehet) fentről

float szign (float pluszka, float minuszka) // sajátmegoldás, nem túl jó
{
    if (pluszka>=0)
    {
        pluszka = 1;
        return pluszka;
    }
    else
    {
        minuszka = -1;
        return minuszka;
    }
}

// Tanári megoldás
float Siign (float num5)
{
    if(num5 <0)
    {
        return -1;
    }
    return 1;
}



//   ------------------------------------------------

// Method (eljárások - mind VOID-ok, rutinok, függvények bármilyen típusok, pl: INT, BOOL....)

void Mymethod (int n)
{
    for (int i = 1; i < n; i++)
    {
        Console.WriteLine(i);
    }

}
*/