//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int i = 0;
while(i<10)

{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

Console.WriteLine("*****************");
//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int i2 = 1;
while(i2<21)
{
    Console.WriteLine(i2);
    i2++;
}
Console.WriteLine("*****************");
//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int i3 = 2;
while(i3<21)
{
    Console.WriteLine(i3);
    i3 += 2;
}
Console.WriteLine("*****************");
//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int i4 = 50;
int toplam = 0;

while (i4<151)
{
    toplam += i4;
    i4++;
    
}
Console.WriteLine(toplam);
Console.WriteLine("*****************");
//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int i5 = 1;
int tek = 0;
int cift = 0;
while (i5<121)

{
    if (i5%2 ==0)
    {
        cift += i5;
    }
    else
    {
        tek += i5;
    }

    i5++;
}

Console.WriteLine($"Tek sayılar Toplamı : {tek} \nÇift sayılar toplamı : {cift}");