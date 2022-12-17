/*
int CountPositiveNumbers(int n)
{  
    int count = 0;
    int quantity = 1;
    while(quantity <= n)
    {   
        Console.Write("Введите положительное или отрицательное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        {
            if(number > 0)
            count++;            
        }
        quantity++;
    }
    return count;
}

Console.Write("Введите требуемое количество чисел для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = CountPositiveNumbers(num);
Console.WriteLine("Количество введённых положительных чисел: " + result);
*/


void DotOfCross(double k1, double b1, double k2, double b2)
{
    if(k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Прямые параллельны");
    }

    if(k1 == k2 && b1 == b2)
    {
            Console.WriteLine("Прямые совпадают");
                
    }
    
    if(k1 != k2 && b1 != b2)
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = (k1 * (b1 -b2) / (k2 - k1)) + b1;
        Console.WriteLine($"Координаты точки пересечения прямых ({x};{y})");
    }
}

Console.WriteLine("Чтобы найти точку пересечения двух прямых y=k1*x+b1 и y=k2*x+b2");
Console.Write("Введите k1: ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double t1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double t2 = Convert.ToDouble(Console.ReadLine());
DotOfCross(a1, t1, a2, t2);


