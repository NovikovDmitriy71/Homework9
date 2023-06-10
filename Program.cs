// // Вывод натуральных чисел от N до 0
// void NatNamders(int nam)
// {
//     if (nam>0)
//     {
//         System.Console.Write(nam+" ");
//         NatNamders(nam-1);
//     }
// }
// Console.WriteLine("Input namber   ");
// int nam= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// NatNamders(nam);

//+=====================================
// Вычисление функции Аккермана 

// Console.WriteLine("Введите начальное число a:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начальное число b:");
// int b= Convert.ToInt32(Console.ReadLine());

// int AckermannFunction (int a, int b)
// {
//     if (a == 0) return b + 1;
//     if (a != 0 && b == 0) return AckermannFunction(a - 1, 1);
//     if (a > 0 && b > 0) return AckermannFunction(a - 1, AckermannFunction(a, b - 1));
// return AckermannFunction(a, b);
// }
// Console.WriteLine($"AckermannFunction namber {a} and {b} = {AckermannFunction(a,b)}");
// AckermannFunction(a,b);

//==============================================
// Сумма чисел диапазона от a до b

Console.WriteLine("Input namber a   ");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input namber b > a   ");
int b= Convert.ToInt32(Console.ReadLine());

int SumRange(int a, int b)
{
    if (a==b)
    {
    return a;
    }
    else
    {
        //System.Console.Write($" {a},{b} "); //Проверка набора цифр
       return a+SumRange(a+1,b); System.Console.Write(SumRange);
    }
}
Console.WriteLine($"Summ range namber {a} and {b} -> {SumRange(a,b)}");



