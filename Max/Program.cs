/*Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел*/
int Fmax1(int number, int max1, int max2)
{
    if (number > max1) max1 = number;
    return max1;
}

int Fmax2 (int number, int max1, int max2)
{
    if (number <= max1 && number > max2) max2 = number;
    return max2;
}
int Fmin1(int num,int min1, int min2)
{
    if (num < min1) min1 = num;
    return min1;
}

int Fmin2 (int num,int min1, int min2){
    if (num >= min1 && num < min2) min2 = num;
    return min2;
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
        if(Num <= Max1 && Num >= Min1)
        {
            Max2 = Fmax2(Num, Max1, Max2);
            Min2 = Fmin2(Num, Min1, Min2);
        }
        else
        {
            Max1 = Fmax1(Num, Max1, Max2);
            Min1 = Fmin1(Num, Min1, Min2);
        }
       
        Console.Write("Enter an integer: ");
        Num = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine(Max1 + " " + Max2);
    Console.WriteLine(Min1 + " " + Min2);
}