//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int[] GetCubesNumber(int number)
{
    int[] cubesNumbers = new int[number];

    // Заполнение массива результата
    for (int i = 1; i <= number; i++)
    {
        cubesNumbers[i - 1] = i * i * i;
    }

    return cubesNumbers;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] result = GetCubesNumber(num);
for (int i = 0; i < result.Length; i++) {
    Console.WriteLine(result[i]);
}
