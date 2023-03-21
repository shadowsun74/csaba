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
/*
// 1. számjegyösszeg függvény
szamOsszeg(34675);
int szamOsszeg(int x)
{
    int osszeg = 0;             
    while (x != 0)           
    {

        int szamok = x % 10;         // Osztom 10-zel, az utolsó szzám a tizedes tartományva csúszik így át
        osszeg += szamok;        
        x /= 10;                    // Levágom az utolsó számjegyet, ismét 10-zel
    }
    Console.WriteLine(osszeg);
    Console.WriteLine("--------------");
    return osszeg;
    
}

// 2. első N prímszám

AmiPrim(12);

void AmiPrim (int y)
{
    int darab = 0;
    for (int i = 0; darab < y; i++)
    {
        if (Prim(i))
        {
            Console.WriteLine(i);
            darab++;
        }
    }
}

bool Prim(int z)
{
    if (z < 2)                                      // 2 alatt nincs prymszám
        return false;

    float negyzetgyok = (float) Math.Sqrt(z);       // z négyzetgyöke, négyzetgyök felett felesleges osztót keresni, (float)-tal átalakítom

    for (int k = 2; k <= negyzetgyok; k++)
    {
        if (z % k == 0)
            return false;


    }
    return true;
}
*/


// 3. komponenst, ami a kurzorgombok lenyomva tartására folyamatosan halad a megfelelő irányba,
// A komponensnek be kell állítani egy [SerializeField] változóban egy haladási sebességet. beállított sebeség mértéke: egység / másodperc.
// Keresztben is lehet haladni, de a sebességet ekkor is tartani kell!

