String nama;
int harian,uts,uas;
double rata;

Console.Write("Nama             :");
nama = Console.ReadLine();

Console.Write("Nilai Harian     :");
harian = Convert.ToInt32(Console.ReadLine());

Console.Write("Nilai UTS        :");
uts = Convert.ToInt32(Console.ReadLine());

Console.Write("Nilai UAS        :");
uas = Convert.ToInt32(Console.ReadLine());

rata = (harian+uts+uas)/3;
Console.WriteLine("=====================");
Console.WriteLine("Nama         : "+nama);
Console.WriteLine("Nilai Harian : "+harian);
Console.WriteLine("Nilai UTS    : "+uts);
Console.WriteLine("Nilai UAS    : "+uas);
Console.WriteLine("Rata         : "+rata);

if (rata>=80)
{
    Console.WriteLine("Predikat     : A");
}
else if (rata>=70)
{
    Console.WriteLine("Predikat     : B");
}
else if (rata>=60)
{
    Console.WriteLine("Predikat     : C");
}
else if (rata>=50)
{
    Console.WriteLine("Predikat     : D");
}
else
{
    Console.WriteLine("Predikat     : E");
}