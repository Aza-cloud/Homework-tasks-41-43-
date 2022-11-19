// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь

void GetArray()
{
    Console.Clear();
    Console.Write("Через пробел введите элементы: ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
        result++;
        }
     }
    Console.WriteLine($"Кол-во элементов больше 0: {result}");
}
GetArray();