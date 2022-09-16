// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел вводить?");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
FillArrayFromConsole(array);
System.Console.WriteLine(NumsGrZero(array));

void FillArrayFromConsole(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число {0}", i + 1);
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int NumsGrZero(int[] array)
{
    int Nums = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) Nums++;
    }
    return Nums;
}
