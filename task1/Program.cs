// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputMassive(int length)
{
    int[] massive = new int[length];
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            massive[i] = number;
        }
        else
        {
            Console.WriteLine("Неверный ввод. Повторите попытку.");
            i--;
        }
    }
    return massive;
}

void PrintMassive(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.WriteLine($"{i}-й элемент массива = {massive[i]}");
    }
}

int PositiveNumbers(int[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите количество элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] massive = InputMassive(length);
PrintMassive(massive);
Console.WriteLine($"Количество чисел больше нуля: {PositiveNumbers(massive)}");