/* Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные 
числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

int m = PromptInt("Введите первое значение: ");
int n = PromptInt("Введите второе значение: ");
int PromptInt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void ShowPositiveNumbers(int start, int finish)
{
    if (start % 2 == 1) start++;
    if (start > finish)
    {
        return;
    }
    Console.Write(start + " ");
    ShowPositiveNumbers(start + 2, finish);
}

System.Console.Write($"Четные числа от {m} до {n}: ");
ShowPositiveNumbers(m, n);