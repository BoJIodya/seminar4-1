void RandomArray(int[] array) //заполняем массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }

}
void coub(int[] array) //возводим в куб каждое число массива и проверяем, четность последнего числа
{
    for (int i = 0; i < array.Length; i++)
    {
        int a = (int)Math.Pow(array[i], 3); // возводим в куб
        if (a % 2 == 0)  // если число четное, то последняя цифра так же четная
        {
            Console.WriteLine($"{a}, четное");
        }
        else
            Console.WriteLine($"{a}, нечетное");

    }
}

int[] array = new int[5];
RandomArray(array);
coub(array);