/*
using UnityEngine;
public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 1;                       

    void Update()
    {
        bool up = Input.GetKeyDown(KeyCode.UpArrow);
        bool down = Input.GetKeyDown(KeyCode.DownArrow);
        bool right = Input.GetKeyDown(KeyCode.RightArrow);
        bool left = Input.GetKeyDown(KeyCode.LeftArrow);

        float z = 0;

        if (up && down)                                     // le fel együttes lenyomásnál ne mozogjon
            z = 0;
        else if (up)
            z = 1;                                          // menj felfelé
        else if (down)
            z = -1;                                         // menj lefelé

        float x = 0;

        if (right && left)                                  // jobbra balra együttes lenyomásnál ne mozogjon
            x = 0;
        else if (left)                                      // menj balra
            x -= 1;
        else if (right)                                     // menj jobbra
            x += 1;


        Vector3 velocity = new Vector3(x, 0, z);

        velocity.Normalize();                               // a speed előtt, hogy azt ne normalizálja, csak a mozgást
        velocity *= speed;                                  // speed és velocity szorzata a mozgás sebessége

        Vector3 p = transform.position;
        Vector3 newPos = p + (velocity * Time.deltaTime);
        transform.position = newPos;
    }
}

// 3. feladat - TANÁRI MEGOLDÁS
// komponenst, ami a kurzorgombok lenyomva tartására folyamatosan halad a megfelelő irányba,
// A komponensnek be kell állítani egy [SerializeField] változóban egy haladási sebességet. beállított sebeség mértéke: egység / másodperc.
// Keresztben is lehet haladni, de a sebességet ekkor is tartani kell!


using UnityEngine;
public class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed = 1;

    void Update()
    {
        // Input vektor létrehozása 1:
        Vector3 inputVector1 = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                                                                                                //ennek felel meg: 
                                                                                                //Vector3 velocity = new Vector3(x, 0, z); 
                                                                                                // GetAxis - szövegesből értelmezi  mit kell
                                                                                                // figyelnie, az érték -1, +1 közötti (bill,
                                                                                                // joystick esetén, 0,05f
                                                                                                // GetAxisRaw = csak egész számok (1, 0, -1)
        
        // Input vektor létrehozása 2:
        float x1 = Input.GetKeyDown(KeyCode.LeftArrow) ? -1 : 0;      // float a 0,05f miatt; --> ? (ha) igen (nyomva van, -1) : (egyébként 0)
        float x2 = Input.GetKeyDown(KeyCode.RightArrow) ? 1 : 0;      // hasonlóan
        
        float z1 = Input.GetKeyDown(KeyCode.DownArrow) ? -1 : 0;      // hasonlóan
        float z2 = Input.GetKeyDown(KeyCode.UpArrow) ? 1 : 0;         // hasonlóan

        Vector3 inputVector2 = new Vector3(x1 + x2, 0, z1 + z2);      // legyan az inputvector2 értéke (ha mindkettő lenyomva az nulla
                                                                      // merrt +1 és -1 az nulla, itt kezeli hogy olyankor NE menjen
                                                                      // EZ NEM INKBB INPUTVECTOR1???
        
        inputVector1 = inputVector1.normalized;                       // normalizáljuk, hogy srégen is 1 hosszakat mehessen, ne legyen gyorsabb
        
        // Szorozni kell a beállított sebességgel.
        // Szorozni kell az Time.deltaTime-el, mert így csak egy frame-nyit lépünk előre.
        transform.Translate(inputVector1 * (Time.deltaTime * speed)); // translate = abba az irányba mozgatja el, ahová a translate mutat
                                                                      // az inputVector1-et szorozzuk a deltával, szorozzuk a sebességgel
                                                                      // a delta azért kell, hogy minden procinál ugyaolyan gyors legyen 1 mp

    }
}


--------------------------------------- KOMMENTEK MÁSHONNAN (CHAT9 ---------------------------------------

// Minden egyes képfrisstés előtt van egy update (update-render-update-render-...!
// Project settings --> Quality --> VSYNC beállítása, a játék a frissítést próbálja szinkroizálni a monitor frissítési sebességéhez
// Editorban rendelrel más is, így különbözik a végén elért eredménytől.
// ködból is állítható az FPS: Application.targetFrameRate = 30;  --> valahol a start.ban meghívod, lehet külön komponens
// ez a játékben fog korlátozni, illetve az Update sebességét és a Main Camera Render sebességét, nem korlátozza az ablak frissítési sebességét

// Megoldás a "túl magas" FPS-re
// est kell "Add component"-tel bármilyen game object-re tenni.
// A Game ablek legördülőben felül, ahol alap esetben "Free Aspect" vagy beállított felbontás van, legyen bepipálva a VSYNC is, az EDIT\
// Project Settings\Quality\Vsync mindegy mire van állítva
// https://fraps.com/ ugyan azt adja FPS-re amit beállítottam, nem pörgeti túl a GPU-t

using UnityEngine;                                
public class FPS : MonoBehaviour   
{                                                 
    void Start()                                  
    {
       Application.targetFrameRate = Screen.currentResoltion.refreshRate;           
    }
}             

// --------------------------------------------------

*/




//Írj függvényt, ami egy paraméterben kapott 2-es számrendszer béli (bináris) számot átalakít 10-es
//számrendszer béli (decimális) alakjára.
// Ha a bemenet nem bináris szám (más számjegyet is tartalmaz mint 0 és 1), a kimenet legyen 0.


BinaryToDecimal(0000111121);

int BinaryToDecimal(int binaryNum)
{
    int decimalNum = 0;    // Kinullázom a végeredményt 
    int digitValue = 1;    // Ebben számolom, hogy az egyes helyiértéken mennyivel szorzunk

    while (binaryNum > 0)  // Egyenként végigmegyek a bináris szám minden számjegyén
    {
        int digit = binaryNum % 10;    // Levágjuk az utolsó számjegyet

        if (digit > 1)         // Ha bármelyik számjegy nem 0 vagy 1
        {
            decimalNum = 0;    // akkor az eredmény 0
            break;             // ás kilépünk a ciklusból
        }

        decimalNum += digit * digitValue;

        binaryNum = binaryNum / 10;   // Törlöm az utolsó számjegyet (Azt már kezeltem)
        digitValue *= 2;              // Következő helyiérték már dupla akkora szorzójú
    }

    Console.WriteLine(decimalNum);
    return decimalNum;
}