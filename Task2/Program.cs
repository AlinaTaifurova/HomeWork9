
/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int m = PromptInt("Введите первое значение: ");
int n = PromptInt("Введите второе значение: ");

int PromptInt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}


void SumNumberMN (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов: {sum}"); 
        return;
    }
    sum += m++;
    SumNumberMN(m, n, sum);
}

SumNumberMN(m, n, 0);
