/*Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел*/
void Fmax1(int number, int max1, int max2)
{
    if (number > max1) max1 = number;
    if (number <= max1 && number > max2) max2 = number;
}

void Fmax2 (int number, int max1, int max2)
{
    
}
void Fmin(int num,int min1, int min2)
{
    if (num < min1) min1 = num;
    if (num >= min1 && num < min2) min2 = num;
}

Console.Write("Enter an integer: ");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num == 0)
{
    Console.WriteLine("No min and max numbers");
}
else
{
    int Max1 = Num;
    int Max2 = Num;
    int Min1 = Num;
    int Min2 = Num;
    while (Num != 0)
    {
        Fmax(Num, Max1, Max2);
        Fmin(Num, Min1, Min2);
        Console.Write("Enter an integer: ");
        Num = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine();
    Console.WriteLine();
}