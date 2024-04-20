//Домашнее задание. Тема 12. Урок 1. Операторы ветвления Switch/ Case.

Console.Write("Выберите нужную операцию:\n1 - сложение\n2 - вычитание\n3 - умножение\n4 - деление");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

switch (n)
{
    case 1:
        Console.WriteLine(a + b); break;
    case 2:
        Console.WriteLine(a - b); break;
    case 3:
        Console.WriteLine(a * b); break;
    case 4:
        Console.WriteLine(a / b); break;
}

//Домашнее задание. Тема 13. Урок 2. Циклы while и do while.
//1 

Random random = new Random();
int m;
do
{
    m = random.Next(1, 11);
    Console.Write(m + " ");
}
while (m != 7);

//2

int k;
int sum = 0;
do
{
    Console.Write("Введите число: ");
    k = int.Parse(Console.ReadLine());
    sum += k;
}
while (k!=0);
Console.WriteLine("Сумма чисел: "+sum);