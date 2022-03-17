/*Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел*/

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
    int iter = 0;     // счетчик итераций

    while (Num != 0)
    {

        if (Num >= Max1)  
        {
            Max2 = Max1;
            Max1 = Num;
        }
        
        if ((Num < Max1 && Num > Max2) || (iter ==1 && Num < Max1)) Max2 = Num; 

        if (Num <= Min1) 
        {
            Min2 = Min1;
            Min1 = Num;
        }
        if ((Num > Min1 && Num < Min2) || (iter ==1 && Num > Min1)) Min2 = Num;

        Console.Write("Enter an integer: ");
        Num = Convert.ToInt32(Console.ReadLine());
        iter++;
    }

    Console.WriteLine("Maximum: " + Max1 + " " + Max2);
    Console.WriteLine("Minimum: " + Min1 + " " + Min2);
}