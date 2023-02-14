/*

// Math Values of Single Cards
int S8 = 1, S9 = 6, S10 = 31, S11 = 156, S12 = 781, S13 = 3906, S14 = 19531;    // Spades (egycsúcsú)
int H8 = 1, H9 = 6, H10 = 31, H11 = 156, H12 = 781, H13 = 3906, H14 = 19531;    // Hearts
int C8 = 1, C9 = 6, C10 = 31, C11 = 156, C12 = 781, C13 = 3906, C14 = 19531;    //Clubs 
int D8 = 1, D9 = 6, D10 = 31, D11 = 156, D12 = 781, D13 = 3986, D14 = 19531;    //Clubs 

//  Random Card Value Tablw
 //            8     9     10    11    12    13    14
//  --------|-----|-----|-----|-----|-----|-----|-----|
//  Spade   |  1  |  2  |  3  |  4  |  5  |  6  |  7  |
//  --------|-----|-----|-----|-----|-----|-----|-----|
//  Heart   |  8  |  9  |  10 |  11 |  12 |  13 |  14 |
//  --------|-----|-----|-----|-----|-----|-----|-----|
//  Club    |  15 |  16 |  17 |  18 |  19 |  20 |  21 |
//  --------|-----|-----|-----|-----|-----|-----|-----|
//  Diamond |  22 |  23 |  24 |  25 |  26 |  27 |  28 |
//  --------|-----|-----|-----|-----|-----|-----|-----|


// Game State (0, 1, 2)
int GameState = 0;


// WinningCalc

int P1Calc = 0;
int P2Calc = 0;
int WhoWins = 0;
int tempcalc = 0;


// playerCards
int p1c1, p1c2, p1c3, p1c4, p1c5;
int p2c1, p2c2, p2c3, p2c4, p2c5;

// playerDropCards
int p1d1=0, p1d2=0, p1d3=0, p1d4=0, p1d5=0;
int p2d1=0, p2d2=0, p2d3=0, p2d4=0, p2d5=0;

// int counters
int aces = 0, kings = 0, queens = 0, bubies = 0, tens = 0, nines = 0, eights = 0;  


// Random cards handed out
Random rnd = new Random();
p1c1 = rnd.Next(1, 29);
p1c2 = rnd.Next(1, 29);
while (p1c2 == p1c1)
{
    p1c2 = rnd.Next(1, 29);
}

p1c3 = rnd.Next(1, 29);
while ((p1c3 == p1c2) || (p1c3 == p1c1))
{
    p1c3 = rnd.Next(1, 29);
}

p1c4 = rnd.Next(1, 29);
while ((p1c4 == p1c3) || (p1c4 == p1c2) || (p1c4 == p1c1))
{
    p1c4 = rnd.Next(1, 29);
}

p1c5 = rnd.Next(1, 29);
while ((p1c5 == p1c4) || (p1c5 == p1c3) || (p1c5 == p1c2) || (p1c5 == p1c1))
{
    p1c5 = rnd.Next(1, 29);
}

p2c1 = rnd.Next(1, 29);
while ((p2c1 == p1c5) || (p2c1 == p1c4) || (p2c1 == p1c3) || (p2c1 == p1c2) || (p2c1 == p1c1))
{
    p2c1 = rnd.Next(1, 29);
}

p2c2 = rnd.Next(1, 29);
while ((p2c2 == p1c5) || (p2c2 == p1c4) || (p2c2 == p1c3) || (p2c2 == p1c2) || (p2c2 == p1c1) || (p2c2 == p2c1))
{
    p2c2 = rnd.Next(1, 29);
}

p2c3 = rnd.Next(1, 29);
while ((p2c3 == p1c5) || (p2c3 == p1c4) || (p2c3 == p1c3) || (p2c3 == p1c2) || (p2c3 == p1c1) || (p2c3 == p2c1) || (p2c3 == p2c2))
{
    p2c3 = rnd.Next(1, 29);
}

p2c4 = rnd.Next(1, 29);
while ((p2c4 == p1c5) || (p2c4 == p1c4) || (p2c4 == p1c3) || (p2c4 == p1c2) || (p2c4 == p1c1) || (p2c4 == p2c1) || (p2c4 == p2c2) || (p2c4 == p2c3))
{
    p2c4 = rnd.Next(1, 29);
}

p2c5 = rnd.Next(1, 29);
while ((p2c5 == p1c5) || (p2c5 == p1c4) || (p2c5 == p1c3) || (p2c5 == p1c2) || (p2c5 == p1c1) || (p2c5 == p2c1) || (p2c5 == p2c2) || (p2c5 == p2c3) || (p2c5 == p2c4))
{
    p2c5 = rnd.Next(1, 29);
}

Console.WriteLine($"{p1c1}, {p1c2}, {p1c3}, {p1c4}, {p1c5}");
Console.WriteLine($"{p2c1}, {p2c2}, {p2c3}, {p2c4}, {p2c5}");

// Change Cards

p1d1 = p1c1;
p1d2 = p1c2;
p1d3 = p1c3;
p1d4 = p1c4;
p1d5 = p1c5;
p2d1 = p2c1;
p2d2 = p2c2;
p2d3 = p2c3;
p2d4 = p2c4;
p2d5 = p2c5;


p1c1 = rnd.Next(1, 29);
while ((p1c1 == p1c2) || (p1c1 == p1c3) || (p1c1 == p1c4) || (p1c1 == p1c5) || (p1c1 == p2c1) || (p1c1 == p2c2) || (p1c1 == p2c3) || (p1c1 == p2c4) || (p1c1 == p2c5) || (p1c1 == p1d1) || (p1c1 == p1d2) || (p1c1 == p1d3) || (p1c1 == p1d4) || (p1c1 == p1d5) || (p1c1 == p2d1) || (p1c1 == p2d2) || (p1c1 == p2d3) || (p1c1 == p2d4) || (p1c1 == p2d5))
{
    p1c1 = rnd.Next(1, 29);
}

p1c2 = rnd.Next(1, 29);
while ((p1c2 == p1c1) || (p1c2 == p1c3) || (p1c2 == p1c4) || (p1c2 == p1c5) || (p1c2 == p2c1) || (p1c2 == p2c2) || (p1c2 == p2c3) || (p1c2 == p2c4) || (p1c2 == p2c5) || (p1c2 == p1d1) || (p1c2 == p1d2) || (p1c2 == p1d3) || (p1c2 == p1d4) || (p1c2 == p1d5) || (p1c2 == p2d1) || (p1c2 == p2d2) || (p1c2 == p2d3) || (p1c2 == p2d4) || (p1c2 == p2d5))
{
    p1c2 = rnd.Next(1, 29);
}

p1c3 = rnd.Next(1, 29);
while ((p1c3 == p1c2) || (p1c3 == p1c1) || (p1c3 == p1c4) || (p1c3 == p1c5) || (p1c3 == p2c1) || (p1c3 == p2c2) || (p1c3 == p2c3) || (p1c3 == p2c4) || (p1c3 == p2c5) || (p1c3 == p1d1) || (p1c3 == p1d2) || (p1c3 == p1d3) || (p1c3 == p1d4) || (p1c3 == p1d5) || (p1c3 == p2d1) || (p1c3 == p2d2) || (p1c3 == p2d3) || (p1c3 == p2d4) || (p1c3 == p2d5))
{
    p1c3 = rnd.Next(1, 29);
}

p1c4 = rnd.Next(1, 29);
while ((p1c4 == p1c2) || (p1c4 == p1c3) || (p1c4 == p1c1) || (p1c4 == p1c5) || (p1c4 == p2c1) || (p1c4 == p2c2) || (p1c4 == p2c3) || (p1c4 == p2c4) || (p1c4 == p2c5) || (p1c4 == p1d1) || (p1c4 == p1d2) || (p1c4 == p1d3) || (p1c4 == p1d4) || (p1c4 == p1d5) || (p1c4 == p2d1) || (p1c4 == p2d2) || (p1c4 == p2d3) || (p1c4 == p2d4) || (p1c4 == p2d5))
{
    p1c4 = rnd.Next(1, 29);
}

p1c5 = rnd.Next(1, 29);
while ((p1c5 == p1c2) || (p1c5 == p1c3) || (p1c5 == p1c4) || (p1c5 == p1c1) || (p1c5 == p2c1) || (p1c5 == p2c2) || (p1c5 == p2c3) || (p1c5 == p2c4) || (p1c5 == p2c5) || (p1c5 == p1d1) || (p1c5 == p1d2) || (p1c5 == p1d3) || (p1c5 == p1d4) || (p1c5 == p1d5) || (p1c5 == p2d1) || (p1c5 == p2d2) || (p1c5 == p2d3) || (p1c5 == p2d4) || (p1c5 == p2d5))
{
    p1c5 = rnd.Next(1, 29);
}


p2c1 = rnd.Next(1, 29);
while ((p2c1 == p1c2) || (p2c1 == p1c3) || (p2c1 == p1c4) || (p2c1 == p1c5) || (p2c1 == p1c1) || (p2c1 == p2c2) || (p2c1 == p2c3) || (p2c1 == p2c4) || (p2c1 == p2c5) || (p2c1 == p1d1) || (p2c1 == p1d2) || (p2c1 == p1d3) || (p2c1 == p1d4) || (p2c1 == p1d5) || (p2c1 == p2d1) || (p2c1 == p2d2) || (p2c1 == p2d3) || (p2c1 == p2d4) || (p2c1 == p2d5))
{
    p2c1 = rnd.Next(1, 29);
}

p2c2 = rnd.Next(1, 29);
while ((p2c2 == p1c1) || (p2c2 == p1c3) || (p2c2 == p1c4) || (p2c2 == p1c5) || (p2c2 == p2c1) || (p2c2 == p1c2) || (p2c2 == p2c3) || (p2c2 == p2c4) || (p2c2 == p2c5) || (p2c2 == p1d1) || (p2c2 == p1d2) || (p2c2 == p1d3) || (p2c2 == p1d4) || (p2c2 == p1d5) || (p2c2 == p2d1) || (p2c2 == p2d2) || (p2c2 == p2d3) || (p2c2 == p2d4) || (p2c2 == p2d5))
{
    p2c2 = rnd.Next(1, 29);
}

p2c3 = rnd.Next(1, 29);
while ((p2c3 == p1c2) || (p2c3 == p1c1) || (p2c3 == p1c4) || (p2c3 == p1c5) || (p2c3 == p2c1) || (p2c3 == p2c2) || (p2c3 == p1c3) || (p2c3 == p2c4) || (p2c3 == p2c5) || (p2c3 == p1d1) || (p2c3 == p1d2) || (p2c3 == p1d3) || (p2c3 == p1d4) || (p2c3 == p1d5) || (p2c3 == p2d1) || (p2c3 == p2d2) || (p2c3 == p2d3) || (p2c3 == p2d4) || (p2c3 == p2d5))
{
    p2c3 = rnd.Next(1, 29);
}

p2c4 = rnd.Next(1, 29);
while ((p2c4 == p1c2) || (p2c4 == p1c3) || (p2c4 == p1c1) || (p2c4 == p1c5) || (p2c4 == p2c1) || (p2c4 == p2c2) || (p2c4 == p2c3) || (p2c4 == p1c4) || (p2c4 == p2c5) || (p2c4 == p1d1) || (p2c4 == p1d2) || (p2c4 == p1d3) || (p2c4 == p1d4) || (p2c4 == p1d5) || (p2c4 == p2d1) || (p2c4 == p2d2) || (p2c4 == p2d3) || (p2c4 == p2d4) || (p2c4 == p2d5))
{
    p2c4 = rnd.Next(1, 29);
}

p2c5 = rnd.Next(1, 29);
while ((p2c5 == p1c2) || (p2c5 == p1c3) || (p2c5 == p1c4) || (p2c5 == p1c1) || (p2c5 == p2c1) || (p2c5 == p2c2) || (p2c5 == p2c3) || (p2c5 == p2c4) || (p2c5 == p1c5) || (p2c5 == p1d1) || (p2c5 == p1d2) || (p2c5 == p1d3) || (p2c5 == p1d4) || (p2c5 == p1d5) || (p2c5 == p2d1) || (p2c5 == p2d2) || (p2c5 == p2d3) || (p2c5 == p2d4) || (p2c5 == p2d5))
{
    p1c5 = rnd.Next(1, 29);
}


Console.WriteLine("");
Console.WriteLine($"{p1c1}, {p1c2}, {p1c3}, {p1c4}, {p1c5}");
Console.WriteLine($"{p2c1}, {p2c2}, {p2c3}, {p2c4}, {p2c5}");


// Hands Results


// int royalFlush;
if (((p1c1 == 7) || (p1c1 == 6) || (p1c1 == 5) || (p1c1 == 4) || (p1c1 == 3)) && ((p1c2 == 7) || (p1c2 == 6) || (p1c2 == 5) || (p1c2 == 4) || (p1c2 == 3)) && ((p1c3 == 7) || (p1c3 == 6) || (p1c3 == 5) || (p1c3 == 4) || (p1c3 == 3)) && ((p1c4 == 7) || (p1c4 == 6) || (p1c4 == 5) || (p1c4 == 4) || (p1c4 == 3)) && ((p1c5 == 7) || (p1c5 == 6) || (p1c5 == 5) || (p1c5 == 4) || (p1c5 == 3)))
    {
    P1Calc = 100000;
    }

else if (((p1c1 == 14) || (p1c1 == 13) || (p1c1 == 12) || (p1c1 == 11) || (p1c1 == 10)) && ((p1c2 == 14) || (p1c2 == 13) || (p1c2 == 12) || (p1c2 == 11) || (p1c2 == 10)) && ((p1c3 == 14) || (p1c3 == 13) || (p1c3 == 12) || (p1c3 == 11) || (p1c3 == 10)) && ((p1c4 == 14) || (p1c4 == 13) || (p1c4 == 12) || (p1c4 == 11) || (p1c4 == 10)) && ((p1c5 == 14) || (p1c5 == 13) || (p1c5 == 12) || (p1c5 == 11) || (p1c5 == 10)))
    {
    P1Calc = 100000;
    }

else if (((p1c1 == 21) || (p1c1 == 20) || (p1c1 == 19) || (p1c1 == 18) || (p1c1 == 17)) && ((p1c2 == 21) || (p1c2 == 20) || (p1c2 == 19) || (p1c2 == 18) || (p1c2 == 17)) && ((p1c3 == 21) || (p1c3 == 20) || (p1c3 == 19) || (p1c3 == 18) || (p1c3 == 17)) && ((p1c4 == 21) || (p1c4 == 20) || (p1c4 == 19) || (p1c4 == 18) || (p1c4 == 17)) && ((p1c5 == 21) || (p1c5 == 20) || (p1c5 == 19) || (p1c5 == 18) || (p1c5 == 17)))
{
    P1Calc = 100000;
}
else if (((p1c1 == 28) || (p1c1 == 27) || (p1c1 == 26) || (p1c1 == 25) || (p1c1 == 24)) && ((p1c2 == 28) || (p1c2 == 27) || (p1c2 == 26) || (p1c2 == 25) || (p1c2 == 24)) && ((p1c3 == 28) || (p1c3 == 27) || (p1c3 == 26) || (p1c3 == 25) || (p1c3 == 24)) && ((p1c4 == 28) || (p1c4 == 27) || (p1c4 == 26) || (p1c4 == 25) || (p1c4 == 24)) && ((p1c5 == 28) || (p1c5 == 27) || (p1c5 == 26) || (p1c5 == 25) || (p1c5 == 24)))
{
    P1Calc = 100000;
}


// int straightFlushHI;
if (((p1c1 == 6) || (p1c1 == 5) || (p1c1 == 4) || (p1c1 == 3) || (p1c1 == 2)) && ((p1c2 == 6) || (p1c2 == 5) || (p1c2 == 4) || (p1c2 == 3) || (p1c2 == 2)) && ((p1c3 == 6) || (p1c3 == 5) || (p1c3 == 4) || (p1c3 == 3) || (p1c3 == 2)) && ((p1c4 == 6) || (p1c4 == 5) || (p1c4 == 4) || (p1c4 == 3) || (p1c4 == 2)) && ((p1c5 == 6) || (p1c5 == 5) || (p1c5 == 4) || (p1c5 == 3) || (p1c5 == 2)))
{
    P1Calc = 99000;
}

else if (((p1c1 == 13) || (p1c1 == 12) || (p1c1 == 11) || (p1c1 == 10) || (p1c1 == 9)) && ((p1c2 == 13) || (p1c2 == 12) || (p1c2 == 11) || (p1c2 == 10) || (p1c2 == 9)) && ((p1c3 == 13) || (p1c3 == 12) || (p1c3 == 11) || (p1c3 == 10) || (p1c3 == 9)) && ((p1c4 == 13) || (p1c4 == 12) || (p1c4 == 11) || (p1c4 == 10) || (p1c4 == 9)) && ((p1c5 == 13) || (p1c5 == 12) || (p1c5 == 11) || (p1c5 == 10) || (p1c5 == 9)))
{
    P1Calc = 99000;
}

else if (((p1c1 == 20) || (p1c1 == 19) || (p1c1 == 18) || (p1c1 == 17) || (p1c1 == 16)) && ((p1c2 == 20) || (p1c2 == 19) || (p1c2 == 18) || (p1c2 == 17) || (p1c2 == 16)) && ((p1c3 == 20) || (p1c3 == 19) || (p1c3 == 18) || (p1c3 == 17) || (p1c3 == 16)) && ((p1c4 == 20) || (p1c4 == 19) || (p1c4 == 18) || (p1c4 == 17) || (p1c4 == 16)) && ((p1c5 == 20) || (p1c5 == 19) || (p1c5 == 18) || (p1c5 == 17) || (p1c5 == 16)))
{
    P1Calc = 99000;
}
else if (((p1c1 == 27) || (p1c1 == 26) || (p1c1 == 25) || (p1c1 == 24) || (p1c1 == 23)) && ((p1c2 == 27) || (p1c2 == 26) || (p1c2 == 25) || (p1c2 == 24) || (p1c2 == 23)) && ((p1c3 == 27) || (p1c3 == 26) || (p1c3 == 25) || (p1c3 == 24) || (p1c3 == 23)) && ((p1c4 == 27) || (p1c4 == 26) || (p1c4 == 25) || (p1c4 == 24) || (p1c4 == 23)) && ((p1c5 == 27) || (p1c5 == 26) || (p1c5 == 25) || (p1c5 == 24) || (p1c5 == 23)))
{
    P1Calc = 99000;
}


// int straightFlushLO;
if (((p1c1 == 1) || (p1c1 == 5) || (p1c1 == 4) || (p1c1 == 3) || (p1c1 == 2)) && ((p1c2 == 1) || (p1c2 == 5) || (p1c2 == 4) || (p1c2 == 3) || (p1c2 == 2)) && ((p1c3 == 1) || (p1c3 == 5) || (p1c3 == 4) || (p1c3 == 3) || (p1c3 == 2)) && ((p1c4 == 1) || (p1c4 == 5) || (p1c4 == 4) || (p1c4 == 3) || (p1c4 == 2)) && ((p1c5 == 1) || (p1c5 == 5) || (p1c5 == 4) || (p1c5 == 3) || (p1c5 == 2)))
{
    P1Calc = 98000;
}

else if (((p1c1 == 8) || (p1c1 == 12) || (p1c1 == 11) || (p1c1 == 10) || (p1c1 == 9)) && ((p1c2 == 8) || (p1c2 == 12) || (p1c2 == 11) || (p1c2 == 10) || (p1c2 == 9)) && ((p1c3 == 8) || (p1c3 == 12) || (p1c3 == 11) || (p1c3 == 10) || (p1c3 == 9)) && ((p1c4 == 8) || (p1c4 == 12) || (p1c4 == 11) || (p1c4 == 10) || (p1c4 == 9)) && ((p1c5 == 8) || (p1c5 == 12) || (p1c5 == 11) || (p1c5 == 10) || (p1c5 == 9)))
{
    P1Calc = 98000;
}

else if (((p1c1 == 15) || (p1c1 == 19) || (p1c1 == 18) || (p1c1 == 17) || (p1c1 == 16)) && ((p1c2 == 15) || (p1c2 == 19) || (p1c2 == 18) || (p1c2 == 17) || (p1c2 == 16)) && ((p1c3 == 15) || (p1c3 == 19) || (p1c3 == 18) || (p1c3 == 17) || (p1c3 == 16)) && ((p1c4 == 15) || (p1c4 == 19) || (p1c4 == 18) || (p1c4 == 17) || (p1c4 == 16)) && ((p1c5 == 15) || (p1c5 == 19) || (p1c5 == 18) || (p1c5 == 17) || (p1c5 == 16)))
{
    P1Calc = 98000;
}
else if (((p1c1 == 22) || (p1c1 == 26) || (p1c1 == 25) || (p1c1 == 24) || (p1c1 == 23)) && ((p1c2 == 22) || (p1c2 == 26) || (p1c2 == 25) || (p1c2 == 24) || (p1c2 == 23)) && ((p1c3 == 22) || (p1c3 == 26) || (p1c3 == 25) || (p1c3 == 24) || (p1c3 == 23)) && ((p1c4 == 22) || (p1c4 == 26) || (p1c4 == 25) || (p1c4 == 24) || (p1c4 == 23)) && ((p1c5 == 22) || (p1c5 == 26) || (p1c5 == 25) || (p1c5 == 24) || (p1c5 == 23)))
{
    P1Calc = 98000;
}



// int fourOfaKind;

if ((p1c1 == 7) || (p1c1 == 14) || (p1c1 == 21) || (p1c1 == 28))
    {
    aces = aces + 1;
    }
else if ((p1c2 == 7) || (p1c2 == 14) || (p1c2 == 21) || (p1c2 == 28))
{
    aces = aces + 1;
}
else if ((p1c3 == 7) || (p1c3 == 14) || (p1c3 == 21) || (p1c3 == 28))
{
    aces = aces + 1;
}
else if ((p1c4 == 7) || (p1c4 == 14) || (p1c4 == 21) || (p1c4 == 28))
{
    aces = aces + 1;
}
else if ((p1c4 == 7) || (p1c4 == 14) || (p1c4 == 21) || (p1c4 == 28))
{
    aces = aces + 1;
}

if (aces == 4);
tempcalc = (p1c1 + p1c2 + p1c3 + p1c4 + p1c5) - (7 + 14 + 21 + 28); 
// INNEN FOLYTATNI
P1Calc = 95800;


if ((p1c1 == 6) || (p1c1 == 13) || (p1c1 == 20) || (p1c1 == 27))
{
    kings = kings + 1;
}
else if ((p1c2 == 6) || (p1c2 == 13) || (p1c2 == 20) || (p1c2 == 27))
{
    kings = kings + 1;
}
else if ((p1c3 == 6) || (p1c3 == 13) || (p1c3 == 20) || (p1c3 == 27))
{
    kings = kings + 1;
}
else if ((p1c4 == 6) || (p1c4 == 13) || (p1c4 == 20) || (p1c4 == 27))
{
    kings = kings + 1;
}
else if ((p1c4 == 6) || (p1c4 == 13) || (p1c4 == 20) || (p1c4 == 27))
{
    kings = kings + 1;
}

if (kings == 4) ;
P1Calc = 95700;


if ((p1c1 == 5) || (p1c1 == 12) || (p1c1 == 19) || (p1c1 == 26))
{
    queens = queens + 1;
}
else if ((p1c2 == 5) || (p1c2 == 12) || (p1c2 == 19) || (p1c2 == 26))
{
    queens = queens + 1;
}
else if ((p1c3 == 5) || (p1c3 == 12) || (p1c3 == 19) || (p1c3 == 26))
{
    queens = queens + 1;
}
else if ((p1c4 == 5) || (p1c4 == 12) || (p1c4 == 19) || (p1c4 == 26))
{
    queens = queens + 1;
}
else if ((p1c4 == 5) || (p1c4 == 12) || (p1c4 == 19) || (p1c4 == 26))
{
    queens = queens + 1;
}

if (queens == 4);
P1Calc = 95600;


if ((p1c1 == 4) || (p1c1 == 11) || (p1c1 == 18) || (p1c1 == 25))
{
    bubies = bubies + 1;
}
else if ((p1c2 == 4) || (p1c2 == 11) || (p1c2 == 18) || (p1c2 == 25))
{
    bubies = bubies + 1;
}
else if ((p1c3 == 4) || (p1c3 == 11) || (p1c3 == 18) || (p1c3 == 25))
{
    bubies = bubies + 1;
}
else if ((p1c4 == 4) || (p1c4 == 11) || (p1c4 == 18) || (p1c4 == 25))
{
    bubies = bubies + 1;
}
else if ((p1c4 == 4) || (p1c4 == 11) || (p1c4 == 18) || (p1c4 == 25))
{
    bubies = bubies + 1;
}

if (bubies == 4) ;
P1Calc = 95500;



if ((p1c1 == 3) || (p1c1 == 10) || (p1c1 == 17) || (p1c1 == 24))
{
    tens = tens + 1;
}
else if ((p1c2 == 3) || (p1c2 == 10) || (p1c2 == 17) || (p1c2 == 24))
{
    tens = tens + 1;
}
else if ((p1c3 == 3) || (p1c3 == 10) || (p1c3 == 17) || (p1c3 == 24))
{
    tens = tens + 1;
}
else if ((p1c4 == 3) || (p1c4 == 10) || (p1c4 == 17) || (p1c4 == 24))
{
    tens = tens + 1;
}
else if ((p1c4 == 3) || (p1c4 == 10) || (p1c4 == 17) || (p1c4 == 24))
{
    tens = tens + 1;
}

if (tens == 4);
P1Calc = 95400;


if ((p1c1 == 2) || (p1c1 == 9) || (p1c1 == 16) || (p1c1 == 23))
{
    nines = nines + 1;
}
else if ((p1c2 == 2) || (p1c2 == 9) || (p1c2 == 16) || (p1c2 == 23))
{
    nines = nines + 1;
}
else if ((p1c3 == 2) || (p1c3 == 9) || (p1c3 == 16) || (p1c3 == 23))
{
    nines = nines + 1;
}
else if ((p1c4 == 2) || (p1c4 == 9) || (p1c4 == 16) || (p1c4 == 23))
{
    nines = nines + 1;
}
else if ((p1c4 == 2) || (p1c4 == 9) || (p1c4 == 16) || (p1c4 == 23))
{
    nines = nines + 1;
}

if (nines == 4) ;
P1Calc = 95300;


if ((p1c1 == 1) || (p1c1 == 8) || (p1c1 == 15) || (p1c1 == 22))
{
    eights = eights + 1;
}
else if ((p1c2 == 1) || (p1c2 == 8) || (p1c2 == 15) || (p1c2 == 22))
{
    eights = eights + 1;
}
else if ((p1c3 == 1) || (p1c3 == 8) || (p1c3 == 15) || (p1c3 == 22))
{
    eights = eights + 1;
}
else if ((p1c4 == 1) || (p1c4 == 8) || (p1c4 == 15) || (p1c4 == 22))
{
    eights = eights + 1;
}
else if ((p1c4 == 1) || (p1c4 == 8) || (p1c4 == 15) || (p1c4 == 22))
{
    eights = eights + 1;
}

if (eights == 4) ;
P1Calc = 95200;








int onePair;
int doublePair;
int threeOfaKind;
int straight;
int flush;
int fullHouse;



*/