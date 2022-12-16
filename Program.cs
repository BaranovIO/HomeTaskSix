
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