// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел в массиве M" );
int M = Convert.ToInt32(Console.ReadLine());

int[] FillNumbers (int M)
{
    int[] arr = new int[M];
    for (int i = 0; i < M; i++)
    {
       Console.WriteLine($"Введите значение элемента массива M {i} "); 
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountNumbers(int[] arr)

{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
        {
            count++;
        }
      
    }
    return count;
}

int[] array = FillNumbers(M);
Console.WriteLine($"Число элементов больше нуля : {CountNumbers(array)}");

