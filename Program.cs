// See https://aka.ms/new-console-template for more information
using intro_c_sharp_flow_chart;


// if-sats 1
Console.WriteLine("Vad heter Ada i förnamn?");
var svar = Console.ReadLine();
if (svar == "Lovelace")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar!");
}



// if-sats 2
Console.WriteLine("Vad heter Norges huvudstad?");
var text = Console.ReadLine();
if (text == "Oslo")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    if (text == "oslo")
    {
        Console.WriteLine("Rätt svar! Men, ...");
    }
    else
    {
        Console.WriteLine("Fel svar!");
    }
}
Console.WriteLine("Tack och hej!");



// while-slinga 1
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i = i + 1;
}
Console.WriteLine(i * 100);
// vilka tal skrivs ut?



// while-slinga 2
int j = 10;
while (j > 0)
{
    Console.WriteLine(j);
    j = j - 1;
}
Console.WriteLine(j * j);
// vilka tal skrivs ut?



// while-slinga 3
int k = 1; 
while (k < 9)
{
    Console.WriteLine(k);
    k = k + 2;
}
Console.WriteLine(k * k);
// vilka tal skrivs ut?



// for-slinga 1
for (int l = 0; l < 3; l++)
{
    Console.WriteLine(l * l);
}
// Error: The name 'l' does not exist in the current context
//Console.WriteLine(l * l);
// Vilka tal skrivs ut?



// for-slinga 2
for (int m = 30; m > 25; m--)
{
    Console.WriteLine(m);
}
// Vilka tal skrivs ut?



// for-slinga 3
for (int n = 2; n < 10; n = n + 3)
{
    Console.WriteLine(n);
}
// Vilka tal skrivs ut?



// array 1
int[] tal = new int[5];
for (int o = 0; o < 5; o++)
{
    tal[o] = new Random().Next(1, 7); // 1, 2, 3, 4, 5, eller 6
}
// Olämpligt variabelnamn. Hitta på ett lämpligare.
int q = 0;
for (int p = 0; p < 5; p++)
{
    if (tal[p] == 6)
    {
        q = q + 1;
    }  
}
Console.WriteLine(q);
// Vad skrivs ut? Hitta på värden för tal.



// List 1
List<int> talLista = new List<int>();
for (int r = 0; r < 10; r++)
{
    talLista.Add(new Random().Next(1, 7)); // 1, 2, 3, 4, 5, eller 6
}
// Olämpligt variabelnamn. Hitta på ett lämpligare.
int s = 0;
for (int t = 0; t < talLista.Count; t++)
{
    if (talLista[t] == 6)
    {
        s = s + 1;
    }
}
Console.WriteLine(s);
// Vad skrivs ut? Hitta på värden för talLista.



// Funktion 1 - Vad händer?
static void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage("Hej på dig!");
PrintMessage("Välkommen hit!");



// Funktion 2 - Vad händer?
static float upphöjt(int bas, int exponent)
{
    int svar = bas;
    if (exponent == 0)
    {
        return 1;
    }
    else if (exponent > 0)
    {
        for (int u = 1; u < exponent; u++)
        {
            svar = svar * bas;
        }
        return svar;
    }
    else // exponent < 0
    {
        svar = 1 / svar;
        for (int v = -1;  v > exponent; v--)
        {
            svar = svar / bas;
        }
        return svar;
    }
}

PrintMessage(upphöjt(2, 3).ToString());
PrintMessage(upphöjt(2, 0) + "");
PrintMessage("Mycket bra: " + upphöjt(2, -3));



// klasser och objekt 1

// Det finns kod i filen Person.cs 
Person p1 = new Person();
p1.namn = "Ada";
p1.ålder = 30;

Person p2 = new Person();
p2.ålder = 40;
p2.namn = "Beda";

Console.WriteLine(p2.namn + ", " + p2.ålder);
Console.WriteLine(p1.namn + ", " + p1.ålder);



// klasser och objekt 2
// Se kod i filen Kort.cs
// Vad skrivs ut?

List<Kort> kortlek = new List<Kort>();
for (int w = 2; w < 15; w++)
{
    kortlek.Add(new Kort("Hjärter", w));
    kortlek.Add(new Kort("Spader", w));
    kortlek.Add(new Kort("Ruter", w));
    kortlek.Add(new Kort("Klöver", w));
}

foreach (Kort kort in kortlek)
{
    Console.WriteLine(kort);
}



// klasser och objekt 3
// Se kod i filerna Kort.cs och Kortlek.cs
// Vad skrivs ut?

Kortlek minSpecialLek = new Kortlek();

minSpecialLek.SkrivUt();
Kort k1 = minSpecialLek.GeKort();
Kort k2 = minSpecialLek.GeKort();
Console.WriteLine(k1);
Console.WriteLine(k2);
minSpecialLek.SkrivUt();
minSpecialLek = new Kortlek();
for (int x = 0; x < 50; x++)
{
    Kort y = minSpecialLek.GeKort();
}
minSpecialLek.SkrivUt();
minSpecialLek = new Kortlek();
minSpecialLek.Blanda();
minSpecialLek.SkrivUt();
