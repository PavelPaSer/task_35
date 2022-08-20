//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int max = 0;
int min = 0;

FillArrayRandomNumbers(numbers);
PrintArray(numbers);


for (int i = 0; i < numbers.Length; i++)
{
   if (numbers[i]> max)
            max = numbers[i];
          if (numbers[i]< max)
            min = numbers[i];
}
Console.WriteLine($"Минимальное число = {max}, Максимальное число = {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 100);
        }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
}