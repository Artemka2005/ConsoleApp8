
Console.WriteLine("Введите координаты белого коня(от 1 до 8)");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты черного коня(от 1 до 8)");

int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты ладьи(от 1 до 8)");
int e = Convert.ToInt32(Console.ReadLine());
int f = Convert.ToInt32(Console.ReadLine());


if (a == e || b == f)
{ // проверяю может ли ладья пойти на это поле одним ходом
    if (c - e == d - f || c - e == f - d)
    { //проверяю стоят ли ладья и конь на одной диагонали
        Console.WriteLine("Ладья может пойти на это поле, но попадет под удар коня");
    }
    else
    {
        Console.WriteLine("Ладья может пойти на это поле, и не попадет под удар коня");
    }
}
else
{
    Console.WriteLine("Ладья не может пойти на это поле");
}


