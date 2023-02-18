// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
 int[] numbers = StringToNum(Console.ReadLine());
{
    throw new NotImplementedException();
}

PrintArray(numbers);
int sum = 0;
for (int i = 0; i < length; i++)
{
    if (numbers[i] > 0)
    {
        sum ++;
    }
} 
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");

